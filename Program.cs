 Console.WriteLine("введите число:");
int N = int.Parse(Console.ReadLine());
int i = 2;
while (i<=N)
{
    if ((i % 2)==0)
    {    
    if (i>2) {Console.Write(", ");} // пишем запятую перед каждым числом, кроме первого
    Console.Write(i);
    }
    i++;
}