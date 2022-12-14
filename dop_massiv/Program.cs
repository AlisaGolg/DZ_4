/* Сбор черники
В фермерском хозяйстве в Карелии выращивают чернику. 
Она растет на круглой грядке, причем кусты высажены только по окружности. 
Таким образом, у каждого куста есть ровно два соседних. 
Всего на грядке растет N кустов.

Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло 
различное число ягод – на i-ом кусте выросло ai ягод.

В этом фермерском хозяйстве внедрена система автоматического сбора черники. 
Эта система состоит из управляющего модуля и нескольких собирающих модулей. 
Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом, 
собирает ягоды с этого куста и с двух соседних с ним.

Напишите программу для нахождения максимального числа ягод, 
которое может собрать за один заход собирающий модуль, 
находясь перед некоторым кустом заданной во входном файле грядки.

Входные данные
Первая строка входного файла INPUT.TXT содержит целое число N (3 ≤ N ≤ 1000)
– количество кустов черники. 
Вторая строка содержит N целых положительных чисел a1, a2, ..., aN – число ягод черники,
 растущее на соответствующем кусте. Все ai не превосходят 1000.
 примеры:
 4
 1234 - 9
 3
 123 - 6
*/

int n = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[n]; 
for (int i = 0; i < n; i++)     
array[i] = Convert.ToInt32(Console.ReadLine());  
int[] arraySum = new int[n];  
for (int i = 1; i < n - 1; i++)     
arraySum[i - 1] = array[i - 1] + array[i] + array[i + 1];  
arraySum[n - 2] = array[0] + array[n - 1] + array[n - 2]; 
arraySum[n - 1] = array[n - 1] + array[0] + array[1]; 
int MaxNumber = arraySum[0]; 
for (int i = 0; i < n; i++) 
{     
    if (MaxNumber < arraySum[i])         
    MaxNumber = arraySum[i];
}

Console.WriteLine("[" + string.Join(", ", arraySum) + "]");
Console.WriteLine(MaxNumber);

