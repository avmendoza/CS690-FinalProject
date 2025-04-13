namespace ToDo.Tests;

using ToDo;

public class FileSaverTests
{

    FileSaver fileSaver;
    string testFileName;

    public FileSaverTests(){
        testFileName = "test-doc.txt";
        fileSaver = new FileSaver(testFileName);
    }

    [Fact]
    public void Test_FileSaver_Append()
    {
        fileSaver.AppendLine("Hello, World!");
        var contentsFromFile = File.ReadAllText(testFileName);
        Assert.Equal("Hello, World!" +Environment.NewLine,contentsFromFile);

    }
}