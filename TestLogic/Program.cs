using TestLogic.Five;
using static System.Console;
using TestLogic.Shifter;
using TestLogic.SumNum;
using TestLogic.Money;
using TestLogic.Pyramid;


Five _five = new Five();
WriteLine("Тест метода, который возвращает всегда 5. Подряд 6 видов реализаций.");
WriteLine(_five.GetFive());
WriteLine(_five.GetFive1());
WriteLine(_five.GetFive2());
WriteLine(_five.GetFive3());
WriteLine(_five.GetFive4());
WriteLine(_five.GetFive5());
try
{
    long s = 0;
    var fl = false;
    WriteLine("Тест метода, который возвращает входное число вместе с цифрами в порядке убывания.");
    WriteLine("Введите натуральное неотрицательно число s:");
    var str = ReadLine();
    while (!fl)
    {
        if (str.Trim() != "" && str != null && long.TryParse(str, out s) && int.Parse(str)>0)
        {
            s = int.Parse(str);
            WriteLine(Shifter.GetShifter(s));
            fl = true;
        }
        else
        {
            WriteLine("Это не то, что от вас ожидают. Введите натуральное неотрицательное число");
            str = ReadLine();
        }
    }
    fl = false;
    long n = 0;
    WriteLine("Тест метода, который возвращает сумму цифр входного числа.");
    WriteLine("Введите натуральное неотрицательно число n:");
    str = ReadLine();
    while (!fl)
    {
        if (str.Trim() != "" && str != null && long.TryParse(str, out n) && int.Parse(str) > 0)
        {
            n = int.Parse(str);
            WriteLine(Num.Summ(n)); ;
            fl = true;
        }
        else
        {
            WriteLine("Это не то, что от вас ожидают. Введите натуральное неотрицательное число");
            str = ReadLine();
        }
    }
    fl = false;
    long id = 0;
    WriteLine("Тест метода, который считает сумму сроки по индексу строки.");
    WriteLine("Введите натуральное неотрицательно число id - индекс строки:");
    str = ReadLine();
    while (!fl)
    {
        if (str.Trim() != "" && str != null && long.TryParse(str, out id) && int.Parse(str) > 0)
        {
            id = int.Parse(str);
            WriteLine(Pyramid.Calculation(id)); ;
            fl = true;
        }
        else
        {
            WriteLine("Это не то, что от вас ожидают. Введите натуральное неотрицательное число");
            str = ReadLine();
        }
    }
    fl = false;
    float l = 0.0f;
    WriteLine("Тест метода, который принимает принимает количество американской валюты центы (cents) и\r\n" +
                "возвращает словарь / хэш, который показывает наименьшее количество монет, используемых для\r\nсоздания этой суммы.");
    WriteLine("Введите число l - кол-во амер. валюты в центах:");
    str = ReadLine();
    while (!fl)
    {
        if (str.Trim() != "" && str != null && float.TryParse(str, out l))
        {
            l = float.Parse(str);
            foreach (var item in Money.GetMoney(l))
                WriteLine(item);
            fl = true;
        }
        else
        {
            WriteLine("Это не то, что от вас ожидают. Введите число");
            str = ReadLine();
        }
    }
    
}
catch
{
    WriteLine("Ошибка! Вы ввели не то что от вас просят.");
}

