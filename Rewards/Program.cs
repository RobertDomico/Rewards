using CrypticWizard.RandomWordGenerator;
using System.Diagnostics;

Random rnd = new();

for (int counter = 0; counter < 40; counter++)
{
    WordGenerator wg = new();

    string a = wg.GetWord(WordGenerator.PartOfSpeech.noun);
    string url = "https://www.bing.com/search?q=" + a + "&form=QBI";

    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
    if (counter % 3 == 0)
        Thread.Sleep(rnd.Next(960000, 960000));
    else
        Thread.Sleep(rnd.Next(7000, 10000));
}