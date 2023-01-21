// See https://aka.ms/new-console-template for more information
// 1.Himnakan ankyunagci ev ir tak gtnvox elementneri gumar@ bajanac qanaki vra(1)

//double sum = 0;
//int[,] array = new int[3, 3];
//Random rnd = new Random();
//int count = 0 ;
//for (int row = 0; row < array.GetLength(0); row++)
//{
//    for (int column = 0; column < array.GetLength(1); column++)
//    {
//        int t = rnd.Next(1, 10);
//        Console.Write(t + "\t");
//        array[column, row] = t;

//        if ((column == 0 && row == 0) || (column == 1 && row == 1) || (column == 2 && row == 2) || (column == 0 && row == 1) || (column == 0 && row == 2) || (column == 1 && row == 2))
//        {
//            sum += array[column, row];
//            count++;

//        }
//    }
//    Console.WriteLine();
//    Console.WriteLine();
//}


//Console.Write("Numbers Count: {0}\n", count);
//Console.Write("Result of Diagonal elements is :{0}\n", sum /= count);



// 2.Himnakan ankyunagci ev ir tak gtnvox elementneri gumar@ bajanac qanaki vra(2)

//int[,] arr=new int[3,3];
//Random random= new Random();
//double bottom = 0;
//double diagonal = 0;
//int count = 0;
//for(int column=0;column<arr.GetLength(0); column++)
//{
//	for (int row = 0; row < arr.GetLength(1); row++)
//	{
//		int t=random.Next(1,20);
//		Console.Write(t + "\t");
//		arr[column,row]= t;
//        if (column == row)
//        {
//            diagonal += arr[column, row];
//			count++;
//        }
//		if (column > row)
//		{
//			bottom += arr[column, row];
//			count++;
//		}

//	}
//	Console.WriteLine();
//	Console.WriteLine();
//}


//Console.WriteLine("Diagonal: " + diagonal);
//Console.WriteLine("Bottom Elements: " + bottom);
//Console.WriteLine($"{bottom + diagonal} / {count} = {(bottom + diagonal)/count}");



//3. Himnakan ankyunagci ev ir tak gtnvox elementneri gumar@ bajanac qanaki vra(2)

//int[,] arr = new int[3, 3];
//Random rnd=new Random();
//int count = 0;
//double sum = 0;
//for (int i = 0;i < arr.GetLength(0); i++)
//{
//	for (int j = 0; j <= i; j++)
//	{
//		int t=rnd.Next(1,10);
//		Console.Write(t + "\t");
//		arr[i,j]= t;
//		sum += arr[i, j];
//		count++;
//	}
//	Console.WriteLine();
//	Console.WriteLine();
//}
//Console.WriteLine(sum);
//Console.WriteLine(count);
//Console.WriteLine(sum/count);


// erkrordakan ankyunagci ev ir verevi elementner@ voronq kent en aysinq chen bajanvum 2 i

//int[,] arr = new int[3, 3];
//Random random = new Random();
//double left = 0;
//double secondary = 0;
//double count = 0;
//for (int column = 0; column < arr.GetLength(0); column++)
//{
//	for (int row = 0; row < arr.GetLength(1); row++)
//	{
//		int t = random.Next(1, 20);
//		Console.Write(t + "\t");
//		arr[column, row] = t;
//		if((column + row) == (3-1))
//		{
//			secondary = arr[column, row];
//			if(secondary % 2 != 0)
//			{
//				count++;
//			}
//		}
//		if((column==0 && row==0) || (column==0 && row==1) || (column==1 && row==0))
//		{
//			left = arr[column, row];
//			if(left % 2 != 0)
//			{
//				count++;
//			}
//		}

//	}
//	Console.WriteLine();
//	Console.WriteLine();
//}

//Console.WriteLine("Secondary Diagonal: " + secondary);
//Console.WriteLine("Left: " + left);
//Console.WriteLine("Count: " + count);

//Point p=new Point(4,5);
//Console.WriteLine(p.Distance(new Point(6, 2)));

//struct Point
//{
//    private float x;
//    private float y;
//    public Point(float x, float y)
//    {
//        this.x= x; 
//        this.y = y;  
//    }

//    public double Distance(Point other)
//    {
//        return Math.Sqrt(Math.Pow(other.x-x,2)+Math.Pow(other.y-y,2));
//    }
//}
