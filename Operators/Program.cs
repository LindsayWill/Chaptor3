#region Exploring unary operators

int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");

#endregion

#region Exploring unary operators

int c = 3;
int d = ++c;
WriteLine($"c is {c}, d is {d}");

#endregion

//Exploring Binary aritmetic operators.
/*
 * Declaring and Assigning 2 integaer variables named e and f 
 * and applying the five common binary arithmetic operators to two numbers.
 * */

int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

/*Declaring and assigning value to double variable name g
 * to show difference between whole number and real number divisions.*/

double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");

//Returns floating-point due to floating point operator g.

//Assingment operator
//int p = 6;
//p += 3; //Equivalent to: p = p + 3;
//p -= 3; // Equivalent to: p = p - 3;
//p *= 3; // Equivalent to: p = p * 3;
//p /= 3; // Equivalent to: p = p / 3;

//Boolean statements p and q
//with values of true or false with truth tables output with AND OR and XOR logical operators.
bool p = true;
bool q = false;
WriteLine($"AND   | p    | q    ");
WriteLine($"p     | {p & p,-5} | {p & q,-5} ");
WriteLine($"q     | {q & p,-5} | {q & q,-5} ");
WriteLine();
WriteLine($"OR   | p    | q    ");
WriteLine($"p     | {p | p,-5} | {p | q,-5} ");
WriteLine($"q     | {q | p,-5} | {q | q,-5} ");
WriteLine();
WriteLine($"XOR   | p    | q    ");
WriteLine($"p     | {p ^ p,-5} | {p ^ q,-5} ");
WriteLine($"q     | {q ^ p,-5} | {q ^ q,-5} ");

//Declare a function that writes message to console and returns true.

static bool DoStuff()
{
    WriteLine("I am doing some stuff");
    return true;
}
WriteLine();
// Note that DoStuff() returns true.
WriteLine($"p & DoStuff() = {p & DoStuff()}");
WriteLine($"q & DoStuff() = {q & DoStuff()}");

WriteLine();
// Note that DoStuff() returns true.
WriteLine($"p && DoStuff() = {p && DoStuff()}");
WriteLine($"q && DoStuff() = {q && DoStuff()}");

//Declare 2 integer variables named x and y with vlaues 10 and 6.
//Output results applying AND, OR, and XOR bitwise operators.

WriteLine();

int x = 10;
int y = 6;

WriteLine($"Expression | Decimal |  Binary");
WriteLine($"------------------------------");
WriteLine($"x        | {x,7} | {x:B8}");
WriteLine($"x        | {y,7} | {y:B8}");
WriteLine($"x & y    | {x & y,7} | {x & y:B8}");
WriteLine($"x | y    | {x | y,7} | {x | y:B8}");
WriteLine($"x ^ y    | {x ^ y,7} | {x ^ y:B8}");
