using System;
using System.ComponentModel;

// class  Program
// {
//      public static void Main()
//     {
//         int a = 5;
//         int b = a;

//         b = 100;

//         Console.WriteLine(a); 
//     }
// }


// int a = 10;
// float b =a;                    //Implicit casting
// Console.WriteLine(a);


// double a =20.4;
// int b=(int )a;
//Explicit casting
// Console.WriteLine(a);

// int a = 10;
// double b = a / 3;
// Console.WriteLine(b);


// Console.Write("Enter number:");

// string input =Console.ReadLine();                 //convert string into int 
// int num = int.Parse(input);
// Console.WriteLine(num * 2);

// Console.Write("Enter name");
// string name=Console.ReadLine();

// Console.WriteLine("Hello"+name);

// int a=15;
// if(a>=18)
// {
//     Console.WriteLine("you can vote");
// }                                                           //if else statement
// else
// {
//     Console.WriteLine("you can not vote");
// }


// Console.Write("Enter the marks:");
// int marks=int.Parse(Console.ReadLine()); 

// if(marks==60)
// {
//     Console.WriteLine("first class");
// }
// else if(marks>=75)                                           //else_if
// {
//    Console.WriteLine("student got destiction");
// }
// else
// {
//     Console.WriteLine("student fail");
// }



// 1. Class and Object 
// class Program
// {
//     static void Main()
// {
//    Person p1=new Person ();
//    p1.name="Nutan" ;
//    p1.age=18;

// Console.WriteLine(p1.name);
// Console.WriteLine(p1.age);
// }

// }
// class Person
// {
//    public string name;
//     public int age;
// }


//2.Method

// class Program
// {
//     static void add(int a,int b)
//     {
//         Console.WriteLine("This is Addition of Two Numbers ="+(a+b));
//     }
//      static void greek()
//     {
//         Console.WriteLine("Hello Vaibhavi");
//     } 
           
//     static void Main(string[]args)
//     {
//         // add(5,5);
//         greek();
//     }
//  }


 //3.Constructor

// class Constructor
// {
//     public string name;
//     public int age;                      // Defualt Constructor
//     public Constructor()
//     {
//         Console.WriteLine("Hello Constructor");
//     }
// }


 /* class Student
{
     public string name;
     public int age;

     public Student()
     {
         Console.WriteLine("Constructor Called");
         name = "Default Name";
         age = 18;
     }
 } */




//This Keyword 

 
 class Student
 {
    public string name;

     public Student(string name)
    {

        Console.WriteLine("This Keyword call");
        this.name=name;
    }


 } 






 

class Program
{
    static void Main(string[]args)
     {
         // add(5,5);
        //  greek();
        //   Constructor obj = new Constructor();

          /* Student obj =new Student("Nutan");
          Console.WriteLine(obj.name); */
        
         /* ClassObject obj=new ClassObject();
         obj.name = "Nutan";
         obj.Display(); */

         /* Student obj= new Student();
         obj.name="Nutan";
         obj.Display(); */

        /* Calculator obj=new Calculator();
        int result = obj.Add(5, 5);
        Console.WriteLine("Addition is "+result); */

       /*  Demo obj=new Demo();
        obj.ShowMessage(); */

        /* Encapsulation obj=new Encapsulation();
        obj.SetName("Nutan");
        Console.WriteLine(obj.GetName());  */

        /* Person obj=new Person();
        obj.SetAge(21);
        Console.WriteLine(obj.GetAge()); */

        /* Car obj=new Car();
        obj.SetBrand("Honda");
        Console.WriteLine(obj.GetBrand()); */

       /*  Child obj=new Child();
        obj.Show();
        obj.Display(); */

        /* Child obj=new Child();
        obj.Add(5,5);
        obj.Multiply(5,5); */
    
        /* Parent obj=new Child();
        obj.Show(); */


         /* Payment p;
         p=new CreditCardPayment();
          p.Pay();

          p=new UPIPayment();
          p.Pay(); */

          /* Car c=new Car();
          c.Model(); */

          /*  A obj = new C();
        obj.Show(); */


        
/* Empolyee e1 =new Developer();
        Empolyee e2 =new Manager();
        e1.Work();
        e2.Work(); */

        IAnimal i1=new Cat();
        IAnimal i2=new Dog();
        i1.Speak();
        i2.Speak();
        

     }
}

