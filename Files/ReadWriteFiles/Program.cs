// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Reading and Writing data from and to files

// Make sure the example file exists
const string filename = "TestFile.txt";

// TODO 1: WriteAllText overwrites a file with the given content
if (!File.Exists(filename)) {
    file.WriteAllText(filename,"this is a text file ");


}

// TODO 3: AppendAllText adds text to an existing file
file.AppendAllText(filename,"this text gets appended to the files");

// TODO 4: A FileStream can be opened and written to until closed
write(StreamWriter sw = file.AppendText(filename)){
     sw.WriteLine("line 1");
     sw.WriteLine("line 2");
     sw.WriteLine("line 3");

}

// TODO 2: ReadAllText reads all the content from a file
string content ;
content = file.ReadAllText(filename);
console.WriteLine(content);
