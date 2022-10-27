// Виды методов
// Вид 1 - не принимают никакие аргументы и ничего не возвращают

void Method1()
{
    Console.WriteLine("какой нибудь тестовый текст");
}
//Method1(); // способ вызова методов

// Вид 2 - принимают какие то аргументы, но ничего не возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Вывод сообщения");

void Method21(string msg, int count)  // пример с несколькими именованными аргументами
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        //count++;  произошла ошибка - зацикливание программы, остановка с помощью Ctrl+C
        i++; // исправили ошибку
    }
}
//Method21("Тестовый текст", 4); если именовать аргументы можно писать их не по порядку метода, пример в сл. строке
//Method21(count: 5, msg: "text");

// Вид 3 - не принимают никакие аргументы, но что то возвращают (например генерируют случайные данные)

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

// Вид 4 - что то принимают и что то возвращают для дальней работ

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; // String.Empty означает, что изначально строка result будет пустой

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(55, "Zz");
// Console.WriteLine(res);

string Method4(int count, string text) // Циклы это не только while есть еще for и цикл в цикле
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(55, "Zz");
//Console.WriteLine(res);

// Пример создания таблицы умножения с помощью цикла в цикле

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}"); // Интерполяция строк - это процесс оценки строкового литерала, содержащего один или несколько заполнителей, в результате чего заполнители заменяются соответствующими значениями
    }
    Console.WriteLine();
}