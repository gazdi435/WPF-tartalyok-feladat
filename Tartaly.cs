using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Tartaly
    {
        //1
        private string nev;
        private int a;
        private int b;
        private int c;
        private double aktLiter;

        //2
        public Tartaly(string nev, int a, int b, int c)
        {
            this.nev = nev;
            this.a = a;
            this.b = b;
            this.c = c;
            this.aktLiter = 0;
        }

        public Tartaly(String nev)
        {
            //3
            this.nev = nev;
            this.a = 10;
            this.b = 10;
            this.c = 10;
            this.aktLiter = 0;
        }


        public double Terfogat
        {
            //4
            get { return this.a * this.b * this.c; }
        }

        //5
        public void DuplazMeretet()
        {
            this.a *= 2;
        }

        public void TeljesLeengedes()
        {
            this.aktLiter = 0;
        }

        //6

        public double Toltottseg
        {
            get => (this.aktLiter * 1000 / Terfogat) * 100;
        }
        public string Nev { get => nev; }
        public int aEl { get => a; }
        public int bEl { get => b; }
        public int cEl { get => c; }
        public double AktLiter { get => aktLiter; }

        //7
        public void Tolt(double mennyit)
        {

            if (this.aktLiter + mennyit > Terfogat / 1000)
            {
                throw new OverflowException("Nem fér ennyi a tartályba!");
            }
            this.aktLiter += mennyit;
        }




        //8
        public string Info()
        {
            return $"{this.Nev}: {this.Terfogat:n1} cm3 = ({this.Terfogat / 1000:n2} liter)," +
                $" töltöttsége: {this.Toltottseg:n2}%, ({this.aktLiter:n2} liter)," +
                $" méretei: {this.a}x{this.b}x{this.c} cm";


        }
    }
}
