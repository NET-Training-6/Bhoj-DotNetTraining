using System.IO;
class FileAndDirectory
{
    private object file;

    public void LearnFile()
    {
        // @ = verbatim character
      var folderpath = @"E:\DotNet- Training\Bhoj-DotNetTraining\helloapp\TextFile";

        var fullfilepath = @$"{folderpath}\test.txt";

        File.WriteAllText(fullfilepath, "Hello world!");

       var folder = @$"{folderpath}\test";

        Directory.CreateDirectory(folder);

        // create a folder with name "A" somewhere and create a text a file inside "A"
         var folder1 = folderpath +"\\A";
        Directory.CreateDirectory(folderpath + "\\A");
        File.WriteAllText(folder1 + "\\a.txt", "Nepal is a beautiful");

        // create 10 folders with name folder1, folder2, folder3 ....folder10.
        var folder2 = folderpath +"\\folder";
        Directory.CreateDirectory(folderpath + "\\A");
       File.WriteAllText(folder1 + "\\a.txt", "Nepal is a beautiful");
       for(int i =1; i<10; i++)
       {
        
       }

    }
}