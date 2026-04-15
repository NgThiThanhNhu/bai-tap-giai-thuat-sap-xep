Console.Write("Nhap so phan tu cua mang: ");
int n = int.Parse(Console.ReadLine());

int[] mang = new int[n];
for (int i=0; i<n; i++)
{
    Console.Write("Phan tu: ");
    mang[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("---------Mang vua nhap---------");
for (int i=0; i<n; i++)
{
    Console.Write($"{mang[i]} ");
}
Console.WriteLine();
QuickSort(mang, 0, n-1);

Console.WriteLine("------MANG SAU KHI QUICK SORT----------");
for (int i=0; i<n; i++)
{
    Console.Write($"{mang[i]} ");
}
void QuickSort(int[] mang, int left, int right)
{
    if (left < right)
    {
        int pivot = mang[right];
        int phantutruocpivot = left - 1;

        for (int j = left; j<right; j++)
        {
            if (mang[j] < pivot)
            {
                phantutruocpivot++;

                int temp = mang[phantutruocpivot];
                mang[phantutruocpivot] = mang[j];
                mang[j] = temp;
            }
        }

        //dua pivot ve dung vi tri
        int temp1 = mang[phantutruocpivot + 1];
        mang[phantutruocpivot + 1] = mang[right];
        mang[right] = temp1;

        int pivotIndex = phantutruocpivot + 1;
        QuickSort(mang, left, pivotIndex -1);
        QuickSort(mang, pivotIndex+1, right);
    }
}