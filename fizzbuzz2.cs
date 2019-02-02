using System;
					
public class Program
{
	public static void Main()
	{
		int x = 1;
		while (x<101) {
			if(((x%3==0)&&(x%5==0))) {
				Console.WriteLine("fizzbuzz");
			}
			else if (x%5==0) {
				Console.WriteLine("fizz");
			}
			else if (x%3==0) {
				Console.WriteLine("buzz");
			}
			else {
				Console.WriteLine(x);
			}
			x++;
		}			
	}
}