using System;

namespace lecture13_3
{
    class Program //лекция 13 пример 3
    {
        static void HoareSort(int[] array, int start, int end)
        {
            if (end == start) return; //выполнить, если верно условие
            var pivot = array[end]; //объявление массива
            var storeIndex = start; //задание переменной
            for (int i = start; i <= end - 1; i++) //цикл, пока верно условие
                if (array[i] <= pivot)//выполнять, если верно условие
                {
                    var t = array[i]; //присвоение переменной значения
                    array[i] = array[storeIndex]; //объявление массива
                    array[storeIndex] = t; //задание массива
                    storeIndex++; //инкремент
                }

            var n = array[storeIndex]; //задание массива
            array[storeIndex] = array[end]; //задание массива
            array[end] = n; //задание массива
            if (storeIndex > start) HoareSort(array, start, storeIndex - 1); //выполнять, если верно условие
            if (storeIndex < end) HoareSort(array, storeIndex + 1, end); //выполнять, если верно условие
        }

        static void HoareSort(int[] array)
        {
            HoareSort(array, 0, array.Length - 1); //быстрая сортировка
        }

        static Random random = new Random();

        public static void Main()
        {
            int[] array = {//задание элементов массива
		3,
        2,
        5,
        7,
        8,
        1,
        9
    };
            HoareSort(array); //быстрая сортировка
            foreach (var e in array) //выполнять для каждого указанного элемента
                Console.WriteLine(e); //вывод массива
            Console.ReadKey(); //программа ждет нажатия клавиши для завершения работы
        }
    }
}