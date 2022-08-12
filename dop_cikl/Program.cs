/* Расстояние между максимумами

Элемент последовательности называется локальным максимумом,
если он строго больше предыдущего и последующего элемента последовательности. 
Первый и последний элемент последовательности не являются локальными максимумами.

Задана последовательность натуральных чисел, завершающаяся числом 0. 
Требуется определить наименьшее расстояние между двумя локальными максимумами 
последовательности натуральных чисел, завершающейся числом 0.

Входные данные
Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел, не превышающих значения 100. Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0.

Выходные данные
В выходной файл OUTPUT.TXT выведите целое число – наименьшее расстояние между двумя локальными максимумами. Если в последовательности нет двух локальных максимумов, выведите число 0.

121121210 - 2
1230 - 0
*/

int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[101]; 
int i = 0; while (n != 0) 
{     
    array[i] = n;     
    n = Convert.ToInt32(Console.ReadLine());     
    i++; 
} 
Console.WriteLine("[" + string.Join(", ", array) + "]"); 
int[] dlina = new int[i]; 
int k = 0; 
for (int j = 1; j < i - 1; j++) 
{     
    if (array[j] > array[j - 1] && array[j] > array[j + 1])     
    {         
        dlina[k] = j;         
        k++;     
    } 
} 
Console.WriteLine("[" + string.Join(", ", dlina) + "]");  
int[] difference = new int[k * k]; int c = 0; 
for (int j = 0; j < k; j++) 
{     
    for (int m = j + 1; m < k; m++)     
    {         
        difference[c] = Math.Abs(dlina[j] - dlina[m]);         
        c++;     
    } 
} 
Console.WriteLine("[" + string.Join(", ", difference) + "]"); 
int mins = difference[0]; 
for (int j = 0; j < difference.Length; j++)
{
    if (difference[j] != 0 && difference[j] < mins)
        mins = difference[j];
}
Console.WriteLine(mins);

