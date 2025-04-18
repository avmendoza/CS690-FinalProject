namespace ToDo;

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
                        
                    toDo = AskforInput("Enter your To Do Items:");
                        
                        toDoList.Add(toDo);

                    finish = AskforInput("Are you finished? [y / n]");
                    
                    if (finish == "y"){
                        toDo = "END";
                    }

                } while(toDo != "END");

                toDoList.Remove("END");

                return toDoList;

        }

        public List<string> EventBuilder(){

             do{
                    
                    agenda =  AskforInput("Enter your Agenda Items:");
                    
                    eventList.Add(agenda);

                    finish = AskforInput("Are you finished? [y / n]");
                    
                    if (finish == "y"){
                        agenda = "END";
                    }

                 } while(agenda != "END");

                 eventList.Remove("END");

                return eventList;

        }

        public static string AskforInput(string message){
            Console.WriteLine(message);
            return Console.ReadLine();
        }
   
                  
    }
            
           

    