﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Question
    {
        public string Name {  get; set; }
        public string V1 {  get; set; }
        public string V2 { get; set; }
        public string V3 { get; set; }
        public string V4 { get; set; }
        public sbyte RightV {  get; set; }









        public static List<Question> FillQuestions(List<Question> questions)
        {
            questions.Add(new Question
            {
                Name = "Что такое функция в программировании?",
                V1 = "Это переменная, которая хранит значение.",
                V2 = "Это блок кода, который выполняет определенную задачу.",
                V3 = "Это структура данных для хранения информации.",
                V4 = "Это оператор для выполнения арифметических операций.",
                RightV = 2
            });
            questions.Add(new Question
            {
                Name = "Какие типы функций существуют в программировании?",
                V1 = "Функции без параметров и с параметрами.",
                V2 = "Функции с возвращаемым значением и без возвращаемого значения.",
                V3 = "Рекурсивные функции и итеративные функции.",
                V4 = "Все вышеперечисленное.",
                RightV = 4
            });
            questions.Add(new Question
            {
                Name = "Что такое рекурсия?",
                V1 = "Это функция, которая вызывает сама себя.",
                V2 = "Это функция, которая никогда не вызывает сама себя.",
                V3 = "Это функция, которая вызывает другую функцию.",
                V4 = "Это функция, которая вызывает себя бесконечно.",
                RightV = 1
            });
            questions.Add(new Question
            {
                Name = "Что такое параметры функции?",
                V1 = "Это переменные, которые передаются в функцию при ее вызове.",
                V2 = "Это переменные, объявленные внутри функции для хранения промежуточных результатов.",
                V3 = "Это переменные, которые возвращаются из функции после ее выполнения.",
                V4 = "Это переменные, которые доступны только внутри функции и не могут быть изменены извне.",
                RightV = 1
            });
           
            questions.Add(new Question
            {
                Name = "Что такое возвращаемое значение функции?",
                V1 = "Это значение, которое передается в функцию при ее вызове.",
                V2 = "Это значение, которое функция возвращает после своего выполнения.",
                V3 = "Это значение, которое доступно только внутри функции и не может быть использовано за ее пределами.",
                V4 = "Это значение, которое используется для определения типа функции.",
                RightV = 2
            });
            questions.Add(new Question
            {
                Name = "Какие проблемы могут возникнуть при использовании рекурсии?",
                V1 = "Переполнение стека вызовов (stack overflow).",
                V2 = "Зацикливание программы.",
                V3 = "Сложность в отладке и понимании кода.",
                V4 = "Все вышеперечисленное.",
                RightV = 4
            });
            questions.Add(new Question
            {
                Name = "Как можно оптимизировать рекурсивную функцию?",
                V1 = "Использовать хвостовую рекурсию.",
                V2 = "Использовать цикл вместо рекурсии.",
                V3 = "Уменьшить количество вызовов функции.",
                V4 = "Все вышеперечисленное.",
                RightV = 4
            });
            questions.Add(new Question
            {
                Name = "Какие преимущества имеет использование функций в программировании?",
                V1 = "Упрощение кода за счет повторного использования блоков кода.",
                V2 = "Улучшение структуры программы и уменьшение дублирования кода.",
                V3 = "Повышение читаемости и понятности кода для других разработчиков.",
                V4 = "Все вышеперечисленное.",
                RightV = 4
            });
          
           
            questions.Add(new Question
            {
                Name = "Что такое хвостовая рекурсия?",
                V1 = "Это рекурсия, при которой каждый вызов функции добавляет новый элемент в стек вызовов.",
                V2 = "Это рекурсия, при которой каждый вызов функции удаляет предыдущий элемент из стека вызовов.",
                V3 = "Это рекурсия, при которой вызов функции происходит в конце функции и нет дополнительных действий после этого вызова.",
                V4 = "Это рекурсия, при которой вызов функции происходит в начале функции и есть дополнительные действия после этого вызова.",
                RightV = 3
            });
            questions.Add(new Question
            {
                Name = "Что такое локальные переменные функции?",
                V1 = "Это переменные, объявленные внутри функции и доступные только внутри нее.",
                V2 = "Это переменные, которые передаются в функцию при ее вызове.",
                V3 = "Это переменные, которые доступны из любой части программы.",
                V4 = "Это переменные, которые хранятся в глобальной области видимости.",
                RightV = 1
            });
           
           

            return questions;
        }
    }
}