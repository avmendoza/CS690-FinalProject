namespace ToDo;

using Spectre.Console;

public class ConsoleUI{
        FileSaver fileSaver;

        public ConsoleUI() {
            fileSaver = new FileSaver("toDoList.txt");
        }

        public void Show(){
            
            string name;
            string menuChoice;
            int menuNum;
            
            List<string> TODO = new List<string>();
            List<string> EVENT = new List<string>();
            List<string> toDoCompleted = new List<string>();
        
            name = AskforInput("What is your name?");

            do{
             
            menuChoice = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                        .Title($"{name}, choose a number[green] from the menu[/]")
                         .PageSize(10)
                           .MoreChoicesText("[grey](Move up and down to reveal more To Dos)[/]")
                        .AddChoices(new[] {
                        "1: To Do Log", "2: Event Log", "3: To Do Analysis", 
                    "4: Exit",  
                      }));
            
            menuNum = int.Parse(menuChoice.Substring(0,1));
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
                    r.CreateTable();
                    r.CompletedItems();
                    r.EfficiencyPercentage(); 
                    

                }
                
            } while (menuNum != 4); 

        }

        //function to refactor reading of user input
        public static string AskforInput(string message){
            Console.WriteLine(message);
            return Console.ReadLine();
        }     

    }
