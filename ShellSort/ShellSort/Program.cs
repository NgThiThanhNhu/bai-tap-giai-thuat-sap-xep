Console.Write("Nhap phan tu cua mang: ");
int n = int.Parse(Console.ReadLine());

int[] mang = new int[n];
for (int i=0; i<n; i++)
{
    Console.Write($"Phan tu {i}: ");
    mang[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("------------MANG VUA NHAP------------");
for (int i=0; i<n; i++)
{
    Console.Write($"{mang[i]} ");
}

Console.WriteLine();

for (int gap = n/2; gap > 0; gap/=2)
{
    for (int i= gap; i<n; i++)
    {
        int temp = mang[i];
        int j = i;

        while (j>=gap && mang[j - gap] > temp)
        {
            mang[j] = mang[j - gap];
            j -= gap;
        }
        mang[j] = temp;
    }
}

Console.WriteLine("--------MANG SAU KHI SHELL SORT-------------");
for (int i=0; i<n; i++)
{
    Console.Write($"{mang[i]} ");
}