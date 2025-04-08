namespace Mod3EnumDemoCore
{
    //CREATE NEW ENUM, WILL ALWAYS BELONG TO A NAMESPACE
    //value type data (stored on stack)
    enum Seasons
    {
        Winter = 1, //doesn't need "", already being used as a string
        Spring, //spring will be enumerated as number 2 by default, can change the numbers  by winter = 1,
        Summer,
        Fall //last one doesn't need a , or ;

    }

    enum ErrorCodes
    {
        Not_Found = 400, //cannot add space between, can use _ --Not_Found or NotFound
        Internal_Server_Error = 500
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConsoleColor. //just showing you can use it to change console color
            //System.IO.FileStream obj = new FileStream("",FileMode.Open);

            PrintFavSeason(Seasons.Spring);

            //<allows you to specify which value type you want to create a list of. In this case, class ToDo
            //create a collection class, do not need to specify a size
            List<ToDo> todolist = new List<ToDo>(); //dynamic.  List stores objects of type ToDo (type parameter)
            //Add method to add a new object to ToDo
            //In this todolist, I'm adding a new Task/item to list (object of ToDo)
            //1st way to do it, shortcut way of assigning property values
            todolist.Add(new ToDo() { TaskId = 1, Description = "Study for Test", EstimatedHours = 1.5f, TaskStatus = Status.NotStarted });

            //THIS does the same thing as above in line 34, adding another task to todolist
            //2nd way to do it
            ToDo mytodo = new ToDo();
            mytodo.TaskId = 2;
            mytodo.Description = "Do challenge labs";
            mytodo.EstimatedHours = 3.5f;
            mytodo.TaskStatus = Status.Completed;
            todolist.Add(mytodo);
            //Added another task to todolist
            todolist.Add(new ToDo() { TaskId = 3, Description = "Mentor Calls", EstimatedHours = 2.0f, TaskStatus = Status.Dismissed });
            //Adding another task to todolist
            todolist.Add(new ToDo() { TaskId = 4, Description = "Build a resume", EstimatedHours = 5.0f, TaskStatus = Status.InProgress });
            //Adding another task to todolist
            todolist.Add(new ToDo() { TaskId = 5, Description = "Download VS", EstimatedHours = 0.5f, TaskStatus = Status.Completed });


            //All the above are test data

            //Call the PrintList function passing the todolist to it
            PrintList(todolist);
            Console.ReadKey();
        }

        static void PrintList(List<ToDo> todos) //reference type because it's a collection class--
        {
            foreach(var todo in todos) //foreach of the todo is todos -- iteration of a list
            {
                switch(todo.TaskStatus)
                {
                    case Status.Dismissed: //if status is Dismissed, will change console foreground color to red
                        Console.ForegroundColor = ConsoleColor.Red; break;
                    case Status.InProgress: //if status is InProgress, will change console foreground color to yellow
                        Console.ForegroundColor = ConsoleColor.Yellow; break;
                    case Status.Completed: //if status is Completed, will change console foreground color to green
                        Console.ForegroundColor = ConsoleColor.Green; break;
                    case Status.OnHold: //if status is OnHold, will change console foreground color to Magenta
                        Console.ForegroundColor = ConsoleColor.Magenta; break;
                    case Status.NotStarted: //if status is NotStarted, will change console foreground color to Blue
                        Console.ForegroundColor = ConsoleColor.Blue; break;
                    default:Console.ForegroundColor = ConsoleColor.White; break; //Default color is white (default case)
                }
                //Come out of switch case and display ALL the todos with the respective color
                Console.WriteLine($"{todo.TaskId}, {todo.Description}, {todo.EstimatedHours}, {todo.TaskStatus}");
            }
        }

        static void PrintFavSeason(Seasons favseason)
        {
            int val = (int)favseason; //convert the value of the favseason. Type-casting because it's (favseason) internally valued as a string
            //
            Console.WriteLine($"Your favorite season is: {favseason.ToString()} - {val}"); //favseason.ToString() is not necessary, it was a suggestion that popped up and she just tabbed through it
        }
    }
}
