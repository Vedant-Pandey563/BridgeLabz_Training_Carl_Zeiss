using System;

public class Class3
{
	public int Get4digitRandomNumber ()
	{
		Random random = new Random();
		return random.Next(1000, 10000);
    }

	public int CountDigits(int number)
	{
		int count = 0;
		while (number != 0)
		{
			number /= 10;
			count++;
		}
		return count;
    }

	public int GetDigits(int number, int count)
	{
		int digits = new int[count];
		for (int i = count - 1; i >= 0; i--)
		{
			digits[i] = number % 10;
			number /= 10;
		}

		return digits;
	}

	public int SumArray(int[] array)
	{
		int sum = 0;
		foreach (int digit in array)
		{
			sum += digit;
		}
		return sum;
    }

	static void Main(string[] args)
	{
		SumOfDigits sumOfDigits = new SumOfDigits();

		int number = sumOfDigits.Get4digitRandomNumber();
		console.WriteLine("Random Generated Number: " + number);

		int count = sumOfDigits.CountDigits(number);
		console.WriteLine("Count of Digits: " + count);

		int[] digits = sumOfDigits.GetDigits(number, count);

		int sum = sumOfDigits.SumArray(digits);

		console.WriteLine("Sum of Digits: " + sum);
    }
}
