//Nombre: Juan Manuel Valiño
//e-Mail: jmvdm09@gmail.com
//C.I.: 55473608
using System;
using System.Linq;

namespace cedula
{
    public class Person
    {
        public Person (string nombre, string ci)
        {
            this.Nombre = nombre;
            this.CI = ci;
        }
        public string Nombre {get;set;}
        string id;
        public string CI {
            get{return this.id;}
            set{
                if (validarCI(value))
                {
                    this.id=value;
                }
                else
                {
                    this.id="";
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Me llamo {this.Nombre} y mi ci es {this.CI}");
        }

        public static bool validarCI(string ci)
        {


            long verificadorFormato;

            //Validar largo
            if (ci.Length == 8 && long.TryParse(ci, out verificadorFormato))
            {
                var vectorStrCI = ci.ToCharArray();
                var vectorCI = vectorStrCI.Select(c => int.Parse(c.ToString())).ToArray();
                var vectorReferencia = "2987634".ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();

                var verificadorIngresado = vectorCI[7];

                //Calcular número verificador
                int numeroVerificadorRaw = 0;

                for (int i = 0; i < vectorReferencia.Length; i++)
                {
                    numeroVerificadorRaw = numeroVerificadorRaw + (vectorCI[i] * vectorReferencia[i]);
                }

                int verificadorCalculado = 10 - (numeroVerificadorRaw % 10);

                if(verificadorCalculado != verificadorIngresado)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "11111111");
            Person jane = new Person("Jane Doe", "55473608");
            john.IntroduceYourself();
            jane.IntroduceYourself();

        }
    }
}