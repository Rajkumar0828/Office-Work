using Microsoft.Build.Framework;
using MSBuildTask = Microsoft.Build.Utilities.Task; // Alias for clarity

namespace SampleTask
{
    public class MyCompileTask : Task

    public static void Main(string[] args)
    {
        {
            [Required]
            public ITaskItem[] InputFiles { get; set; }

            [Output]
            public ITaskItem[] OutputFiles { get; set; }


    public override bool Execute()
    {
        var generatedFileNames = new List<string>();

        foreach (var inputFile in this.InputFiles)
        {
            var inputFileName = inputFile.ItemSpec;
            var outputFileName = Path.ChangeExtension(inputFileName, ".res.txt");

            var source = File.ReadAllText(inputFileName);
            var compiled = source.ToUpper();
            File.WriteAllText(outputFileName, compiled + "\n\n" + DateTime.Now);

            generatedFileNames.Add(outputFileName);
        }

        this.OutputFiles = generatedFileNames.Select(name => new TaskItem(name)).ToArray();

        return true;
    }
}

 }

 }