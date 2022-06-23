global using projekt_kveten;
using projekt_kveten.Tridy;
start:
Tovarna tovarna = new Tovarna();
string adresaSouboru = "index.html";

int vyber = Convert.ToInt32(Console.ReadLine());
if (vyber == 1)
{
    tovarna.ZobrazStranku(adresaSouboru);
}

else if (vyber == 2)
{
    tovarna.VytvorStranku(tovarna.VytvorAuto());

    string zobrazitAuto = Console.ReadLine();
    if (zobrazitAuto == "y" | zobrazitAuto == "Y")
    {
        tovarna.ZobrazStranku(adresaSouboru);
    }
    else
    {
        Console.WriteLine("Můžeš si ho zobrazit příště");
    }
}
else
{
    Console.WriteLine("Špatné číslo");
}

Console.WriteLine("Chcete sputit program znovu? y/n");
string repetace = Console.ReadLine();
if (repetace == "y" | repetace == "Y")
{
    Console.Clear();
    goto start;
}
