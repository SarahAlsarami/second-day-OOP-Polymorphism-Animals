using System;

public class Animal
{
    // public void test ()
    // {
    //     Console.WriteLine("Animal public");
    // }
    //    private  void testpr()
    // {
    //     Console.WriteLine("Animal private");
    // }
    //    protected  void testpro()
    // {
    //     Console.WriteLine("Animal protected");
    // }
    public virtual void makeSound()
    {
        Console.WriteLine("anything");
    }
}

public class Cat : Animal
{
    
    public override void makeSound()
    {
        Console.WriteLine("meow");
    }
}
public class Dog : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("woof");
    }
}
public class Eagle : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("screech");
    }
}
class Program
{
    static void Main()

    {
        Animal myCat = new Cat();
        Animal myDog = new Dog();
        Animal myEagle = new Eagle();
        Animal myBride = new Bride();

        myCat.makeSound();
        myDog.makeSound();
        myBride.makeSound();


List<Animal> myAnimals = new List<Animal>{new Dog(),new Cat(),new Eagle(),new Bride()};

        foreach (Animal animal in myAnimals)
        {
            animal.makeSound();
        }
    }
}

