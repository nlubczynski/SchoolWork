from socket import * 
import sys 
 
if len(sys.argv) <= 1: 
    print 'Usage : "python ProxyServer.py server_ip"\nserver_ip : It is the IP Address Of Proxy Server' 
    sys.exit(2) 
 
# Create a server socket, bind it to a port and start listening 
tcpSerSock = socket(AF_INET, SOCK_STREAM) 
# Assign IP address and port number to socket
#sys.arg[1] is the second input (first is script) that contains the ip address we want 
tcpSerSock.bind((sys.argv[1], 12000)) 
tcpSerSock.listen(1)

while 1: 
    # Start receiving data from the client 
    print 'Ready to serve...' 
    tcpCliSock, addr = tcpSerSock.accept() 
    print 'Received a connection from:', addr 
    message = tcpCliSock.recv(1024);
    print message 
    # Extract the filename from the given message
    if(len(message.split()) < 2):
        print "Error"
        continue 
    print message.split()[1] 
    filename = message.split()[1].partition("/")[2] 
    print filename 
    fileExist = "false" 
    filetouse = "/" + filename 
    print filetouse 
    try: 
        # Check wether the file exist in the cache 
        f = open(filetouse[1:], "r") 
        outputdata = f.readlines() 
        fileExist = "true" 
        # ProxyServer finds a cache hit and generates a response message 
        tcpCliSock.send("HTTP/1.0 200 OK\r\n") 
        tcpCliSock.send("Content-Type:text/html\r\n") 
        # Fill in start.
        for line in outputdata:
            tcpCliSock.send(line) 
        # Fill in end. 
        print 'Read from cache' 
    # Error handling for file not found in cache 
    except IOError: 
        if fileExist == "false": 
            # Create a socket on the proxyserver 
            c = socket(AF_INET, SOCK_STREAM)
            hostn = filename.replace("www.","",1) 
            print hostn 
            try: 
                # Connect to the socket to port 80 
                c.connect((hostn,80)) 
                 
                # Create a temporary file on this socket and ask port 80 for the file requested by the client 
                fileobj = c.makefile('r', 0) 
                fileobj.write("GET "+"http://" + filename + " HTTP/1.0\n\n")
                # Read the response into buffer 
                # Fill in start.
                buffer = fileobj.readlines()
                # Fill in end. 
                # Create a new file in the cache for the requested file. 
                # Also send the response in the buffer to client socket and the corresponding file in the cache 
                tmpFile = open("./" + filename,"wb") 
                for line in buffer:
                    tmpFile.write(line)
                    tcpCliSock.send(line)
            except error as e: 
                print "Illegal request" 
                print 'something\'s wrong with %s:%d. Exception type is %s' % (hostn, 80, e)
                # HTTP response message for file not found 
                tcpCliSock.send("HTTP/1.0 404 Not Found\r\n")
                tcpCliSock.send("Content-Type:text/html\r\n\r\n")
                tcpCliSock.send("<!DOCTYPE html><html><head><title>404 Not Found</title></head><body>404 Not Found</body></html>") 
        else: 
            # HTTP response message for file not found 
            tcpCliSock.send("HTTP/1.0 404 Not Found\r\n")
            tcpCliSock.send("Content-Type:text/html\r\n\r\n")
            tcpCliSock.send("<!DOCTYPE html><html><head><title>404 Not Found</title></head><body>404 Not Found</body></html>") 
            
    # Close the client and the server sockets 
    tcpCliSock.close() 
# Fill in start. 
# Fill in end. 
