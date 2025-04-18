namespace ToDo;

public class ConsoleUI{
        FileSaver fileSaver;

        public ConsoleUI() {
            fileSaver = new FileSaver("toDoList.txt");
        }

        public void Show(){
            
            string name;
            int menuNum;
            string agenda;
            
            List<string> TODO = new List<string>();
            List<string> EVENT = new List<string>();
            List<string> toDoCompleted = new List<string>();
        
            name = AskforInput("What is your name?");

            do{
             
            menuNum = int.Parse(AskforInput($"Hello, {name}! Please choose a number from the menu.\n 1: To Do Log\n 2: Event Log\n 3: To Do Analysis\n 4: Exit"));
            DataManager databuild = new DataManager(TODO, EVENT);

                if(menuNum == 1)
                {     
                    TODO = databuild.ToDoBuilder();
                    
                    foreach (string todo in TODO){
                        fileSaver.AppendLine(todo);
                    }

                } 
                
                else if(menuNum == 2)
                {
                 
                    EVENT = databuild.EventBuilder();
                 
                    foreach(string item in TODO){
                        if(EVENT.Contains(item)){
                            toDoCompleted.Add(item);
                        }
                    }       

                }

                else if(menuNum == 3)
                {
     
                    Reporter r = new Reporter(TODO, EVENT, toDoCompleted);
                    r.CompletedItems();
                    r.EfficiencyPercentage(); 

                }
                
            } while (menuNum != 4); 

        }

        public static string AskforInput(string message){
            Console.WriteLine(message);
            return Console.ReadLine();
        }     

    }
