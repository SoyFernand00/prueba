
/*Random a = new Random();
int nu=a.Next(1,21)
*/
/*
string[] edificio1 = new string[5];
for (int x=0; x<edificio1.Length; x++)
{
    Console.WriteLine($"Ingrese nombre:{x+1}");
    edificio1[x]=Console.ReadLine();
}

Console.WriteLine();
for (int x = 0; x < edificio1.Length; x++)
{
    Console.WriteLine(edificio1[x]);
}

Console.WriteLine();


string[] edificio2 = { "tu", "papas", "hermano", "tio", "primo" };

foreach (string e in edificio2)
{
    Console.WriteLine(e);
}
*/

Console.WriteLine("Ingrese cantidad de elementos: ");
int n=int.Parse(Console.ReadLine());

int[] numero=new int[n];
Random rand=new Random();

for (int x = 0; x < n; x++)
{
    numero[x] = rand.Next(10, 100);
}

string todos=string.Join(",", numero);
Console.WriteLine("Numeros: "+todos);
