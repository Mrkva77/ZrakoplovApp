using System;

public class Zrakoplov
{
    private string naziv;
        private double snagaMotora;
            private int dosegLeta;

    public Zrakoplov(string naziv, double snagaMotora, int dosegLeta)
    {
        this.naziv = naziv;
            this.snagaMotora = snagaMotora;
                this.dosegLeta = dosegLeta;
    }

    public override string ToString()
    {
        return $"Naziv: {naziv}, Snaga motora: {snagaMotora} kW, Doseg leta: {dosegLeta} km";
    }
}

class Program
{
    static void Main()
    {
        Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);
            Zrakoplov c162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
                Zrakoplov pc21 = new Zrakoplov("Pilatus", 1200, 1333);

                Console.WriteLine(x380);
                    Console.WriteLine(c162);
                        Console.WriteLine(pc21);
    }
}
