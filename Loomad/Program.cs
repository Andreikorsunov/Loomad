using Loomad;
using System;
using System.IO;

Console.WriteLine("Hello, World!")
Koer koer = new Koer(Koer.toug.Mops, "Šurik", "punane", koduloom.sugu.mees, 35, 7, true);
koer.print_Info();
koer.print_Haal();
Koer veelkoer = new Koer(koer);
veelkoer.muudaNimi("Mopsjara");
veelkoer.muudaVarv("valge");
veelkoer.muudaLoomaSugu(koduloom.sugu.mees);
veelkoer.muudaKaal(7.2);
veelkoer.muudaVanus(3);
veelkoer.print_Info();
Karu karu = new Karu(Karu.toug.Pruunkaru, "Maksim", "black", koduloom.sugu.mees, 10, 4, true);
karu.print_Info();
karu.print_Haal();
Console.WriteLine(karu.print_Info());

using (StreamWriter writer = new StreamWriter("C:\\Users\\opilane\\source\\repos\\TARpv20Korsunov\\file.txt"))
{
    writer.WriteLine(karu.print_Info());
}
string readText = File.ReadAllText("C:\\Users\\opilane\\source\\repos\\TARpv20Korsunov\\file.txt");