// Console.WriteLine("Hello, World!");

// int a=3;
// int c=56;
// int d=a+c;
// System.Console.WriteLine(d);

int[] susan=new int[5];
susan=[1,2,3,4,5];
int product=1;
int sum=0;
for (int i = 0; i < susan.Length; i++)
{
    if (susan[i]%2==0)
    {   susan[i]*=product;
        System.Console.WriteLine("cutdur");
    }
    else
    {   
        susan[i]+=sum;
        System.Console.WriteLine("tekdir");
    }
}