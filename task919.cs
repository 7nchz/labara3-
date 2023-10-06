static void Main(string[] args)
{
    int[,] MyArray = new int[5, 5];

    Random gen = new Random();

    for (int i = 0; i < MyArray.GetLength(0); i++)
        for (int j = 0; j < MyArray.GetLength(1); j++)
            MyArray[i, j] = gen.Next(0, 30);


    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        Console.WriteLine("\n");
        for (int j = 0; j < MyArray.GetLength(1); j++)
            Console.Write(MyArray[i, j] + "\t");

    }

    Console.WriteLine("\n________________\n");

    int k = 0;
    int[] NewArray = new int[MyArray.Length];
    bool flag = true;


    for (int i = 0; i < MyArray.GetLength(0); i++)
        for (int j = 0; j < MyArray.GetLength(1); j++)
            NewArray[k++] = MyArray[i, j];




    for (int i = 0; i < NewArray.Length; i++)
    {
        flag = true;
        for (int j = 0; j < NewArray.Length; j++)
            if (NewArray[i] == NewArray[j] && i != j)
                flag = false;
        if (flag)
            Console.Write(NewArray[i] + ";");
    }



}