#Given an input string . Write a program to print the length of longest prefix which is also the suffix of the given string
#The prefix & Suffix should not overlap. Print 0 if no such prefix exists/

import math as m
n=input("Enter the string :")
prefix=n[:m.floor(len(n)//2)]
suffix=n[m.floor(len(n)//2):]
if prefix==suffix:
    print(f"The longest prefix & suffix in the string : '{n}' is {prefix}")
else:
    i=j=0
    new_prefix=[]
    while j < len(suffix):
        if prefix[i]==suffix[j]:
            new_prefix.append(prefix[i])
            #print(f"i: {i} ,j: {j} ,new_prefix: {new_prefix} ")
            i+=1
            j+=1
        else:
            if len(new_prefix)==0:
                j+=1
            else:
                #print(f"prefix before clear : {new_prefix}")
                new_prefix.clear()
                i=0
    if  len(new_prefix) != 0:
        p=""
        print(f"The longest prefix & suffix in the string : {n} is {p.join(new_prefix)}")
    else:
        print('0')