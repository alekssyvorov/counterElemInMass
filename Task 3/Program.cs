using System;

namespace Task_3
{
    class Program
    {
//        Задание 3
//Пользователь вводит с клавиатуры три числа.Необходимо подсчитать сколько раз последовательность из этих
//трёх чисел встречается в массиве.
//Например:
//пользователь ввёл: 7 6 5;
//        массив: 7 6 5 3 4 7 6 5 8 7 6 5;
//количество повторений последовательности: 3.
        static void Main(string[] args)
        {
            int[] inputUser = UserMass();
            //foreach (var item in inputUser)
            //{
            //    Console.Write(item + " ");
            //}

            int[] mass = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5, };
            Console.WriteLine(Check(mass, inputUser));
            Console.ReadLine();
        }

        public static int[] UserMass()
        {
            int[] user = new int[3];
            Console.WriteLine("input string numbers");
            string temp = Console.ReadLine();
            string[] mass = temp.Split(' ');
            for (int i = 0; i < user.Length; i++)
            {
                user[i] = int.Parse(mass[i]);
            }
            return user;
        }

        public static int Check(int[] arr, int[] inputUser)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < inputUser.Length; j++)
                {
                    if (arr[i] == inputUser[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
    }
}
