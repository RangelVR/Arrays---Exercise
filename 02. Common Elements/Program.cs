string[] arr1 = Console.ReadLine().Split().ToArray();
string[] arr2 = Console.ReadLine().Split().ToArray();


foreach (var itemInArr2 in arr2)
{
	foreach (var itemInArr1 in arr1)
	{
		if (itemInArr1 == itemInArr2)
		{
			Console.Write(itemInArr2 + " ");
		}
	}
}


//for (int i = 0; i < arr2.Length; i++)
//{
//	for (int k = 0; k < arr1.Length; k++)
//	{
//		if (arr2[i] == arr1[k])
//		{
//			Console.Write(arr2[i] + " ");
//		}
//	}
//}
