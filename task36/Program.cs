//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int lenght = int.Parse(Console.ReadLine());
int []array = new int[lenght];

Random rnd = new Random();
for (int i = 0; i < lenght; i++) {
    array[i] = rnd.Next(100, 1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine("");

int sum = 0;
for (int i = 1; i < lenght; i += 2) {
    sum += array[i];
}

Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");