byte b = 10;
short s = 100;
int i = 1000;
long l = 100000L;
float f = 1.23F;
double d = 12.3456;
decimal dec = 123.4567M;
char c = 'A';
bool flag = true;

string strFromInt = 42.ToString();
double dblFromStr = Convert.ToDouble("3.14");


Console.WriteLine("byte: " + b);
Console.WriteLine("short: " + s);
Console.WriteLine("int: " + i);
Console.WriteLine("long: " + l);
Console.WriteLine("float: " + f);
Console.WriteLine("double: " + d);
Console.WriteLine("decimal: " + dec);
Console.WriteLine("char: " + c);
Console.WriteLine("bool: " + flag);
Console.WriteLine("Converted int to string: " + strFromInt);
Console.WriteLine("Converted string to double: " + dblFromStr);
