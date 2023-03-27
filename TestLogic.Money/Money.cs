namespace TestLogic.Money
{
    /// <summary>
    /// Класс который принимает число (возможно отрицательное или вещественное) и возвращает словарь / хэш, который 
    /// показывает наименьшее количество монет, используемых для создания, входной суммы
    /// </summary>
    public static class Money
    {

        public static Dictionary<string, int> GetMoney(float n)
        {
            int l = (int)Math.Floor(n); 
            Dictionary<string, int> _dictMoney = new Dictionary<string, int>() 
            { 
                { "Nickels", 0 }, 
                { "Pennies", 0 }, 
                { "Dimes", 0 }, 
                { "Quarters", 0 } 
            };
            if (l <= 0)
                return _dictMoney;
            _dictMoney["Quarters"] = l/25;
            var ost = l % 25;
            _dictMoney["Dimes"] = ost/10;
            ost = (ost) % 10;
            _dictMoney["Pennies"] = ost/5;
            ost = ost % 5;
            _dictMoney["Nickels"] = ost;
            return _dictMoney;

        }
        
    }
}