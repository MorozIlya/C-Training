__*Функции в программировании*__
-это часть программного кода, который создаёт разработчик
* функция имеет идентификатор (имя)
* может иметь выходные аргументы
* может возвращать значение

f(x) = x^2 + 1    _опишем какие аргументы принимает данная функция._

double f(double x)

{

    double result = x * x + 1;


    return result
}

_где_ **double** _это вещественный тип данных (целое или нецелое значение),_ **double f** _означает, что это возвращаемый тип,_ **double** _тип аргумента, а_ **x** _имя аргумента._


**return result** _где_ **result** _возвращаемое значение._
_Всё, что находится в фигурных скобках, и есть,_ **ТЕЛО МЕТОДА.**

__*Создание массива*__ - int[] array = {17, 12, 26, 53, 55, 14, 61, 72}

_где_ **int[]** _ввод массива, а_ **array** _его название._

__*Пример на задаче №1*__

*Имеется одномерный массив* **array** *из* **n** *элементов, требуется найти элемент массива, равный* **find** .
* 1 *Установить счетчик* **index** (_далее будем именовать его_ **i** _для удобства и сокращения_) *в позицию 0*
* 2 *Если* **array[i] = find**, *алгоритм успешно завершил работу.*
* 3 *Увеличить* **i** *на 1* (**i = i + 1, i+=, i++**).
* 4 *Если* **i < n**, *то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно.*