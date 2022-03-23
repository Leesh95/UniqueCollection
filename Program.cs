using System.Collections.Generic;
using System.Collections;

namespace UniqueCollections
{
    class Program
    {
        public static void Main()
        {
            bool breakloop = false;
            //
            UniqueCollection<string> NameList = new UniqueCollection<string>();
            while (!breakloop)
            {
                Console.WriteLine(@"
    ------------------ MENU ------------------
    Choose an option from the following list:
    ( a ) Add name
    ( b ) Contains
    ( c ) Clear List
    ( d ) Delete name
    ( e ) Enumerate
    ( q ) Quit
    Your option?");
                //
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "q")
                {
                    breakloop = true;
                }
                //
                switch (userInput)
                {
                    case "a":
                        Console.WriteLine("Please enter name to the list: ");
                        string nameToAdd = Console.ReadLine();
                        NameList.Add(nameToAdd);
                        Console.WriteLine($"{nameToAdd} is added!");
                        break;
                    //
                    case "b":
                        Console.WriteLine("Enter name to check if it is found in the List: ");
                        string checkIfContains = Console.ReadLine().ToLower();
                        bool answer = NameList.Contains(checkIfContains);

                        if (answer)
                            Console.WriteLine($"The name {checkIfContains} is in the list");
                        else
                            Console.WriteLine($"The name {checkIfContains} is not in the list");
                        break;
                    //
                    case "c":
                        NameList.Clear();
                        Console.WriteLine("List Cleared!");
                        break;
                    //
                    case "d":
                        Console.WriteLine("Please enter name to delete from the list: ");
                        string nameToDelete = Console.ReadLine();
                        NameList.Remove(nameToDelete);
                        Console.WriteLine($"{nameToDelete} is deleted!");
                        break;
                    //
                    case "e":
                        foreach (var name in NameList)
                        {
                            Console.WriteLine(name);
                        }
                        break;
                }
            }
        }
    }
}