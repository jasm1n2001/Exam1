 int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int min= 99999;
int max = -99999;
int elmn = 0;
int elmx = 0;
// int cnt=
for(int i=0; i<n; i++)
{
    arr[i]=int.Parse(Console.ReadLine());
}
for(int i=0; i<n; i++)
{
    if(arr[i] > max) max = arr[i];
    if(arr[i] < min) min = arr[i];
}

System.Console.WriteLine($"{min}  and max {max}");
