
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

/*
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
*/

/*
Console.WriteLine("A quien buscas?: ");
string busq=Console.ReadLine().ToLower();
for(int x = 0; x < edificio2.Length; x++)
{
    if (edificio2[x]==busq)
    {
        Console.WriteLine("Esta en el piso: " + (x + 1));
    }
}

*/


/*
int[] //unimensional
int[,] //bidimensional
*/

/*
int[] num= { 1, 2, 3, 4, 5 };

foreach (int x in num)
{
    Console.WriteLine(x+" ");

}
*/


/*
Random r = new Random();

int n;

Console.WriteLine("Ingrese n: ");
n=int.Parse(Console.ReadLine());
int[] nu = new int[n];
for (int i = 0; i < n; i++)
{
    nu[i] =r.Next(0,51);
    Console.WriteLine(i + " "+nu[i]);
}
*/

/*
int[] num = { 4, 8, 10, 25 };

Console.WriteLine("Lista 1: ");
foreach (int x in num) 
{
    Console.Write(x+" ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Lista 2: ");
num[2] = 36;
foreach (int x in num)
    Console.Write(x+" ");
*/


/*
    string[] nom = { "jose", "oscar", "carmen", "alexa" };
    Console.WriteLine("Ingresar nombre a buscar: ");
    string buscar = Console.ReadLine().ToLower();

    int indice = Array.IndexOf(nom, buscar);

if (indice != -1)   
{
    Console.WriteLine($"{buscar} esta en {indice}");
}
else
{
    Console.WriteLine("No hay compañere");
}
*/


/*
char[] nom = { 'a', 'e', 'i', 'o', 'u' };
Console.WriteLine("LISTA");
foreach (char s in nom)
{

    Console.WriteLine(s+" ");
}
Console.WriteLine("Que desea modificar: ");
char modifi=char.Parse(Console.ReadLine()); 
int indice=Array.IndexOf(nom, modifi);
if (indice != -1)
{
    Console.WriteLine("Ingrese su nuevo valor: ");
    char nuevo=char.Parse(Console.ReadLine());  
    Console.WriteLine("lISTA MODIFICADA: ");
    nom[indice] = nuevo;
    foreach (char s in nom)
    {
        Console.WriteLine(s);
    }
}
else
{
    Console.WriteLine("No se puede modificar");
}

*/



int[] num=new int[0];
int posi = 0;
char op;
int dato;
do
{
    Console.WriteLine("Ingrese valor: ");
    while (!int.TryParse(Console.ReadLine(), out dato))
    {
        Console.WriteLine("ERROR!. Ingrese valor: ");
    }
    Array.Resize(ref num, num.Length + 1);
    num[posi] = dato;
    posi++;

    do
    {
        Console.WriteLine("Desea ingresar mas datos? (s/n): ");
        op = char.ToLower(Console.ReadKey().KeyChar);
    } while (op != 's' & op != 'n');
    Console.WriteLine();
}while (op=='s');
