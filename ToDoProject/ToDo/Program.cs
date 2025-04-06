namespace ToDo;

using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        string name;
        string menuChoice;
        int menuNum;
        double toDoCounter;
        double numtoDoItems;
        double efficiencyPercentage;
        string toDo;
        string agenda;

        List<string> toDoList = new List<string>();
        List<string> eventList = new List<string>();
        
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();

        do{
        
            Console.WriteLine($"Hello, {name}! Please choose a number from the menu.\n 1: To Do Log\n 2: Event Log\n 3: To Do Analysis\n 4: Exit");
            menuChoice = Console.ReadLine();
            menuNum = int.Parse(menuChoice);

            if(menuNum == 1)
            {     
                 do{
                    
                    Console.WriteLine("Enter your To Do items.  Please enter 'END' to finish");
                    toDo = Console.ReadLine();
                    toDoList.Add(toDo);

                 } while(toDo != "END");

                 toDoList.Remove("END");

                 foreach (string todo in toDoList){
                    File.AppendAllText("toDoList.txt", todo + "\n");
                 }
            } 
            
            else if(menuNum == 2)
            {
                 
                 do{
                    
                    Console.WriteLine("What events did you do today?  Please enter 'END' to finish");
                    agenda = Console.ReadLine();
                    eventList.Add(agenda);

                 } while(agenda != "END");

                 eventList.Remove("END");

            }

            else if(menuNum == 3)
            {
     
                toDoCounter = 0;
                numtoDoItems = toDoList.Count;

                Console.WriteLine("This is how efficient you were today"); 

                foreach(string item in toDoList){
                    if(eventList.Contains(item)){
                        toDoCounter+= 1;
                    }
                }

                efficiencyPercentage = Math.Round(toDoCounter / numtoDoItems * 100, 2); 
                

                Console.WriteLine($"You completed {toDoCounter} of {numtoDoItems} items on your To Do List.\nYour efficiency percentage is {efficiencyPercentage} %.");  



            }

        } while (menuNum != 4); 

        


    }
}
