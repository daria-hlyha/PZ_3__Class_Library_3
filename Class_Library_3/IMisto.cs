using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_3
{
    public interface IMisto
    {
        string Nazva_Mista { get; set; }
        double Shyrota { get; set; }
        double Dovgota { get; set; }
        string Chasovyi_Poyas();
        string Pivkulya();

    }
}
