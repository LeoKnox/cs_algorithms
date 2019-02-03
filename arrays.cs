using System;
					
public class Program
{
	public static void Main()
	{
		int[] nums = {0,1,2,3,4,5,6,7,8,9};	

        string[] names = {"Tim","Martin","Nikki","Sara"};

        bool[] boos = new bool[10];
		for (int x = 0; x<10;x+=2){
			boos[x] = true;
		}
		for (int y = 1; y<10;y+=2){
			boos[y] = false;
		}
		for (int z = 0; z<10;z++){
			Console.WriteLine(boos[z]);
		}

        List<string> icecream = new List<string>();
		icecream.Add("chocolate");
		icecream.Add("vanilla");
		icecream.Add("peach");
		icecream.Add("strawberry");
		icecream.Add("bourbon");
		Console.WriteLine(icecream.Count);
		Console.WriteLine(icecream[2]);
		icecream.RemoveAt(2);
		Console.WriteLine(icecream.Count);

        Dictionary <string, string> customer = new Dictionary<string, string>();
		customer.Add(names[0],null);
		customer.Add(names[1],null);
		customer.Add(names[2],null);
		customer.Add(names[3],null);
		Random rand = new Random();
		for(int x=0; x<names.Length; x++) {
			customer[names[x]]=icecream[rand.Next(0,4)];
		}
		foreach (KeyValuePair<string,string> name in customer){
			Console.WriteLine(name.Key+" "+name.Value);
		}
	}
}