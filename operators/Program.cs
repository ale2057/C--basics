// See https://aka.ms/new-console-template for more information


double x=10, y=5;
string a = "abcd", b="efgh";


//Basic math operators are + - / *

Console.WriteLine("----Basic Math----");
//PEMDAS
/*
P=POTENCIA
E=EXPONENTE
M=MULT
D=DIV
A=SUMA
S=RESTA
*/
//
Console.WriteLine((x/y)*x);
Console.WriteLine(x/(y*x));
//Concatenar
Console.WriteLine(a+b);
Console.WriteLine("Concatenaci0n: "+a+b);

//Incrementar / decrementar

Console.WriteLine("------INC/DEC----");
x++;
y++;

Console.WriteLine(x);
Console.WriteLine(y);

//Increment shorthand
a += b;
x += y;

Console.WriteLine(a);
Console.WriteLine(b);

//Logical
//alt+124 ||
Console.WriteLine("-----Logic && ||");
Console.WriteLine(x>y && y>=5);
Console.WriteLine(x>y || y>=5);

//operadores null
string str = null;
str ??= "New string";
//Console.WriteLine(str ?? "Unkown String");
Console.WriteLine(str);
 string marca="Fiat";
 int modelo=2022;

 if(marca=="Fiat"&&modelo>=2022){
    Console.WriteLine("Comprate el auto");
 }
