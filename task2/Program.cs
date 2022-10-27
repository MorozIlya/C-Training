// Находим максимум из 9 чисел.


// Классическое (стихийный подход) решение.

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 22133;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 313;

// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

// Console.WriteLine(max);


// С использованием функции/метода.

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 15555;
// int b1 = 2431;
// int c1 = 39;
// int a2 = 12;
// int b2 = 233;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 313;

// // int max1 = Max(a1, b1, c1);
// // int max2 = Max(a2, b2, c2);
// // int max3 = Max(a3, b3, c3);
// // int max = Max(max1, max2, max3);

// // Более короткий вариант.

// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
// Console.WriteLine(max);



// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// //               0   1   2   3   4   5   6   7   8   Значения индексов.
// int[] array = { 11, 3421, 31, 41, 15, 61, 17, 28, 19, };
// // array[0] = 12;               Каким образом можно обратиться к массиву и записать в него значение.
// // Console.WriteLine(array[0]); Каким образом можно обратиться к массиву и получить значение соответствующего элемента по указаному индексу

// int result = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
//     );
// Console.WriteLine(result);

// Пример задачи №1 из текстового файла
int[] array = { 11, 18, 12, 31, 4, 15, 16, 17, 18, };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find) // == знак совпадения/равенства
    {
        Console.WriteLine(index);
        break;  //Прерывание алгоритма, чтобы показывался первый номер массива с нужным числом, если в масиве имеются несколько одинаковых чисел
    }
    //index = index + 1;
    index++;
}