import random

meetings = [random.randint(1, 10) for _ in range(4)]
print (meetings)
meetings.append(10)
print(meetings)
#-----------------------
total = 0 
#for i in range(len(meetings)):
#    print(i, meetings[i])
#    total += meetings[i]
    
total = sum(meetings)
    
print("The average number of people at a meeting: " + str(round(total/len(meetings))))