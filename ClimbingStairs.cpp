class Stairs:
    def climbStairs(self, n: int,memo={}) -> int:
    
        if n==2:
            return 2
        if n==1:
            return 1
        if n not in memo:
            memo[n]= self.climbStairs(n-1) + self.climbStairs(n-2)
        return memo[n]class Stairs:
    
