// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine(i);
// }


// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }


// for (int i = 2; i <= 50; i+= 2)
// {
//     Console.WriteLine(i);
// }


// int sum = 0;
// int count = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         sum += i;
//     }
//     if (i % 7 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);
// Console.WriteLine(sum);


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int total_plus = 0;
// int total_minus = 0;

// while (number != 0)
// {
//     if (number > 0)
//     {
//         total_plus++;
//     }
//         if (number < 0)
//     {
//         total_minus++;
//     }
//     Console.Write("Введите число: ");
//     number = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Положительных чисел: {total_plus}");
// Console.WriteLine($"Отрицательных чисел: {total_minus}");


// string password;
// for (int i = 0; i <= 4; i++)
// {
//     if (i == 3)
//     {
//         Console.WriteLine("");
//         Console.WriteLine("Доступ запрещён!");
//         break;
//     }
//     Console.Write("Введите пароль: ");
//     password = Console.ReadLine();
//     if (password == "qwerty")
//     {
//         Console.WriteLine("");
//         Console.WriteLine("Доступ разрешён!");
//         break;
//     }
// }


// Console.Write("Введите число от 1 до 9: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{n} x {i} = {n * i}");
// }


// for (int i = 1; i <= 30; i++)
// {
//     if (i % 3 == 0)
//     {
//         continue;
//     }
//     else
//     {
//         Console.WriteLine(i);
//     }
//     if (i % 10 == 0)
//     {
//         if (i > 20)
//         {
//             break;
//         }
//     }
// }


// Console.WriteLine("Игра: Угадай число!");
// int secret = 42;
// for (int i = 0; i <= 6; i++){
//     int number = Convert.ToInt32(Console.ReadLine());
//     if (i == 4 && number != secret){
//         Console.WriteLine("");
//         Console.WriteLine("Вы проиграли, число было 42!");
//         break;
//     }
//     else{
//         if (number == secret){
//             Console.WriteLine("");
//             Console.WriteLine($"Победа! Попыток: {i + 1}!");
//             break;
//         } else if (number > secret){
//             Console.WriteLine("Загаданное число меньше!");
//         } else if (number < secret){
//             Console.WriteLine("Загаданное число больше!");
//         }
//     }
// }


Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int count = 0;
while (number > 0)
{
    count++;
    sum += number % 10;
    number = number / 10;
}
Console.WriteLine($"Сумма цифр в вашем числе = {sum}");
Console.WriteLine($"Количество цифр в вашем числе = {count}");