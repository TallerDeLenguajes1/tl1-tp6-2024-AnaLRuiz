// See https://aka.ms/new-console-template for more information
/**Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);**/

//ej1
Console.WriteLine("INGRESE UN NUMERO:");
string s = Console.ReadLine();
int n = 0;
bool resultado = int.TryParse(s, out n);
int m=0;

if (n>0)
{
    while (n>0)
    {
        int resto=n%10;
        n=n/10;
        m=m*10+resto;
    }
}
Console.WriteLine(m);

//CALCULADORA V1