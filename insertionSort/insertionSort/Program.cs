Console.Write("Nhap so phan tu cua mang: ");
int n = int.Parse(Console.ReadLine());
int[] mang = new int[n];

for (int l=0; l<n; l++)
{
    Console.Write($"Phan tu {l}: ");
    mang[l] = int.Parse(Console.ReadLine());
}

Console.WriteLine("-------------Mang da nhap------------");
for (int l=0; l<n; l++)
{
    Console.Write($"{mang[l]} ");
}
Console.WriteLine();

Console.WriteLine("------------Mang da sap xep----------");
for (int l=0; l<n; l++)
{
    for (int j=l+1; j<n; j++)
    {
        if (mang[j] < mang[l])
        {
            int temp = mang[l];
            mang[l] = mang[j];
            mang[j] = temp;
        }
    }
}

for (int l=0; l<n; l++)
{
    Console.Write($"{mang[l]} ");
}

Console.Write("Nhap phan tu can chen: ");
int k = int.Parse(Console.ReadLine());
int m = n + 1;
int[] mang2 = new int[m];
int i = 0;
while (i<n && mang[i] < k)
{
    mang2[i] = mang[i];
    i++;
}

mang2[i] = k;

for (int j=i; j<n; j++)
{
    mang2[j+1] = mang[j];
}

Console.WriteLine("------------Mang sau khi da duoc sap xep----------");
for (int j=0; j<m; j++)
{
    Console.Write($"{mang2[j]} ");
}
