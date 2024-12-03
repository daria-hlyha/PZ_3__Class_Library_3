using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_3
{
    public class Misto : IMisto
    {
        public string Nazva_Mista { get; set; }
        public double Shyrota { get; set; }
        public double Dovgota { get; set; }

        public Misto(string nazva_mista, double latitude, double dovgota)
        {
            Nazva_Mista = nazva_mista;
            Shyrota = latitude;
            Dovgota = dovgota;
        }
        public string Chasovyi_Poyas()
        {
            if (Dovgota <= -165) { return "GMT-12"; }
            else if (Dovgota <= -150) { return "GMT-11"; }
            else if (Dovgota <= -135) { return "GMT-10"; }
            else if (Dovgota <= -120) { return "GMT-9"; }
            else if (Dovgota <= -105) { return "GMT-8"; }
            else if (Dovgota <= -90) { return "GMT-7"; }
            else if (Dovgota <= -75) { return "GMT-6"; }
            else if (Dovgota <= -60) { return "GMT-5"; }
            else if (Dovgota <= -45) { return "GMT-4"; }
            else if (Dovgota <= -30) { return "GMT-3"; }
            else if (Dovgota <= -15) { return "GMT-2"; }
            else if (Dovgota < 0) { return "GMT-1"; }
            else if (Dovgota == 0) { return "GMT-0"; }
            else if (Dovgota <= 15) { return "GMT+1"; }
            else if (Dovgota <= 30) { return "GMT+2"; }
            else if (Dovgota <= 45) { return "GMT+3"; }
            else if (Dovgota <= 60) { return "GMT+4"; }
            else if (Dovgota <= 75) { return "GMT+5"; }
            else if (Dovgota <= 90) { return "GMT+6"; }
            else if (Dovgota <= 105) { return "GMT+7"; }
            else if (Dovgota <= 120) { return "GMT+8"; }
            else if (Dovgota <= 135) { return "GMT+9"; }
            else if (Dovgota <= 150) { return "GMT+10"; }
            else if (Dovgota <= 165) { return "GMT+11"; }
            else if (Dovgota <= 180) { return "GMT+12"; }
            else { return "Невідомий часовий пояс"; }
        }
        public string Pivkulya()
        {
            if (Shyrota > 0) { return "Пiвнiчна куля"; }
            else if (Shyrota == 0) { return "На екваторі широта = 0"; }
            else { return "Пiвденна куля"; }
        }
    }
}
