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
int p = 6;
p += 3; //Equivalent to: p = p + 3;
p -= 3; // Equivalent to: p = p - 3;
p *= 3; // Equivalent to: p = p * 3;
p /= 3; // Equivalent to: p = p / 3;

