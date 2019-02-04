using System;
using System.Collections.Generic;
					
public class Program
{
	public static void MinMaxSum()
	{
		int[] numbers = new int[10];
		Random rand = new Random();
		for (int i = 0; i<10; i++) {
			numbers[i]=rand.Next(5,26);
		}
		int avg = numbers[0];
		int min = numbers[0];
		int max = numbers[0];
		for(int i=1; i<numbers.Length;i++) {
			avg += numbers[i];
			if (min < numbers[i]) {
				min = numbers[i];
			} else if (max > numbers[i]) {
				max = numbers[i];
			}
		}
		Console.WriteLine("minimum = " + min);
		Console.WriteLine("maximum = " + max);
		Console.WriteLine("sum = " + avg);
	}
	public static string TossCoin()
	{
		Console.WriteLine("Tossing a Coin ... ");
		Random rand = new Random();
		int x = rand.Next(0,2);
		if (x == 0) {
			Console.WriteLine("Heads");
			return("Heads");
		} else if (x == 1) {
			Console.WriteLine("Tails");
			return("Tails");
		} else {
			Console.WriteLine("Landed on edge");
			return("Doesn't ever land on edge");
		}
	}
	public static object[] NumToString(int[] numbers)
	{
		object[] newobj = new object[numbers.Length];
		for (int i = 0; i < numbers.Length; i++) {
			if (numbers[i] < 0) {
				newobj[i] = "dojo";
			} else {
				newobj[i] = numbers[i];
			}
			Console.WriteLine(newobj[i]);
		}
		return(newobj);
	}
	public static double TossMultipleCoins(int y) {
		double sum = 0;
		Random rand = new Random();
		int x = rand.Next(0,2);
		if (x == 0) {
			Console.WriteLine("Heads");
			sum++;
		} else if (x == 1) {
			Console.WriteLine("Tails");
		}
		for (int i=0; i<=y; i++) {
			if (TossCoin()=="Heads") {
				sum++;
			}
		}
		return (sum/y);
	}
	public static string[] ListNames(
	public static void Main()
	{
		MinMaxSum();
		TossCoin();
		Console.WriteLine(TossMultipleCoins(5));
	}