namespace TestLogic.SumNum
{
    /// <summary>
    /// Класс содержит метод, который складывает цифры во входном числе пока число не станет одноразрядным
    /// </summary>
    public static class Num
    {
        public static int Summ(long n)
        {
            var _str = n.ToString();
            while (_str.Length > 1)
            {
                _str = _str.Select(x => int.Parse(x.ToString())).Sum().ToString();
            }
            return int.Parse(_str);

        }
    }
}