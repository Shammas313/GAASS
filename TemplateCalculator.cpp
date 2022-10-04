#include<iostream>
using namespace std;
template<class T>
class cal
{
public:
    T a,b,c;
    void getdata();
    T add(T x,T y);
    T sub(T x,T y);
    T mul(T x,T y);
    T div(T x,T y);
    T mod(T x,T y);
};
template<class T>
void cal<T>::getdata()
{
    cout<<"Enter First and second number";
    cin>>a>>b;
}
template<class T>
T cal<T>::add(T x, T y)
{
    return x+y;
}
template<class T>
T cal<T>::sub(T x,T y)
{
    return x-y;
}
template<class T>
T cal<T>::mul(T x,T y)
{
    return x*y;
}
template<class T>
T cal<T>::div(T x,T y)
{
    return x/y;
}
template<class T>
T cal<T>::mod(T x,T y)
{
    return int(x)%int(y);
}

int main()
{
    cal<float> ob1;
    ob1.getdata();
    cout<<"\nSum is "<<ob1.add(ob1.a,ob1.b);
    cout<<"\nDifference is "<<ob1.sub(ob1.a,ob1.b);
    cout<<"\nProduct is "<<ob1.mul(ob1.a,ob1.b);
    cout<<"\nQuotient is "<<ob1.div(ob1.a,ob1.b);
    cout<<"\nModulus is "<<ob1.mod(ob1.a,ob1.b);

}
