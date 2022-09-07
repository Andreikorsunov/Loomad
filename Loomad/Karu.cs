using System;

namespace Loomad
{
    internal class Karu : koduloom
    {
        public enum toug { Pruunkaru, Grizzly, PrillidegaKaru };
        public toug Toug;
        public Karu(toug Toug, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav) : base(nimi, varv, loomaSugu, kaal, vanus, elav)
        {
            this.Toug = Toug;
        }
        public Karu(Karu karu)
        {
            this.nimi = karu.nimi;
            this.varv = karu.varv;
            this.loomaSugu = karu.loomaSugu;
            this.kaal = karu.kaal;
            this.vanus = karu.vanus;
            this.elav = karu.elav;
            this.Toug = karu.Toug;
        }
        public override void print_Haal()
        {
            Console.WriteLine("RRRRRRRRR");
        }
        public override void print_Info()
        {
            Console.WriteLine($"{Toug}, {varv}, {nimi} ta on {loomaSugu} ja tema kaal on {kaal} ja ta on {vanus} aastat vana, on {elav}");
        }
        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
        public void muudaVarv(string uusVarv) { varv = uusVarv; }
        public void muudaLoomaSugu(sugu uusLoomaSugu) { loomaSugu = uusLoomaSugu; }
        public void muudaKaal(double uusKaal) { kaal = uusKaal; }
        public void muudaVanus(int uusVanus) { vanus = uusVanus; }
        public void muudaElav(bool uusElav) { elav = uusElav; }
        public void muudaToug(toug uusToug) { Toug = uusToug; }
    }
}