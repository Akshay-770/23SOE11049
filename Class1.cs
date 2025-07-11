using System;

public class Class1
{
	public Class1()
	{
		static void Main(string[] args)
		{
			int[]arr= new int[6];
			arr = { 1, 2, 3, 4, 5, 6 };
			for(int i = 0; i <=6; i++)
			{
				arr[i] = i;
				Console.WriteLine(arr[i]);

            }
			Console.WriteLine("using for loop");

            foreach (int j in arr)
			{
				arr[j] = j;
                Console.WriteLine("using for each loop"+j);

            }
        }
    }
}
