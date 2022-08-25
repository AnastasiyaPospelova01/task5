//Задача 38: Задайте массив вещественных чисел. Найдите разницу
//между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double []array = {2.3, 1.56, 8.09, 13.0, 41.1, 0.5, 80.0};

double max = array[0];
for (int i = 1; i < 7; i++) {
    if (array[i] > max) {
        max = array[i];
    }
}

double min = array[0];
for (int i = 1; i < 7; i++) {
    if (array[i] < min) {
        min = array[i];
    }
}

Console.WriteLine($"Разница между макс. и мин. элементами массива = {max-min}");