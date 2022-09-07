using System;

namespace Loomad
{
    internal class Koer : koduloom
    {
        public enum toug { Alabai, Mops, Haski };
        public toug Toug;
        //Tõung - порода
        public Koer(toug Toug, string nimi, string varv, sugu loomaSugu, double kaal, int vanus) : base(nimi, varv, loomaSugu, kaal, vanus)
        {
            this.Toug = Toug;
        }
        public Koer(Koer koer)
        {
            this.nimi = koer.nimi;
            this.varv = koer.varv;
            this.loomaSugu = koer.loomaSugu;
            this.kaal = koer.kaal;
            this.vanus = koer.vanus;
            this.Toug = koer.Toug;
        }
        public override void print_Haal()
        {
            Console.WriteLine("Af");
        }
        public override void print_Info()
        {
            Console.WriteLine($"{Toug}, {varv}, {nimi} ta on {loomaSugu} ja tema kaal on {kaal} ja ta on {vanus} aastat vana");
        }
        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
        public void muudaVarv(string uusVarv) { varv = uusVarv; }
        public void muudaLoomaSugu(sugu uusLoomaSugu) { loomaSugu = uusLoomaSugu; }
        public void muudaKaal(double uusKaal) { kaal = uusKaal; }
        public void muudaVanus(int uusVanus) { vanus = uusVanus; }
        public void muudaToug1(toug uusToug) { Toug = uusToug; }
    }
}