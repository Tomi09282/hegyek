namespace MoHegyei
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beolvas();
            Atlag();
            LegmagasabbHegy();
            Borzsony();
            Magasabb();
        }


        static List<hegycsucs> csucsok = new List<hegycsucs>();
        static List<double> magasok = new List<double>();
        static void Beolvas()
        {
            StreamReader read = new StreamReader("hegyek.txt");
            read.ReadLine();
            while (!read.EndOfStream)
            {
                string[] adat = read.ReadLine().Split(';');
                csucsok.Add(new hegycsucs(adat[0], adat[1], int.Parse(adat[2])));
            }
            read.Close();
            Console.WriteLine($"Hegycsúcsok száma: {csucsok.Count} db");
        }

        static void Atlag()
        {
            double avg = 0;
            double sum = 0;
            foreach (var i in csucsok)
            {
                sum = sum + i.Magassag;
            }
            avg = sum / csucsok.Count;
            Console.WriteLine($"átlag: {avg}");
        }


        static void LegmagasabbHegy()
        {
            string neve = "";
            string hegyseg = "";
            int magassag = 0;
            int max = 0;
            foreach (var i in csucsok)
            {
                if (max < i.Magassag)
                {
                    max = i.Magassag;
                    neve = i.Hegycsúcs;
                    hegyseg = i.Hegyseg;
                    magassag = i.Magassag;
                }
            }
            Console.WriteLine($"A legmagasabb hegycsúcs:");
            Console.WriteLine($"neve: {neve}" + $"\nhegyseg: {hegyseg}" + $"\n magassag: {magassag} m");
        }


        static void Borzsony()
        {
            Console.Write("magassag: ");
            int rl = int.Parse(Console.ReadLine());
            int eredmeny = 0;
            foreach (var i in csucsok)
            {
                if (i.Hegyseg.Contains("Börzsöny"))
                {
                    if (rl < i.Magassag)
                    {
                        eredmeny = i.Magassag;
                        Console.WriteLine($"Van magasabb hegycsúcs a Börzsönyben {rl}-nél, {eredmeny}.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{rl}m-nél nincs magasabb hegycsucs.");
                        break;
                    }
                }
            }
        }


        static void Magasabb()
        {

            double szam = 3.280839895;
            int count = 0;
            foreach (var i in csucsok)
            {
                magasok.Add(i.Magassag * szam);
            }
            foreach (var i in magasok)
            {
                if (i > 3000)
                {
                    count++;
                }
            }
            Console.WriteLine($"3000 nél magasabb hegyek száma: {count}");

        }



    }
}
