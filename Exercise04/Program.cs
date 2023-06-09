Console.WriteLine("string 1 :");
var string1 = Console.ReadLine();

Console.WriteLine("string 2 :");
var string2 = Console.ReadLine();

if (string1.Equals(string2))
{
	Console.WriteLine("Check the same character pattern: True");
}
if (string1.Length == string2.Length)
{
	for (int i = 0; i < string1.Length; i++)
	{
		if (string1.IndexOf(string1.Substring(i, 1), (i - 1) + 1) == string2.IndexOf(string2.Substring(i, 1), (i - 1) + 1))
		{
			if (string1.IndexOf(string1.Substring(i, 1), i + 1) == string2.IndexOf(string2.Substring(i, 1), i + 1))
			{
				if (string1.IndexOf(string1.Substring(i, 1), i + 1) == -1 || string1.IndexOf(string1.Substring(i, 1), (i - 1) + 1) == -1)
				{
					Console.WriteLine("Check the same character pattern: False");
					break;
				}
				i++;
				if (i == string1.Length - 1)
				{
					Console.WriteLine("Check the same character pattern: True");
				}
			}
			else
			{
				Console.WriteLine("Check the same character pattern: False");
				break;
			}
		}
	}
}
else
{
	Console.WriteLine("Check the same character pattern: False");
}
Console.ReadKey();

//Example
//Original strings: AACC, ZZQQ
//Check the same character pattern: True

//Original strings: PABA, ADAD
//Check the same character pattern: False
