namespace ToDo;

public class Reporter{
        
        double toDoCompleteCounter = 0;
        double numtoDoItems;
        double numCompleteToDo;
        double efficiencyPercentage;
        public List<string> toDoList;
        public List<string> eventList;
        public List<string> toDoCompleted;
        string message;
        

        //constructor
        public Reporter(List<string> toDoList, List<string> eventList, List<string> toDoCompleted) {

            this. toDoCompleteCounter = toDoCompleteCounter;
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
            Console.WriteLine($"Your efficiency percentage is {efficiencyPercentage} %.");
            
            return efficiencyPercentage;

        }

        //method to state number of completed To Dos vs To Do List
        public void CompletedItems(){

            numtoDoItems = toDoList.Count;
            toDoCompleteCounter = toDoCompleted.Count;

            Console.WriteLine($"You completed {toDoCompleteCounter} of {numtoDoItems} items on your To Do List.\n"); 

            Console.WriteLine("Completed To Do items:");

                foreach(string item in toDoCompleted){
                        Console.WriteLine($" {item}");
                }    
                  
         }
            
           

    }

