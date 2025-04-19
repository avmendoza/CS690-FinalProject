namespace ToDo;

using Spectre.Console;

public class DataManager {
        
        string toDo;
        string agenda;
        string finish;
        public List<string> toDoList;
        public List<string> eventList;
        public List<string> toDoCompleted;
        

        //constructor
        public DataManager(List<string> toDoList, List<string> eventList) {

            this.toDo = toDo;
            this.toDoList = toDoList;
            this.eventList = eventList;
            this.toDoCompleted = toDoCompleted; 
            this.agenda = agenda;
            this.finish = finish;
             
        }

        //method to create List of To Dos
        public List<string> ToDoBuilder(){

             do{
                        
                    toDo = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                        .Title("What are your To Dos[green][/]?")
                         .PageSize(10)
                           .MoreChoicesText("[grey](Move up and down to reveal more To Dos)[/]")
                        .AddChoices(new[] {
                        "Eat", "Sleep", "Study CS", 
                    "Exercise", "Walk Dog", "Do Dishes",
                    "END",
                      }));

                    toDoList.Add(toDo);
                    


                } while(toDo != "END");

                toDoList.Remove("END");
               

                return toDoList;

        }

        public List<string> EventBuilder(){

             do{
                    
                    agenda =  AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                        .Title("What are your Agenda Items[green][/]?")
                         .PageSize(10)
                           .MoreChoicesText("[grey](Move up and down to reveal more To Dos)[/]")
                        .AddChoices(new[] {
                        "Eat", "Sleep", "Study CS", 
                    "Exercise", "Walk Dog", "Do Dishes", "Social Media",
                    "Internet Shopping", "Watching TV", "END",
                      }));
                    
                    eventList.Add(agenda);

                 } while(agenda != "END");

                 eventList.Remove("END");

                return eventList;

        }

        public static string AskforInput(string message){
            Console.WriteLine(message);
            return Console.ReadLine();
        }
   
                  
    }
            
           

    