using System;

namespace Banco
{
    class Banco
    {
        string cpf;
        string nome;
        int limiteCredito;
        float saldo;
        bool negativado;
        float valorDep;
        float valorSac;

        public void depositar()
        {
            Console.WriteLine("Quanto deseja depositar?");
            float valorDep = float.Parse(Console.ReadLine());
            saldo = saldo + valorDep;
            Console.WriteLine("Valor Depositado!\n\n");
            confirmar();
        }
        public void sacar()
        {
            Console.WriteLine("Quanto deseja sacar?");
            float valorSac = float.Parse(Console.ReadLine());
            saldo = saldo - valorSac;
            Console.WriteLine("Valor Sacado!\n\n");
            confirmar();
        }

        public void consulta()
        {
            Console.WriteLine("nome: " + nome);
            Console.WriteLine("cpf: " + cpf);
            Console.WriteLine("limite de credito: " + limiteCredito);
            Console.WriteLine("saldo: " + saldo);
            if(negativado == false)
            {
                Console.WriteLine("negativado: Não\n\n");
            } else
            {
                Console.WriteLine("negativado: Sim\n\n");
            }
            confirmar();
        }

        public void confirmar()
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1: Consultar");
            Console.WriteLine("2: Depositar");
            Console.WriteLine("3: Sacar");
            string confirmar = Console.ReadLine();
            if (confirmar == "1")
            {
                consulta();
            }
            if (confirmar == "2")
            {
                depositar();
            }
            if (confirmar == "3")
            {
                sacar();
            }
        }
        static void Main(string[] args)
        {
            Banco p1 = new Banco();
            p1.cpf = "38838838892";
            p1.nome = "Matheus";
            p1.limiteCredito = 1200;
            p1.saldo = 500.00f;
            p1.negativado = false;
            p1.confirmar();
            }
        }
    }
