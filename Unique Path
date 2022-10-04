class UniquePath {
public:
    int a[1000][1000];
    int uniquePaths(int m, int n) {
        if(m==1 && n==1)
        return 1;
    if(m==0||n==0)
        return 0;
    if(a[m][n]==0)
        a[m][n]=uniquePaths(m-1,n)+uniquePaths(m,n-1);
    return a[m][n];
    }
};
