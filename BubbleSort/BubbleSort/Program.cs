Console.Write("Nhap so phan tu cua mang: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for (int i=0; i<n; i++)
{
    Console.Write("Phan tu - [{0}]: ", i);
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Mang vua nhap");
for (int i=0; i<n; i++)
{
    Console.Write($"{arr[i]} ");
}
Console.WriteLine("\n---------------BUBBLE SORT---------------\n");

for (int i=0; i<n; i++)
{
    for (int j=i+1; j<n; j++)
    {
        if (arr[i] > arr[j])
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

for (int i=0; i<n; i++)
{
    Console.Write($"{arr[i]} ");
}