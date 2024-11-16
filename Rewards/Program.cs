using CrypticWizard.RandomWordGenerator;
using System.Diagnostics;

Random rnd = new();

for (int counter = 0; counter < 40; counter++)
{
    WordGenerator wg = new();

    string a = wg.GetWord(WordGenerator.PartOfSpeech.noun);
    string url = "https://www.bing.com/search?q=" + a + "&form=QBI";

    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
   
    Thread.Sleep(rnd.Next(9000, 15000));
}
