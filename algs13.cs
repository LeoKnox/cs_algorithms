using System;
using System.Collections.Generic;
					
public class Program
{
	public static void print255()
	{
		for (int x = 1; x<256;x++) {
			Console.WriteLine(x);
		}
	}
	public static void print255odd()
	{
		for (int x = 1; x<256; x+=2) {
			Console.WriteLine(x);
		}
	}
	public static void printsum() {
		int total = 0;
		for (int x =0; x<256; x++) {
			total += x;
			Console.WriteLine("New number "+x+" totaled "+total);
		}
	}
	public static void Main()
	{
		print255();
		print255odd();
		printsum();
	}
    public static void LoopArray(int[] numbers)
	{
		for (int i = 0; i<numbers.Length; i++) {
			Console.WriteLine(numbers[i]);
		}
	}
	public static void FindMax(int[] numbers)
	{
		int max=numbers[0];
		for (int i = 1; i<numbers.Length; i++) {
			if (numbers[i]>max){
				max = numbers[i];
			}
		}
		Console.WriteLine(max);
	}
	public static void GetAverage(int[] numbers)
	{
		int avg=numbers[0];
		for (int i = 1; i<numbers.Length;i++) {
			avg += numbers[i];
		}
		Console.WriteLine(avg/numbers.Length);
	}
	public static int[] OddArray()
	{
		int[] newarr = new int[128];
		int pos = 0;
		for (int i = 1; i<256; i+=2) {
			newarr[pos] = i;
			pos++;
		}
		return newarr;
	}
    public static void GreaterThanY(int[] numbers, int y) {
		int total = 0;
		for (int i = 0; i < numbers.Length; i++) {
			if (numbers[i] > y) {
				total++;
			}
		}
		Console.WriteLine(total);
	}
	public static void SquareArrayValues(int[] numbers)
	{
		for (int i = 0; i < numbers.Length; i++) {
			numbers[i] *= numbers[i];
			Console.WriteLine(numbers[i]);
		}
	}
	public static void EliminateNegatives(int[] numbers)
	{
		for (int i = 0; i < numbers.Length; i++) {
			if (numbers[i] < 0) {
				numbers[i] = 0;
			}
			Console.WriteLine(numbers[i]);
		}
	}
    public static void MinMaxAverage(int[] numbers)
	{
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
		Console.WriteLine("average = " + avg/numbers.Length);
	}
	public static void ShiftValues(int[] numbers)
	{
		for (int i=0; i< numbers.Length-1; i++) {
			numbers[i] = numbers[i+1];
			Console.WriteLine(numbers[i]);
		}
		numbers[numbers.Length-1]=0;
		Console.WriteLine(numbers[numbers.Length-1]);
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
}