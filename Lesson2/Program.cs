﻿using System;

namespace Lesson2
{
    class Program
    {
        /*Практическая работа к модулю 2
         * 
         * Для уюобства просмотра работы разделил задания на отдельные методы, которые вызываются в методе Main()
         * 
         * Для практики использовал два способа форматирования вывода.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1\n");
            Exercise_1(); //Вызов метода содержащего код задания 1

            Console.WriteLine("\nДля вывода информации из задания 2 нажмите на любую кнопку на клавиатуре");
            Console.ReadKey(); // Ожидание нажатия пользователем кнопки для выполнения последующего кода

            Console.WriteLine("\nЗадание 2\n");
            Exercise_2(); //Вызов метода содержащего код задания 1

            Console.ReadKey();
        }

        //Статический метод, который выполняет код и ничего не возвращает
        //В данном методе содержится код Задания 1
        static void Exercise_1()
        {
            string FullName = "Иванов Иван Инванович"; //Переменная строкового типа содержащая ФИО
            int Age = 22; //Переменная целочисленного типа содержащая возраст
            string email = "IvanovII@gmail.com"; //Переменная строкового типа содержащая email
            double ProgrammingScroe = 4.7; //Переменная типа с плавающей точкой содержащая баллы по программированию
            double MathScore = 4.2; //Переменная типа с плавающей точкой содержащая баллы по математике
            double PhysicsScroe = 3.9; //Переменная типа с плавающей точкой содержащая баллы по Физике

            //Вывод информации на экран с помощью интерполяции строк
            Console.WriteLine($"ФИО: {FullName}\nВозраст: {Age}\ne-mail:{email}\nБаллы по программированию: {ProgrammingScroe}\nБаллы по математике: {MathScore}\nБаллы по физике: {PhysicsScroe}");
        }


        //Статический метод, который выполняет код и ничего не возвращает
        //В данном методе содержится код Задания 2
        static void Exercise_2()
        {
            string FullName = "Иванов Иван Инванович"; //Переменная строкового типа содержащая ФИО
            int Age = 22; //Переменная целочисленного типа содержащая возраст
            string email = "IvanovII@gmail.com"; //Переменная строкового типа содержащая email
            double ProgrammingScroe = 4.7; //Переменная типа с плавающей точкой содержащая баллы по программированию
            double MathScore = 4.2; //Переменная типа с плавающей точкой содержащая баллы по математике
            double PhysicsScroe = 3.9; //Переменная типа с плавающей точкой содержащая баллы по Физике
            double ScoreSum = ProgrammingScroe + MathScore + PhysicsScroe; //Переменная типа с плавающей точкой содержащая сумму балов по всем предметам
            double ArithmeticMean = ScoreSum / 3; //Переменная типа с плавающей точкой содержащая среднее арифмитическое баллов

            //Шаблон вывода информации на экран
            string TemplateOutput = "ФИО: {0} \nВозраст: {1} \ne-mail:{2}\nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5} \nСумма балов: {6} \nСреднее арифмитическое баллов:{7}";

            //Вывод информации на экран
            Console.WriteLine(TemplateOutput, 
                              FullName, 
                              Age, 
                              email, 
                              ProgrammingScroe, 
                              MathScore, 
                              PhysicsScroe,
                              ScoreSum, 
                              ArithmeticMean.ToString("#.##"));
        }
    }
}
