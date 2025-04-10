// public class Animal
// {
//     public string Name;
//
//     public virtual void Speak()
//     {
//         Console.WriteLine("Animal make a sound");
//     }
// }
//
// public class Dog : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine($"{Name}says Woof!");
//     }
// }
//
// public class Cat : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine($"{Name}says Meaw!");
//     }
// }
//
// public class Program
// {
//     public static void Main()
//     {
//         Dog dog = new Dog { Name = "Buddy" };
//         Cat cat = new Cat { Name = "Kitty" };
//
//         dog.Speak();
//         cat.Speak();
//
//         Animal animalDog = new Dog { Name = "Max" };
//
//         animalDog.Speak();
//     }
// }
