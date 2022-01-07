using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13._1
{
    class Building
    {
        string adres;
        int dlina;
        public int Dlina
        {
            set
            {
                if (value > 0)
                {
                    dlina = value;
                }
                else
                {
                    Console.WriteLine("Длина здания не может быть отрицательной");
                }
            }
            get
            {
                return dlina;
            }
        }
        int shirina;
        public int Shirina
        {
            set
            {
                if (value > 0)
                {
                    shirina = value;
                }
                else
                {
                    Console.WriteLine("Ширина здания не может быть отрицательной");
                }
            }
            get
            {
                return shirina;
            }
        }
        int visota;
        public int Visota
        {
            set
            {
                if (value > 0)
                {
                    visota = value;
                }
                else
                {
                    Console.WriteLine("Высота здания не может быть отрицательной");
                }
            }
            get
            {
                return visota;
            }
        }

        public Building(string adres, int dlina, int shirina, int visota)
        {
            this.adres = adres;
            Dlina = dlina;
            Shirina = shirina;
            Visota = visota;
        }
        public string Print()
        {
            return $"\nАдрес здания: {adres}.\n\tДлина здания: {dlina} метров.\n\tШирина: {shirina} метров.\n\tВысота: {visota} метров";
        }
    }
}
