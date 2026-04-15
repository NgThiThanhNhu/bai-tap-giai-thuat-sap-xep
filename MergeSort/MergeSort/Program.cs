Console.Write("Nhap phan tu cua mang: ");
int n = int.Parse(Console.ReadLine());

int[] mang = new int[n];
for (int i=0; i<n; i++)
{
    Console.Write($"Phan tu {i}: ");
    mang[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("----------Mang da nhap-----------");
for (int i=0; i<n; i++)
{
    Console.Write($"{mang[i]} ");
}
Console.WriteLine();
int phantudaubentrai, phantucuoibenphai;
phantudaubentrai = 0;
phantucuoibenphai = n-1;
int mid = (phantudaubentrai + phantucuoibenphai) / 2;

//Sort nửa trái
for (int i = phantudaubentrai; i <= mid; i++)
{
    for (int j = i + 1; j <= mid; j++)
    {
        if (mang[j] < mang[i])
        {
            int temp = mang[i];
            mang[i] = mang[j];
            mang[j] = temp;
        }
    }
}

//Sort nửa phải
for (int i = mid + 1; i <= phantucuoibenphai; i++)
{
    for (int j = i + 1; j <= phantucuoibenphai; j++)
    {
        if (mang[j] < mang[i])
        {
            int temp = mang[i];
            mang[i] = mang[j];
            mang[j] = temp;
        }
    }
}

// In sau khi sort tung nua
Console.WriteLine("\n\n----Mang sau khi sort tung nua----");
for (int i = 0; i < n; i++)
{
    Console.Write($"{mang[i]} ");
}
Console.WriteLine();
//-------------merge--------------
int[] mang2 = new int[n];
int i1 = 0;
int j1 = mid + 1;
int k = 0;

while (i1<=mid && j1<n)
{
    if (mang[i1] < mang[j1])
    {
        mang2[k++] = mang[i1++];
    }
    else
    {
        mang2[k++] = mang[j1++];
    }
}

while (i1<=mid)
{
    mang2[k++] = mang[i1++];
}

while (j1<n)
{
    mang2[k++] = mang[j1++];
}

for (int i=0; i<n; i++)
{
    mang[i] = mang2[i];
}
Console.WriteLine("------------Mang da merge sort-------------");
for (int i=0; i<n; i++)
{
    Console.Write($"{mang[i]} ");
}
