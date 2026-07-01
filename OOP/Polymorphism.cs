// Polymorphim 

/* class Car
{
    public virtual void Model()
    {
        Console.WriteLine("This is Car");
    }
}
class Price:Car
{
    public override void Model()
    {
        
    Console.WriteLine("This is 400000");
} 
}
 */

/* class A
{
    public virtual void Show()
    {
        Console.WriteLine("A");
    }
}

class B : A
{
    public override void Show()
    {
        Console.WriteLine("B");
    }
}

class C : B
{
    public override void Show()
    {
        Console.WriteLine("C");
    }
}  */


// New Keyword in polymorphism



class Empolyee
{
    public void Work()
    {
        Console.WriteLine("I am Employer");
    }
}
class Developer:Empolyee
{
    public new void  Work()
    {
        Console.WriteLine("I am Developer");
    }
}
class Manager : Empolyee
{
    public new void Work()
    {
        Console.WriteLine("I am Manager");
    }
}