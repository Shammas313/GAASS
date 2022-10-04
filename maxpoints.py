class maxPoint:
    def maxPoints(self, points: List[List[int]]) -> int:
        c=len(points)
        l=[]
        for i in range(c):
            
            for j in range(i+1,c):
                t=2
                for k in range(c):
                    if k!=i and k!=j:
                        if (points[j][1]-points[i][1])*(points[k][0]-points[i][0])==(points[k][1]-points[i][1])*(points[j][0]-points[i][0]):
                            t=t+1
                l.append(t)            
        try:        
            s=max(l)
        except:
            return 1
        return s
