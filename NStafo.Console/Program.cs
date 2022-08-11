var nstafo = new NStafo.NStafo();

Console.WriteLine(await nstafo.NumForksAsync("github/docs"));
Console.WriteLine(await nstafo.NumStarsAsync("github/docs"));
