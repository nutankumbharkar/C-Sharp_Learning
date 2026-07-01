// Inheritance

// 1.

 class Parent
{
    public void Show()
    {
        Console.WriteLine("This is Parent class");
    }
}
class Child:Parent
{     
    public void Display()
    {
        Console.WriteLine("this is child class");
    }
    
}
 

//2.
 class ParentDemo
{
    public void Add(int a,int b)
    {
        Console.WriteLine("Addition is :"+(a+b));
    }
}

class ChildDemo:ParentDemo
{
   public void Multiply(int a,int b) 

{
    Console.WriteLine("Multipication is:"+(a*b));
}

} 

// 3. Method Overriding

 
/* class Parent
{
    public virtual void Show()
    {
        Console.WriteLine("Parent");
    }

}
class Child : Parent
{
    public override void Show()
    {
        Console.WriteLine("Child");
    }
    
} 
 */

//4. Two Child class 


class Payment
{
    public virtual void Pay()
    {
          Console.WriteLine("Payment Pracessing");
    }
}
class CreditCardPayment : Payment
{
    public override void Pay()
    
     {
        Console.WriteLine("Payment Credited");
     }
    

}
    class UPIPayment:Payment
    {
        public override void Pay()
        {
           Console.WriteLine("Payment Method") ;
        }
    }
 

 // Interface

interface IAnimal
{
    void Speak();
}
class Dog:IAnimal
{
   public void Speak()
    {
        Console.WriteLine("Bark");
    } 
}
class Cat:IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meow");
    }
}
