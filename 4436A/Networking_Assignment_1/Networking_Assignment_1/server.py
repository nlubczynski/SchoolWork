# UDPPingerServer.py 
# We will need the following module to generate randomized lost packets 
import random 
import sys
import time
from socket import * 
 
# Create a UDP socket 
# Notice the use of SOCK_DGRAM for UDP packets 
serverSocket = socket(AF_INET, SOCK_DGRAM) 
# Assign IP address and port number to socket 
serverSocket.bind(('', 12000)) 

lastID = -1
lastTime = 0
first = 1

while True:
    # Generate random number in the range of 0 to 10
    rand = random.randint(0, 10) 
    # Receive the client packet along with the address it is coming from 
    message, address = serverSocket.recvfrom(1024)
    # Capitalize the message from the client 
    message = message.upper()
    print(message)
    print(address)

    #modifications
    receivedMessage = message.split(" ")
    receiveTime = time.clock()
    TripTime = receiveTime - float(receivedMessage[2])
    pingID = receivedMessage[1]

    #timeout stuff
    if(first):
        lastTime = receiveTime
    else:
        if(receiveTime - lastTime > 1):
            print("Server: Ping #" + pingID + " timed out")
            first = 1
            continue
        else:
            lastTime = receiveTime

    if(TripTime > 1): #1 second time out
        print("Server: Ping #" + pingID + " timed out")
        first = 1
        continue
    #end timeout stuff

    while(int(pingID) - lastID != 1):
        print("Server: Missing ping #" + str(lastID +1))
        lastID += 1
    print("Server: Received ping #" + pingID)
    lastID += 1

    # If rand is less is than 4, we consider the packet lost and do not respond
    if rand < 4:
        continue
    # Otherwise, the server responds 
    serverSocket.sendto(message, address)

    #not first
    first = 0