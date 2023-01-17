//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Console.WriteLine("Введите количество элементов в массиве");
// int size34=int.Parse(Console.ReadLine()!);
// int[] arr34=GetArr(size34);
// Console.WriteLine($"[{String.Join(",", arr34)}]");
// Console.WriteLine($"Четных элементов {CountEven(arr34)}");
// //Заполнение массива случайными трехзначными числами
// int[] GetArr (int size) {
//     int[] arr = new int[size];
//     for(int i = 0; i < size; i++){
//         arr[i] = new Random().Next(100, 1000);
//     }
//     return arr;
// }

// // Подсчет четных чисел в массиве
// int CountEven(int[] arr){
//     int count=0;
//     for(int i=0; i<arr.Length; i++){
//         if(arr[i]%2==0) count+=1;
//     }
//     return count;
// }

//36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах
// Console.Write("Введите количество элементов в массиве: ");
// int size36=int.Parse(Console.ReadLine()!);
// int[] arr36=GetArr36(size36);
// Console.WriteLine($"[{String.Join(",", arr36)}]");
// Console.WriteLine($"Сумма элементов на нечетных индексах: {SumOddIndex(arr36)}");

// //Заполнение массива случайными числами от -99 до 99
// int[] GetArr36 (int size) {
//     int[] arr = new int[size];
//     for(int i = 0; i < size; i++){
//         arr[i] = new Random().Next(-99, 100);
//     }
//     return arr;
// }

// //Сумма элементов на нечетных индексах
// int SumOddIndex(int[] arr){
//     int sum=0;
//     for(int i=1; i<arr.Length; i+=2){
//         sum+=arr[i];
//     }
//     return sum;
// }

//Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.

Console.Write("Введите количество элементов в массиве: ");
int size37=int.Parse(Console.ReadLine()!);
int[] arr37=GetArr37(size37);
Console.WriteLine($"[{String.Join(",", arr37)}]");
Console.WriteLine($"[{String.Join(",", CreateNewArr(arr37))}]");
//Заполнение массива случайными числами от -10 до 10
int[] GetArr37 (int size) {
    int[] arr = new int[size];
    for(int i = 0; i < size; i++){
        arr[i] = new Random().Next(-10, 11);
    }
    return arr;
}

// Создание массива из произведения элементов исходного массива (первый с последним)
int[] CreateNewArr(int[] arr){
    int newsize=0;
    if (arr.Length%2==0) newsize=arr.Length/2;
    else newsize=arr.Length/2+1;
    int[] newArr= new int[newsize];
    for(int i=0; i<arr.Length/2; i++){
        newArr[i]=arr[i]*arr[arr.Length-i-1];
    }
    if(arr.Length%2!=0) newArr[newsize-1]=arr[arr.Length/2];
    return newArr;
    }
