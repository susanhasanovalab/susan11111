// Console.WriteLine("Hello, World!");

// int a=3;
// int c=56;
// int d=a+c;
// System.Console.WriteLine(d);

// int[] susan=new int[5];
// susan=[1,2,3,4,5];
// int product=1;
// int sum=0;
// for (int i = 0; i < susan.Length; i++)
// {
//     if (susan[i]%2==0)
//     {   susan[i]*=product;
//         System.Console.WriteLine("cutdur");
//     }
//     else
//     {   
//         susan[i]+=sum;
//         System.Console.WriteLine("tekdir");
//     }
// }

// using System;

// class User
//     public string Name { get; set; }

//     private string email;

//     public string Email
//     {
//         get { return email; }
//         set
//         {
//             if (string.IsNullOrEmpty(value))
//                 Console.WriteLine("Email cannot be empty");
//             else
//                 email = value;
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         User user = new User();

//         user.Name = "Susen";
//         user.Email = "";
//     }
// }



using System;

class Program
{
    static void Main()
    {
        // Customer
        Customer c1 = new Customer();
        c1.Name = "Susen";
        c1.Email = "susen@gmail.com";
        c1.Balance = 100;

        // Product (Phone)
        Phone p1 = new Phone("iPhone", 2000, 5, "Apple", 128);

        // Order
        Order o1 = new Order(c1, p1, 2);

        Console.WriteLine("Customer: " + c1.Name);
        Console.WriteLine("Product: " + p1.Name);
        Console.WriteLine("Total Price: " + o1.TotalPrice);
        Console.WriteLine("Remaining Stock: " + p1.Stock);
    }
}