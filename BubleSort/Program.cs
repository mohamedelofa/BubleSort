namespace BubleSort
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr;
			Console.Write("Enter number of integers : ");
			int n = int.Parse(Console.ReadLine());
			arr = new int[n];
			for(int i = 0; i < arr.Length; i++)
			{
				Console.Write($"Enter number {i+1} : ");
				arr[i] = (int.Parse(Console.ReadLine()));
			}

			while(true)
			{
				Console.WriteLine("Choose way you want to sort based on :\n1.Ascending\n2.Descending");
				int choice = int.Parse(Console.ReadLine());
				switch (choice)
				{
					case 1:
						BubbleSort(arr, (x, y) => x > y);
						break;
					case 2:
						BubbleSort(arr, (x, y) => x < y);
						break;
				}
				for (int i = 0; i < arr.Length; i++)
				{
					Console.WriteLine($"number {i+1} = {arr[i]}");
				}
			}
		}

		static void BubbleSort(int[] arr , Func<int,int,bool> predicate)
		{
			for(int  i = 0; i < arr.Length - 1; i++)
			{
				for(int j = 0; j < arr.Length - 1 - i; j++)
				{
					if (predicate.Invoke(arr[j] , arr[j+1]))
						Swap(ref arr[j], ref arr[j + 1]);
				}
			}
		}

		static void Swap(ref int i, ref int j)
		{
			int temp = i;
			i = j;
			j = temp;
		}
	}
}
