namespace ToDo;

public class ConsoleUI{
        FileSaver fileSaver;

        public ConsoleUI() {
            fileSaver = new FileSaver("toDoList.txt");
        }

        public void Show(){
            
            string name;
            int menuNum;
            double toDoCounter;
            double numtoDoItems;
            double efficiencyPercentage;
            string toDo;
            string agenda;

            List<string> toDoList = new List<string>();
            List<string> eventList = new List<string>();

            name = AskforInput("What is your name?");

            do{
             
             menuNum = int.Parse(AskforInput($"Hello, {name}! Please choose a number from the menu.\n 1: To Do Log\n 2: Event Log\n 3: To Do Analysis\n 4: Exit"));

                if(menuNum == 1)
                {     
                    do{
                      
                        toDo =  AskforInput("Enter your To Do items.  Please enter 'END' to finish");
                        toDoList.Add(toDo);

                    } while(toDo != "END");

                 toDoList.Remove("END");

                 foreach (string todo in toDoList){ 
                        fileSaver.AppendLine(todo);
                    }
                } 
                

                else if(menuNum == 2)
                {
                 
                 do{
                    
                    agenda = AskforInput("What events did you do today?  Please enter 'END' to finish");
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

        public static string AskforInput(string message){
            Console.WriteLine(message);
            return Console.ReadLine();
        }     

    }
