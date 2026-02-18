using System;

namespace MyLibrary
{
    public class BasicMath
    {
        public double Add(double a, double b)
        // Метод сложения
        // public — доступен извне
        // double — возвращаемый тип (число с плавающей точкой)
        // double a, double b — входные параметры
        {
            return a + b;
            // Возвращает сумму двух чисел
        }

        public double Subtract(double a, double b)
        // Метод вычитания
        {
            return a - b;
            // Возвращает разность чисел
        }

        public double Multiply(double a, double b)
        // Метод умножения
        {
            return a * b;
            // Возвращает произведение чисел
        }

        public double Divide(double a, double b)
        // Метод деления
        {
            if (b == 0)
                // Проверка деления на ноль
                // Если делитель равен 0 — выполнение дальше невозможно
                throw new Exception("Деление на ноль!");
            // Генерируется исключение (ошибка)

            return a / b;
            // Возвращает результат деления
        }
    }
}
