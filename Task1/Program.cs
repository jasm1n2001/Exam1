int FindMinimum(int a, int b, int c, int d)
{
    int min = 0;
    if(a < b && a < c && a < d)min=a;
    if(b < a && b < c  && b < d)min=b;
    if(c < a && c < b && c < d)min=c;
    if(d < a && d < b && d < c)min = d;
    return min;
}
int a = Convert.ToInt32(Console.ReadLine);
int b = Convert.ToInt32(Console.ReadLine);
int c = Convert.ToInt32(Console.ReadLine);
int d = Convert.ToInt32(Console.ReadLine);
int min=0;

FindMinimum($"")
