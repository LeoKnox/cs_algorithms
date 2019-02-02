using System;
					
public class Program
{
	public static void Main()
	{
	
		for (int x = 1; x <= 100; x++) {
			if ((x%3==0)||(x%5==0)) {
				if(!((x%3==0)&&(x%5==0))) {
					Console.WriteLine(x);
				}
			}
		}			
	}
}