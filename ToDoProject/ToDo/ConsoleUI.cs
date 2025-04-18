namespace ToDo;

public class ConsoleUI{
        FileSaver fileSaver;

        public ConsoleUI() {
            fileSaver = new FileSaver("toDoList.txt");
        }

        public void Show(){
            
            string name;
            int menuNum;
            string toDo;
            string agenda;
            
            List<string> toDoList = new List<string>();
            List<string> eventList = new List<string>();
            List<string> toDoCompleted = new List<string>();
        
            name = AskforInput("What is your name?");

            do{
             
            menuNum = int.Parse(AskforInput($"Hello, {name}! Please choose a number from the menu.\n 1: To Do Log\n 2: Event Log\n 3: To Do Analysis\n 4: Exit"));

                if(menuNum == 1)
                {     
                    do{
                        
                        toDo = AskforInput("Enter your To Do Items:");
                        
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
                    
                    agenda =  AskforInput("Enter your Event Items:");;
                    
                    eventList.Add(agenda);

                 } while(agenda != "END");

                 eventList.Remove("END");

                 foreach(string item in toDoList){
                        if(eventList.Contains(item)){
                            toDoCompleted.Add(item);
                        }
                    }       

                }

                else if(menuNum == 3)
                {
     
                    Reporter r = new Reporter(toDoList, eventList, toDoCompleted);
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
