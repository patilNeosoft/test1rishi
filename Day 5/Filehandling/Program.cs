
using Filehandling.Model;

    FileStream fs = new FileStream("file1.txt", FileMode.Open, FileAccess.ReadWrite);
    StreamReader sr = new StreamReader(fs);
    StreamWriter sw = new StreamWriter(fs);
    string str = "ok";
    sw.WriteLine(str);
    for (int i = 0; i < fs.Length; i++) {
    Console.WriteLine(sr.ReadLine());
    }
    sw.Close();
    fs.Close();

//extract file path
string path = "";
path = Environment.CurrentDirectory;
Console.WriteLine($"file path is :{path}");
   


