// Console.Write("Введите число M: ");    // решение через цикл "for"
// int m = int.Parse(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine());

// while (m > n)
// {
//     Console.WriteLine("Число M должно быть меньше числа N, повторите ввод!");
//     Console.Write("Введите число M: ");
//     m = int.Parse(Console.ReadLine());

//     Console.Write("Введите число N: ");
//     n = int.Parse(Console.ReadLine());
// }
// for (int i = m; i < n; ++i) {      
//     if (i <= 0)     {
//         continue;
//     }
//     else     {
//         Console.Write(i + ", ");
//     }
// }
//Console.Write(n);

Console.Write("Введите число M: ");      // решение рекурсией
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

while (m > n)
{
    Console.WriteLine("Число M должно быть меньше числа N, повторите ввод!");
    Console.Write("Введите число M: ");
    m = int.Parse(Console.ReadLine());

    Console.Write("Введите число N: ");
    n = int.Parse(Console.ReadLine());
}

if (m <= 0)  {
    m = 1;
}
int NatChislo(int m, int n) {
    if (m == n) return n;
    Console.Write(m + ", ");
    return NatChislo(m + 1 , n);
    
}

Console.WriteLine(NatChislo(m,n));