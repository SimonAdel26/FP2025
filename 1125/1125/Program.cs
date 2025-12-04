// RECURSIVITATE

#region Factorial





using System.Numerics;

int n = 6;
Console.WriteLine($"{n}! = {Factorial(n)}");
Console.WriteLine($"{n}! = {FactorialR(n)}");




// n! = 1 daca n == 0 sau n * (n-1)! daca n > 0
int FactorialR(int n)
{
	if (n == 0)
		return 1;
	else
		return n * FactorialR(n - 1);
}

// n! = 1*2*...*n
int Factorial(int n)
{
    int r = 1;
	for (int i = 1; i <= n; i++)
		r *= i;
	return r;
}
#endregion

#region CMMDC
int a = 105, b = 75; // 75=3*5^2, 105 = 3*5*7
Console.WriteLine($"gcd({a}, {b}) = {gcd(a, b)}");
Console.WriteLine($"gcd({a}, {b}) = {gcd2(a, b)}");
Console.WriteLine($"gcd({a}, {b}) = {gcdR(a, b)}");
Console.WriteLine($"lcm({a}, {b}) = {lcm(a, b)}");

int lcm(int a, int b)
{
    return a * b / gcd(a, b);
}

// gcd(a, b) = a daca b == 0 sau gcd(b, a % b) daca b != 0
int gcdR(int a, int b)
{
	if (b == 0)
		return a;
	else
		return gcdR(b, a % b);
}

// (105, 75) ==> (75, 30) ==> (30, 15) ==> (15, 0)
int gcd(int a, int b)
{
    while(b != 0)
	{
		int r = a % b;
		a = b;
		b = r;
	}
	return a;
}

int gcd2(int a, int b)
{
	while(a != b)
	{
		if (a > b)
			a -= b;
		else
			b -= a;
	}
	return a;
}
#endregion

#region Scor
// 3-3
int s1 = 100, s2 = 100;
//Console.WriteLine($"scor({s1},{s2}) = {scor(s1, s2)}");

Dictionary<(int, int), BigInteger> memo = new();
for(int s = 1; s <= 100; s++)
	Console.WriteLine($"scor2({s},{s}) = {scor2(s, s)}");

BigInteger scor2(int s1, int s2)
{
	if (memo.ContainsKey((s1, s2)))
		return memo[(s1, s2)];

	if(s1 == 0 || s2 == 0)
	{
		memo[(s1, s2)] = 1;
		return 1;
	}
	else
	{
		memo[(s1, s2)] = scor2(s1 - 1, s2) + scor2(s1, s2 - 1);
		return memo[(s1, s2)];
	}
}

long scor(int s1, int s2)
{
	if (s1 == 0 || s2 == 0)
		return 1;
	else
		return scor(s1 - 1, s2) + scor(s1, s2 - 1);
}
#endregion

#region Steps
// 3 = 111, 12, 21
// 5 = 11111, 1112, 1211, 2111, 1121, 221, 212, 122
// n = ?? 
n = 10;
Console.WriteLine($"{n} steps ==> {steps(n)}");


// TODO: memoization
int steps(int n)
{
    if(n == 1)
		return 1;
	if(n == 2)
		return 2;
	if(n == 3) 
		return 3;
	return steps(n - 1) + steps(n - 2);
}
#endregion

#region Combinatorics
n = 4;
// Generez toate secventele binare de lungime n;
int[] v = new int[n];

gen(v, n, 0);

genPermutation(v, n, 0);

void genPermutation(int[] v, int n, int k)
{
    if (k == n)
        printArray(v);
	else
	{
		for(int i = 1; i <= n; i++)
		{
			v[k] = i;
			bool found = false;
			for(int j = 0; !found && j < k; j++)
				if (v[j] == v[k])
					found = true;
			if (!found)
				genPermutation(v, n, k + 1);
		}
	}
}

// Generez toate secventele binare de lungime n
void gen(int[] v, int n, int k)
{
	if (k == n)
		printArray(v);
	else
	{
		v[k] = 0;
		gen(v, n, k + 1);

        v[k] = 1;
        gen(v, n, k + 1);
    }
}

void printArray(int[] v)
{
    foreach (var item in v)
        Console.Write(item);
    Console.WriteLine();
}
#endregion
