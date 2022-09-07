/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */

Console.WriteLine("Введите несколько чисел в формате 1, -7, 567, 89, 223");
string str = Console.ReadLine() +',';
string num = "";
int calc = 0;
int number = 0;

for (int i = 0; i < str.Length; i++)
{
  if (str[i] != ' '){
  if (str[i] != ',')
  {
    num += str[i];
  }
  else
  {
    number = int.Parse(num);
    if (number > 0)
    {
      calc ++;
    }
    num = "";
  }
  }
}

Console.WriteLine($"Чисел больше нуля: {calc}.");