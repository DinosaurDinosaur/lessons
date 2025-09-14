// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int i = 33;
short sh = 0;
long lo = 0;
Console.WriteLine("gi =" + i);

Console.WriteLine("i = {0},{1}", i, "string55");

double d = 0;
double d1 = 0d;
float f = 0;
float f1 = 0f;
decimal dm1 = 0;
decimal dm2 = 0m;
bool b = false;

char c1 = 'A';
char c2 = 'a';

string s1 = "this is a string";
const string s2 = "this is another string";
Console.WriteLine(s1 + s2);

const int il = 10;

var d5 = 0d;
var f5 = 0f;
var dm5 = 5m;
var cc = 'B';
var s3 = "string";

var r1 = (d + f) * 4 / 2;
var r2 = 14 / 3;
var r3 = 14 % 3;
var r4 = 14d / 3;
var r5 = 14f / 3;
var r6 = s1 + s2;
Console.WriteLine("s1 + s2 ={0}", r6);

var r7 = s1 + d + f + i + c1 + b;
Console.WriteLine("r7={0}", r7);

var b1 = true;
var b2 = false;
var b3 = b1 && b2;
var b4 = b1 || b2;
Console.WriteLine("true&&false={0}", b3);
Console.WriteLine("true || false={0}", b4);

if (b1) Console.WriteLine("b1 is true");
if (!b2) Console.WriteLine("b1 is false");

if (b1 && b2)
{
    Console.WriteLine("b1 is true");
    Console.WriteLine("b2 is true");
}
else
{
    Console.WriteLine("b1 && b2 is false");
}

Console.WriteLine("boolean test");
if (b1)
{
    if (b2) Console.WriteLine("b1&&b2 is true");
    else Console.WriteLine("b1 is true, b2 is flase");
}
else Console.WriteLine("b1 is false");


//00:57