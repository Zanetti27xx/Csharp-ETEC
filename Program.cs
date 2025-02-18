using System;

namespace Lampada3
{
    class Lampada
    {
        public int lampadaNro;
        public string comodo;
        public bool status;

        public void provarExistencia()
        {
            Console.WriteLine("Eu existo!!!");
        }

        static void Main(string[] args)
        {
            Lampada l1 = new Lampada();
            l1.provarExistencia();
            l1.lampadaNro = 1;
            l1.comodo = "Sala";
            l1.status = true;

            Lampada l2 = new Lampada();
            l2.provarExistencia();
            l2.lampadaNro = 2;
            l2.comodo = "Quarto";
            l2.status = false;
        }
    }
}