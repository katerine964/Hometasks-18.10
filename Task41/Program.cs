// See https://aka.ms/new-console-template for more information
Console.Clear();


int PositElem (int m)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Введите число под номером "+(i+1));
        int n = Convert.ToInt32(Console.ReadLine());
        if(n > 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Введите количество чисел: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Kоличество чисел больше нуля: "+PositElem(N));
