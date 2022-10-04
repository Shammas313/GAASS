class Solution:
    def isHappy(self, n: int) -> bool:
        if n==1:
            return True
        if n>0:
            li=[]
            num = str(n)
            while num!='1':
                sums =0
                for x in num:
                    print(x)
                    x=int(x)
                    sqr = x*x
                    sums = sums+sqr
                if sums not in li:
                    li.append(sums)
                else:
                    return False
                if sums==1:
                    return True
                else:
                    num=str(sums)
                
        else:
            False
