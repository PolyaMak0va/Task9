using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        // Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, а затем – код операции
        // (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное).
        // После этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных.
        static void Main(string[] args)
        {
            double a=0;
            double b=0;
            try
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите первое число:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите целое число. Y = {0}", b);
                Console.WriteLine("Введите код операции: " + "\n" + "\t1 - сложение" + "\n" + "\t2 - вычитание" + "\n" + "\t3 - произведение" + "\n" + "\t4 - частное");
                Console.Write("Ваш выбор: ");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            Console.Write("Результат сложения = {0:f2}", a + b);
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Результат вычитания = {0:f2}", a - b);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Результат произведения = {0:f2}", a * b);
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Результат частного = {0:f2}", a / b);
                            break;
                        }
                    default:
                        {
                            Console.Write("Нет операции с указанным номером!");
                            break;
                        }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
            }
            catch (DivideByZeroException ex) when (b==0)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            }
        }
    }
