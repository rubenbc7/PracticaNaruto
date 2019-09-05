using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AldeaNarutoPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aldea> aldeas = new List<Aldea>();

            Aldea konoha = new Aldea();
            konoha.Nombre = "Konohagakure no sato";
            konoha.Kage = "Naruto Uzumaki";
            konoha.Habitantes = 198567;
            aldeas.Add(konoha);

            Aldea sunaga = new Aldea();
            sunaga.Nombre = "sunagakure no sato";
            sunaga.Kage = "Gaara ";
            sunaga.Habitantes = 128921;
            aldeas.Add(sunaga);

            Aldea kumoga = new Aldea();
            kumoga.Nombre = "kumogakure no sato";
            kumoga.Kage = "Darui";
            kumoga.Habitantes = 150783;
            aldeas.Add(kumoga);

            Shinobi Kakashi = new Shinobi("Kakashi Hatake", "Hokage");
            Shinobi Shikamaru = new Shinobi("Shikamaru Nara", "Asistente de Hokage");
            Shinobi Choji= new Shinobi("Choji Akimichi", "Jonin");
            Shinobi Boruto= new Shinobi("Boruto Uzumaki", "Genin");
            Shinobi Ino = new Shinobi("Ino Yamanaka", "Jonin");

            Shinobi Gaara = new Shinobi("Gaara", "Hokage");
            Shinobi Kankuro = new Shinobi("Kankuro", "Jonin");
            Shinobi Temari = new Shinobi("Temari", "Jonin");

            Shinobi A = new Shinobi("A", "Hokage");
            Shinobi Bee = new Shinobi("Bee", "Jonin");
            Shinobi Darui = new Shinobi("Darui", "Hokage");

            konoha.Lista.Add(Kakashi);
            konoha.Lista.Add(Shikamaru);
            konoha.Lista.Add(Choji);
            konoha.Lista.Add(Boruto);
            konoha.Lista.Add(Ino);

            kumoga.Lista.Add(A);
            kumoga.Lista.Add(Bee);
            kumoga.Lista.Add(Darui);

            sunaga.Lista.Add(Gaara);
            sunaga.Lista.Add(Kankuro);
            sunaga.Lista.Add(Temari);


            foreach (Aldea aldea in aldeas)
            {
                Console.WriteLine("Nombre: " + aldea.Nombre);
                Console.WriteLine("Kage: " + aldea.Kage);
                Console.WriteLine("Habitantes: " + aldea.Habitantes);
                Console.WriteLine(" ");
                Console.WriteLine("Shinobis en misión: ");
                foreach (Shinobi shinobi in aldea.Lista)
                {
                    Console.WriteLine("° " + shinobi.Nombre + "   " +"-" + shinobi.Rango);
                }
                Console.WriteLine(" ");
            }


            try
            {
                konoha.Ingresos = 21131000;
                Console.WriteLine("Ingresos de konoha: $" + konoha.Ingresos);
            }

            catch (Exception se)
            {
                Console.WriteLine("Tu aldea es demasiado pobre");
            }
            try
            {
                kumoga.Ingresos = 21131000;
                Console.WriteLine("Ingresos de kumoga: $" + kumoga.Ingresos);
            }

            catch (Exception se)
            {
                Console.WriteLine("Tu aldea es demasiado pobre");
            }
            try
            {
                sunaga.Ingresos = 21131000;
                Console.WriteLine("Ingresos de sunoga: $" + sunaga.Ingresos);
            }

            catch (Exception se)
            {
                Console.WriteLine("Tu aldea es demasiado pobre");
            }
            Console.ReadLine();




        }
    }
}
