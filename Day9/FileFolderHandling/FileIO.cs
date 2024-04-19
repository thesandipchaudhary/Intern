using System.IO;

class FileIO
{
    string folderPath = @"/Users/sandipchaudhary/Documents/Training/Intern/Day9/FileFolderHandling";
    
    //Create a text file
    public void CreateFile()
    {        
        string fileName = "student.txt";
        string filePath = Path.Combine(folderPath, fileName);
        
        File.WriteAllText(filePath, "this is first line");
    }

    public void CreateFileWithInFolder()
    {
        string newFolderName = "Student";
        string newFodlerPath = Path.Combine(folderPath, newFolderName);
        Directory.CreateDirectory(newFodlerPath);

        string fileName = "Student1.txt";
        string filePath = Path.Combine(newFodlerPath, fileName);
        
        File.WriteAllText(filePath, "this is first line");
    }
}