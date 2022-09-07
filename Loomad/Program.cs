using Loomad;
using System;
using System.Collections.Generic;
using System.IO;

Console.WriteLine("Hello, World!");
Koer koer = new Koer(Koer.toug.Mops, "Šarik", "punane", koduloom.sugu.mees, 35.5, 7);
koer.print_Info();
koer.print_Haal();
Koer veelkoer = new Koer(koer);
veelkoer.muudaNimi("Mops");
veelkoer.muudaVarv("valge");
veelkoer.muudaLoomaSugu(koduloom.sugu.mees);
veelkoer.muudaKaal(9.1);
veelkoer.muudaVanus(4);
veelkoer.print_Info();

Karu Maks = new Karu(Karu.toug.Pruunkaru, "Maks", "black", koduloom.sugu.naine, 7.9, 2);
Karu Lena = new Karu(Karu.toug.Grizzly, "Lena", "white", koduloom.sugu.mees, 13.1, 4);
Karu Aleksei = new Karu(Karu.toug.PrillidegaKaru, "Aleksei", "black", koduloom.sugu.mees, 11.2, 1);
Maks.print_Info();
Maks.print_Haal();
Console.WriteLine(Maks.print_Info());

List<koduloom> karuList = new List<koduloom>();
karuList.Add(Lena);
karuList.Add(Maks);
karuList.Add(Aleksei);

using (StreamWriter writer = new StreamWriter(@"..\..\..\file.txt"))
{
    foreach (koduloom x in karuList)
    {
        writer.WriteLine(x.nimi + "," + x.vanus + ",");
    }
}
Console.WriteLine("\n");
List<Karu> karud = new List<Karu>();
StreamReader sr = new StreamReader(@"..\..\..\file.txt");
string text;
while ((text = sr.ReadLine()) != null)
{
    string[] rida = text.Split(',');
    karud.Add(new Karu(rida[0], rida[1]));
}
sr.Close();
foreach (var item in karud)
{
    Console.WriteLine($"Nimi: {item.nimi}, Vanus: {item.vanus}");
}
Console.ReadLine();