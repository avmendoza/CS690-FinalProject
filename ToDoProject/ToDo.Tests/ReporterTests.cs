namespace ToDo.Tests;

using ToDo;

public class ReporterTests
{

    Reporter reporter;
    List<string> toDoList;  
    List<string> eventList;  
    List<string> toDoCompleted;  

    
    public ReporterTests(){

        toDoList = new List<string> {"eat", "love", "pray", "study"};
        eventList =  new List<string> {"eat", "exercise", "study"};
        toDoCompleted =  new List<string>  {"eat", "study"};
     
        reporter = new Reporter(toDoList, eventList, toDoCompleted);
    
    }

    [Fact]
    public void Test_EfficiencyPercentage()
    {
 
        double calc = reporter.EfficiencyPercentage();
        Assert.Equal(50, calc);

    }
}