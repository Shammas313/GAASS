class plusOnes:
    def plusOne(self, digits: List[int]) -> List[int]:
        strnum = ''
        for x in digits:
            strnum = strnum + str(x)
        newnum = int(strnum)+1
        strnum2 = str(newnum)
        newarray =[]
        for num in strnum2:
            num2 = int(num)
            newarray.append(num2)
        return newarray 
        
