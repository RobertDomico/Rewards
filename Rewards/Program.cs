using CrypticWizard.RandomWordGenerator;
using System.Diagnostics;

Random rnd = new();

string[] arguments = Environment.GetCommandLineArgs();

int numberOfRuns = 40;

if (arguments.Count() > 1)
    int.TryParse(arguments[1], out numberOfRuns);

Console.WriteLine(numberOfRuns);

int minTime = 200000;
int maxTime = 400000;

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
