int a = 15;
string b = "Mathias";
double c = 100.3;

Console.WriteLine(a);
Console.WriteLine(b);

if (a > 10)
{
    Console.WriteLine("Større");
}
else
{
    Console.WriteLine("Mindre eller ligmed");
}



void Skriv(int antal, string tegn)
{
    for (int i = 0; i < antal; i++)
    {
        System.Console.WriteLine(i + " " + tegn);
    }
}

int LægSammen1(int a, int b)
{
    return a + b;
}

//Func<int, int, int> LægSammen2 = (int a, int b) => { return a + b; };
Func<int, int, int> LægSammen2 = (a, b) => a + b;




Skriv(5, "%");
int resultat = LægSammen1(10, 5);
System.Console.WriteLine(resultat);
int resultat2 = LægSammen2(15, 125);
System.Console.WriteLine(resultat2);

DateTime f = DateTime.Now;
System.Console.WriteLine(f);

DateTime g = f.AddDays(45);
System.Console.WriteLine(g);

Kunde kunde1 = new Kunde() { Alder = 10, Navn = "a", ErILive = true };
System.Console.WriteLine(kunde1.Navn);

string json = System.Text.Json.JsonSerializer.Serialize(kunde1);
System.Console.WriteLine(json);

Terning t = new Terning();
System.Console.WriteLine(t.Værdi);
t.Ryst();
System.Console.WriteLine(t.Værdi);


int[] arr = new int[] { 5, 1, 56, 10, 2, 9 };
System.Console.WriteLine(arr[2]);
string[,] bræt = new string[8, 8];


List<int> lst = new List<int>() { 5, 17, 2, 4, 3 };
lst.Add(5);
lst.RemoveAt(0);
foreach (var item in lst)
{
    System.Console.WriteLine(item);
}

List<Terning> Bæger = new List<Terning>();
Bæger.Add(new Terning());
Bæger.Add(new Terning());
foreach (var item in Bæger)
{
    item.Skriv();
}

// LINQ 5, 17, 2, 4, 3

List<int> res = lst.Where(i => i < 10).OrderBy(i => i).ToList();
foreach (var item in res)
{
    System.Console.WriteLine(item);
}



try
{
    int h = 10;
    int i = 0;
    int j = h / i;

}
catch (System.Exception ex)
{
    // log... NuGet
    System.Console.WriteLine("Der er sket en fejl");
    System.Console.WriteLine(ex.Message);

}







class Kunde
{
    public int Alder { get; set; }
    public string Navn { get; set; }
    public bool ErILive { get; set; }

}

class Terning
{

    public int Værdi { get; set; }

    public void Ryst()
    {
        this.Værdi = new Random().Next(1, 7);
    }

    public Terning()
    {
        Ryst();
    }

    public void Skriv()
    {
        System.Console.WriteLine("[ " + this.Værdi + " ]");
    }

}
