//Демонстрация решения
//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

Console.Clear();

Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int [] array = GetArray(size,-9,9);

Console.WriteLine(String.Join(" ", array));

int sumPositive = 0;
int sumNegative = 0;
//[3, 1, -2, -4]
foreach(int element in array){
    sumPositive += element > 0 ? element : 0;
    sumNegative += element < 0 ? element : 0;
}

Console.WriteLine($"sum positive: {sumPositive} sum negative {sumNegative}");

int [] GetArray(int size, int min, int max){
    int[] result = new int[size];

    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(min, max + 1);
    }
return result;
}
