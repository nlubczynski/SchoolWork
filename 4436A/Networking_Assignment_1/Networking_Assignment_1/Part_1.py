import subprocess, time, sys, os
from socket import * 
import random

#set "global"ish variables
local = ''
target_ip = '127.0.0.1'
number_of_messages = ''
heartbeat = ''

while(heartbeat.lower() != "yes" and heartbeat.lower() != "no"):
    print('Client: Are you going into UDP heartbeat mode? ("yes" or "no")')
    heartbeat = raw_input();

if(heartbeat.lower() == 'no'):
    while(local.lower() != "yes" and local.lower() != "no"):
        print('Client: Are you pinging the local server? ("yes" or "no")')
        local = raw_input();

    if(local.lower() == 'yes'):
        #Start the server
        print('Client: Starting Server')
        #Get the current directory
        dirname, filename = os.path.split(os.path.abspath(sys.argv[0]))
        #Start the server as a subprocess
        serverPID = subprocess.Popen( [ sys.executable, os.path.join(dirname, 'server.py') ])
        #give the server time to start
        time.sleep(1);
    else:
        print('Client: Enter a destination IP address')
        target_ip = raw_input()

    print('Client: How many pings to send?')
    number_of_messages = raw_input()
else:
        #Start the server
        print('Client: Starting Server')
        #Get the current directory
        dirname, filename = os.path.split(os.path.abspath(sys.argv[0]))
        #Start the server as a subprocess
        serverPID = subprocess.Popen( [ sys.executable, os.path.join(dirname, 'server.py') ])
        #give the server time to start
        time.sleep(1);

# Create a UDP socket 
serverSocket = socket(AF_INET, SOCK_DGRAM)
#setTimeout to 1 second
serverSocket.settimeout(1.0)
#total for average
total = 0
max = 0
min = -1 
numberReceived = 0

if(heartbeat.lower() == 'no'):
    for x in range (0, int(number_of_messages)):
        #get the send time
        startTime = time.clock()
        #compose the message
        message = "Ping " + str(x) + " " + str(startTime) 
        #send the ping
        serverSocket.sendto(message, (target_ip, 12000) )
        #try/catch on the receive
        try:
            receive, address = serverSocket.recvfrom(1024)
            receiveTime = time.clock()
        except:
            #didn't receive it, print timeout error and continue
            print("Client: Request timed out")
            continue
        #split the message
        receivedMessage = receive.split(" ")
        RTT = receiveTime - float(receivedMessage[2])
        if( RTT > max ):
            max = RTT
        if( RTT < min or x == 0 ):
            min = RTT
        total += RTT
        numberReceived += 1
        output = receivedMessage[0] + " " + receivedMessage[1] + " RTT: " + str(RTT) + " seconds"
        print("Client: " + output)
    if(numberReceived > 0):
        print( "Client: Average RTT:" + str(total/numberReceived) + " seconds" )
        print( "Client: Packet loss:" + str( ( 1 - numberReceived/ float(number_of_messages) ) * 100) + "%" )
        print( "Client: Max RTT:" + str(max) + "seconds" )
        print( "Client: Min RTT:" + str(min) + "seconds" )
    else:
        print("Client: 100% packet loss")
else:
    x = 0
    while(1):
        # Generate random number in the range of 0 to 10
        rand = random.randint(0,10)
        #get the send time
        startTime = time.clock()
        #compose the message
        message = "Ping " + str(x) + " " + str(startTime) 
        x += 1
        #send the ping
        if( rand == 1):
            continue
        #simulate "slow" packet
        if( rand == 0 ):
            time.sleep(1);
        serverSocket.sendto(message, (target_ip, 12000) )
        time.sleep(1);


if(local.lower() == 'yes'):
    #kill the server
    print('Client: Stopping Server');
    serverPID.terminate()