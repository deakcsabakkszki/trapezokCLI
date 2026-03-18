using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trapezokCLI
{


    public class Trapez
    {

        public bool szerkesztheto() 
        {
            if (Math.Abs(a-c)<b+d && Math.Abs(b-d) <a+c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool derekszogu()
        {
            if (c == m || d == m)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool teglalap()
        {
            if(derekszogu() && c==d && a == b)
            {
                return true ;
            }
            return false;
        }
        public Trapez(string egysor)
        {
            string[] sor = egysor.Split(" ");
            a = int.Parse(sor[0]);
            b = int.Parse(sor[1]);
            c = int.Parse(sor[2]);
            d = int.Parse(sor[3]);
            m = int.Parse(sor[4]);
        }

        public int a { get; private set; }
        public int b { get; private set; }
        public int c { get; private set; }
        public int d { get; private set; }
        public int m { get; private set; }

        public Trapez(int a, int b, int c, int d, int m)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.m = m;
        }

        public override string? ToString()
        {
            return $"a: {a}, b: {b}c: {c} d: {d} m: {m}";
        }
    }
}
