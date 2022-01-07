using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13._1
{
   sealed class MultiBuilding : Building
    {
       int etazhnost;
        public int Etazhnost
        {
            set
            {
                if (value > 0)
                {
                    etazhnost = value;
                }
                else
                {
                    Console.WriteLine("Этажность здания не может быть отрицательной");
                }
            }
            get
            {
                return etazhnost;
            }
        }
        public MultiBuilding(string adres, int dlina, int shirina, int visota, int etazhnost)
            : base(adres, dlina, shirina, visota)
        {
            Etazhnost = etazhnost;
        }

        public string Print()
        {
            string roditel = base.Print();
            roditel += $"\n\tКоличество этажей здания составляет {etazhnost} шт";
            return roditel;
        }
    }
}
