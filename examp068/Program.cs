Console.Write("Введите число M: ");      // решение рекурсией
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

while( m < 0)
{
Console.WriteLine("Число M не может быть отрицательным! Повторите ввод");
    Console.Write("Введите число M: ");
    m = int.Parse(Console.ReadLine());
}
while( n < 0)
{
Console.WriteLine("Число N не может быть отрицательным! Повторите ввод");  
    
    Console.Write("Введите число N: ");
    n = int.Parse(Console.ReadLine());
}

int FAkkermana(int n, int m) 
{ 
    if (n == 0) return m + 1; 
    else if ((n != 0) && (m == 0)) return FAkkermana(n - 1, 1); 
    else return FAkkermana(n - 1, FAkkermana(n, m - 1)); 
    }
Console.WriteLine(FAkkermana(m,n));