//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int lenght = int.Parse(Console.ReadLine());
int []array = new int[lenght];

Random rnd = new Random();
for (int i = 0; i < lenght; i++) {
    array[i] = rnd.Next(100, 1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine("");

int count = 0;
for (int i = 0; i < lenght; i++) {
    if (array[i] % 2 == 0) {
        count ++;
    }
}

Console.WriteLine($"Количество чётных элементов = {count}");