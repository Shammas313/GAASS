# Given a string containing the registrtaion number of all vehicles tracked by Team. 
# Write a program to print the numbers of vehicles which are eligible for Goodies
# Criteria is as follows:
# 1. Vechicle number should in ascending / desending order
# 2. Number can be fancy also, like 111,000,777,9999,6666

n=list(map(str,input("Enter the vehicles numbers seperated by commas:").split(',')))
number_list=[]
winners=[]
j=0
for i in n:
    ind=i.rfind('-')
    number_list.append(list(i[ind+1:]))
    a=number_list[j].copy()
    if (sorted(a)==number_list[j]) or (sorted(a,reverse=True)==number_list[j]):
        winners.append(i)
    j+=1
print(f"Numbers Eligible for Goddies are : {winners}",end=' ')