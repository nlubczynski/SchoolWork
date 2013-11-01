import base64
import ssl
from socket import * 

print("Nik's Email Client!")
print("Note: emails are sent from ECE4436ATest@gmail.com")
print("Enter destination email address:")
address = raw_input();
print("Enter message:")
message = raw_input();
print("Number of messages:")
number = raw_input();


# Choose a mail server (e.g. Google mail server) and call it mailserver 
mailserver = "smtp.gmail.com"

#Create socket called clientSocket and establish a TCP connection with mailserver
clientSocket = socket(AF_INET, SOCK_STREAM)
clientSocket.connect((mailserver, 587))

recv = clientSocket.recv(1024) 
print recv 
if recv[:3] != '220': 
    print '220 reply not received from server.' 
 
# Send HELO command and print server response. 
heloCommand = 'HELO Alice\r\n' 
clientSocket.send(heloCommand) 
recv1 = clientSocket.recv(1024) 
print recv1 
if recv1[:3] != '250': 
    print '250 reply not received from server.'

#Start TLS
tlsMessage = "STARTTLS\r\n"
clientSocket.send(tlsMessage)
recv2 = clientSocket.recv(1024) 
print recv2 
if recv2[:3] != '220': 
    print '220 reply not received from server.'

#Wrap the socket in ssl
secureClientSocket = ssl.wrap_socket(clientSocket, ssl_version=ssl.PROTOCOL_SSLv23)
 
# Send EHLO command and print server response. 
heloCommand = 'ehlo google \r\n' 
secureClientSocket.send(heloCommand) 
recv3 = secureClientSocket.recv(1024) 
print recv3 
if recv3[:3] != '250': 
    print '250 reply not received from server.'

#AUTH Command
authMessage = "AUTH LOGIN\r\n"
secureClientSocket.send(authMessage)
recv4 = secureClientSocket.recv(1024)  
print recv4 
if recv4[:3] != '334': 
    print '334 reply not received from server.'

#Login username
username = base64.b64encode('ECE4436ATest@gmail.com')
secureClientSocket.send(username + "\r\n")
recv5 = secureClientSocket.recv(1024)  
print recv5 
if recv5[:3] != '334': 
    print '334 reply not received from server.'

#Login password
password = base64.b64encode('ECE4436ATestECE4436ATest')
secureClientSocket.send(password + "\r\n")
recv6 = secureClientSocket.recv(1024)  
print recv6 
if recv6[:3] != '235': 
    print '235 reply not received from server.'

# Send MAIL FROM command and print server response. 
mailFromCommand = "MAIL FROM:<ECE4436ATesti@gmail.com>\r\n"
secureClientSocket.send(mailFromCommand) 
recv7 = secureClientSocket.recv(1024)  
print recv7 
if recv7[:3] != '250': 
    print '250 reply not received from server.' 
 
# Send RCPT TO command and print server response. 
rcptToCommand = "RCPT TO:<" + address + ">\r\n"
print rcptToCommand;
secureClientSocket.send(rcptToCommand) 
recv8 = secureClientSocket.recv(1024)  
print recv8 
if recv8[:3] != '250': 
    print '250 reply not received from server.'
 
# Send DATA command and print server response. 
# Fill in start 
dataCommand = "DATA\r\n"
secureClientSocket.send(dataCommand) 
recv9 = secureClientSocket.recv(1024)  
print recv9 
if recv9[:3] != '354': 
    print '354 reply not received from server.' 
 
# Send message data. 
endmsg = "\r\n.\r\n?"
secureClientSocket.send(message + endmsg) 
recv10 = secureClientSocket.recv(1024)  
print recv10 
if recv10[:3] != '250': 
    print '250 reply not received from server.'
else:
    print "Message sucessfully sent!" 

secureClientSocket.close()
clientSocket.close()
