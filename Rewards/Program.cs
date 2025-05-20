using CrypticWizard.RandomWordGenerator;
using System.Configuration;
using System.Diagnostics;

Random rnd = new();

string? numberOfRunsConfig = ConfigurationManager.AppSettings["numberOfRuns"];
if (!int.TryParse(numberOfRunsConfig, out int numberOfRuns))
{
    numberOfRuns = 40;
}

string? minTimeConfig = ConfigurationManager.AppSettings["minTime"];
if (!int.TryParse(minTimeConfig, out int minTime))
{
    minTime = 200000;
}

string? maxTimeConfig = ConfigurationManager.AppSettings["maxTime"];
if (!int.TryParse(maxTimeConfig, out int maxTime))
{
    maxTime = 200000;
}

Console.WriteLine(numberOfRuns);

for (int counter = 0; counter < numberOfRuns; counter++)
{
    WordGenerator wg = new();

    string a = wg.GetWord(WordGenerator.PartOfSpeech.noun);
    string url = "https://www.bing.com/search?q=" + a + "&form=QBI";

    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
   
    Thread.Sleep(rnd.Next(minTime, maxTime));

    Console.WriteLine(counter+1);
}

Environment.Exit(0);
