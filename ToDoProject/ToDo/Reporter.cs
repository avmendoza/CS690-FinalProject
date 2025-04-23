namespace ToDo;

using Spectre.Console;

public class Reporter{
        
        double toDoCompleteCounter;
        double numtoDoItems;
        double numCompleteToDo;
        double efficiencyPercentage;
        public List<string> toDoList;
        public List<string> eventList;
        public List<string> toDoCompleted;
        

        //constructor
        public Reporter(List<string> toDoList, List<string> eventList, List<string> toDoCompleted) {

            this.toDoCompleteCounter = toDoCompleteCounter;
            this.numtoDoItems = numtoDoItems;
            this.toDoList = toDoList;
            this.eventList = eventList;
            this.toDoCompleted = toDoCompleted;
            this.numCompleteToDo = numCompleteToDo; 
             
        }

        //method to calculate % of To Dos
        public double EfficiencyPercentage(){

            numtoDoItems = toDoList.Count;
            numCompleteToDo = toDoCompleted.Count;

            efficiencyPercentage = Math.Round(numCompleteToDo / numtoDoItems * 100, 2);    
            Console.WriteLine($"Your productivity percentage is {efficiencyPercentage}%.");
            
            if (efficiencyPercentage < 50) {
                Console.WriteLine("OK! You can do better!");
            }

            else if((efficiencyPercentage > 50) && (efficiencyPercentage < 75)){
                Console.WriteLine("Good job! You are getting things done.");
            }
            
            else {
                Console.WriteLine("Excellent! You were very productive today.");
            }
            
            return efficiencyPercentage;

        }

        //method to state number of completed To Dos vs To Do List
        public double CompletedItems(){

            numtoDoItems = toDoList.Count;
            toDoCompleteCounter = toDoCompleted.Count;

            Console.WriteLine($"You completed {toDoCompleteCounter} of {numtoDoItems} items on your To Do List.\n"); 

            Console.WriteLine("Completed To Do items:");

                foreach(string item in toDoCompleted){
                        Console.WriteLine($" {item}");
                } 

            return toDoCompleteCounter;   
                  
         }

        //creates Spectre console summary tables
        public void CreateTable(){

             var table = new Table();
                table.AddColumn("MY TO DO LIST");
                foreach(var td in toDoList){
                    table.AddRow(td);
                }
            AnsiConsole.Write(table);

            var table1a = new Table();
                table1a.AddColumn("MY COMPLETED TO DOS");
                foreach(var tdc in toDoCompleted){
                    table1a.AddRow(tdc);
                }
            AnsiConsole.Write(table1a);
            
            var table2 = new Table();
                table2.AddColumn("MY ACTUAL EVENTS");
                foreach(var evnt in eventList){
                    table2.AddRow(evnt);
                }
            AnsiConsole.Write(table2);


        
        }
            
           

    }

