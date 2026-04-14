Console.Write("Nhap so phan tu cua mang: ");
int n = int.Parse(Console.ReadLine());
int[] mang = new int[n];

Console.WriteLine("---------Nhap mang--------");
for (int i=0; i<n; i++)
{
    Console.Write($"Nhap phan tu {i}: ");
    mang[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("--------------Mang vua nhap la----------");
for (int i=0; i<n; i++)
{
    Console.WriteLine($"Phan tu {i}: {mang[i]}");
}

Console.WriteLine("----------Selection Sort-------------");
for (int i=0; i<n; i++)
{
    int minIndex = i;
    for (int j =i+1; j<n; j++)
    {
        if (mang[j] < mang[minIndex])
        {
            minIndex = j;
        }
    }

    int temp = mang[i];
    mang[i] = mang[minIndex];
    mang[minIndex] = temp;
}
for (int i=0; i<n; i++)
{
    Console.Write($"{mang[i]} ");
}