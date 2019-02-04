using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		List<object> items = new List<object>();
		items.Add(7);
		items.Add(28);
		items.Add(-1);
		items.Add(true);
		items.Add("chair");
		foreach (var i in items) {
			Console.WriteLine(i);
		}
		int total = 0;
		foreach (var t in items) {
			if (t is int) {
				total += (int)t;
			}
		}
		Console.WriteLine(total);
	}
}