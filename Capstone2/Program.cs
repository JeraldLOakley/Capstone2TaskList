using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2
{
    class Program
    {
        static void Main(string[] args)
        {



            List<Task> TaskList = new List<Task>();
            {
                TaskList.Add(new Task(false, "Peter", "Clean out old documents"));
                TaskList.Add(new Task(false, "Jacob", "Make new calendar"));
                TaskList.Add(new Task(false, "Danny", "Take class retro survey"));
                TaskList.Add(new Task(false, "Megan", "Present newest project"));
                TaskList.Add(new Task(false, "Bobby", "Finish Capstone2"));
            }

            while (true)
            {
                Title();
                Console.WriteLine();
                Console.WriteLine();
                List<string> MainMenu = new List<string>();
                {
                    MainMenu.Add("List tasks");
                    MainMenu.Add("Add task");
                    MainMenu.Add("Delete task");
                    MainMenu.Add("Mark task complete");
                    MainMenu.Add("Quit");
                }
                int counterTwo = 0;
                foreach (string MenuList in MainMenu)
                {
                    counterTwo++;
                    Console.WriteLine($"{counterTwo}. {MenuList}");
                }
                Console.WriteLine();
                Console.Write("Which menu item would you like to choose?:");
                string MenuChoice = Console.ReadLine().ToLower();

                if (MenuChoice == "list tasks")
                {
                    Console.WriteLine("\tCompletion\t\tDue Date\t\tTeam Member\t\tDescription");
                    int counter = 0;
                    foreach (Task ListofTasks in TaskList)
                    {
                        counter++;

                        Console.WriteLine($"{counter}.{ListofTasks}");

                    }
                    ReturnToMenu();
                    
                }

                else if (MenuChoice == "add task")
                {
                    Console.Write("Who will be taking on this class?: ");
                    string taskOwner = Console.ReadLine();
                    Console.Write("What will this person be doing?:");
                    string taskDescription = Console.ReadLine();
                    TaskList.Add(new Task(false, taskOwner, taskDescription));

                    ReturnToMenu();

                }

                else if (MenuChoice == "delete task")
                {
                    bool DLTask = true;
                    while (DLTask)
                    {
                        Console.Write("Which task would you like to delete?:");
                        string input = Console.ReadLine();
                        int index;
                        bool Success = int.TryParse(input, out index);
                        index--;
                        if (Success)
                        {
                            if (index >= 0 && index < TaskList.Count)
                            {
                                Console.WriteLine($"Are you sure you would like to delete? (y/n):");
                                TLHeader();
                                Console.WriteLine(TaskList[index]);
                                string yn = Console.ReadLine().ToLower();
                                if (yn == "y")
                                {
                                    TaskList.RemoveAt(index);
                                    DLTask = false;
                                    ReturnToMenu();
                                }
                                else if (yn == "n")
                                {
                                    DLTask = false;
                                    Console.WriteLine("OK");
                                    ReturnToMenu();
                                }
                                else
                                {
                                    Console.WriteLine("That was not an option");
                                }
                            }
                            else
                            {
                                Console.WriteLine("That number is not a current task number");
                            }
                        }
                        else
                        {
                            Console.WriteLine("That was not a task number");
                            Console.WriteLine();

                        }
                    }
                }
                else if (MenuChoice == "mark task complete")
                {
                    bool MTComplete = true;
                    while (MTComplete)

                    {
                        Console.Write("Which task would you like to mark as complete?:");

                        string input = Console.ReadLine();
                        int index;
                        bool Success = int.TryParse(input, out index);
                        index--;

                        if (Success)
                        {
                            if (index >= 0 && index < TaskList.Count)
                            {

                                TLHeader();
                                Console.WriteLine(TaskList[index]);
                                Console.Write("Are you sure you want to mark complete?(y/n): ");
                                string yn = Console.ReadLine().ToLower();
                                if (yn == "y")
                                {
                                    TaskList[index].Completion = true;
                                    Console.WriteLine("This task has been marked complete");
                                    ReturnToMenu();
                                    MTComplete = false;
                                }
                                else if (yn == "n")
                                {
                                    Console.WriteLine("OK");
                                    ReturnToMenu();
                                    MTComplete = false;
                                }

                            }
                            else
                            {
                                Console.WriteLine("That is not a current task number");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("That is not a number");
                            Console.WriteLine();
                        }
                    }
                }
                else if (MenuChoice == "quit")
                {
                    bool QTask = true;
                    while (QTask)
                    {
                        Console.WriteLine();
                        Console.Write("Are you sure you would like to quit?(y/n): ");
                        string yn = Console.ReadLine().ToLower();
                        if (yn == "y")
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Goodbye!");
                            return;
                        }
                        else if (yn == "n")
                        {
                            Console.Clear();
                            QTask = false;
                        }
                        else
                        {
                            Console.WriteLine("That was not an option");
                            ReturnToMenu();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That is not a menu item");
                    ReturnToMenu();
                }
            }
        }

        static void Title()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t   Task Manager");
        }

        static void TLHeader()
        {
            Console.WriteLine("\tCompletion\t\tDue Date\t\tTeam Member\t\tDescription");
        }
        
        static void ReturnToMenu()
        {
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
        }


    }
   

}
    


    

