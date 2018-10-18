using System;

class FiboNacho
{
	static int fibRec(int n)
	{
		if (n <= 1)
		{
			return n;
		}

		return fibRec(n-1) + fibRec(n-2);
	}

	static int fibFor(int n)
	{
		int prev = 1;
		int next = 1;
		int total = 1;

		for (int i = 2; i < n; i++)
		{
			total = next + prev;
			prev = next;
			next = total;
		}

		return total;
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(fibRec(10));
		Console.WriteLine(fibFor(5));
	}
}