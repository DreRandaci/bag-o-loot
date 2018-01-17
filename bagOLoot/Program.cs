using System;

namespace bagOLoot
{
    class Program
    {
        static void Main(string[] args)
        {

            ChildRegister childRegister = new ChildRegister();
            ConsoleKeyInfo enteredKey;

            do
            {
                Child newChild = new Child();
                Console.WriteLine("Enter the first name of a child");
                newChild.FirstName = Console.ReadLine();

                Console.WriteLine("Enter the last name of a child");
                newChild.LastName = Console.ReadLine();

                Console.WriteLine("Enter the address of a child");
                newChild.Address = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine($"Child Name: {newChild.FirstName} {newChild.LastName}");
                Console.WriteLine($"Child Address: {newChild.Address}");
                childRegister.AddChild(newChild);

                Console.WriteLine("Press m to move on or enter to add another child");
                enteredKey = Console.ReadKey();

            } while (enteredKey.Key != ConsoleKey.M);

            Console.WriteLine();
            string selectedChild;
            do
            {
                Console.WriteLine("Assign toy to which child?");
                int count = 1;
                foreach (Child child in childRegister.GetRegister())
                {
                    Console.WriteLine($"{count}. {child.FirstName} {child.LastName}");
                    count++;
                }
                selectedChild = Console.ReadLine();

            } while (enteredKey.Key != ConsoleKey.Escape);



        }
    }
}
