# if command, functions,  for loop, list, random 
#find the biggest number

import random

results = [0,0,0,0,0,0,0,0,0,0,0]

for i in range(1,1000000):
    dice1 = random.randint(1,6)
    dice2 = random.randint(1,6)
    outcome = dice1 + dice2
    results[outcome-2] += 1
  
for i in range(1,11):
    print(i+2, results[i])


    