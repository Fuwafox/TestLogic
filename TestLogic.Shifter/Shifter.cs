namespace TestLogic.Shifter
{
    /// <summary>
    /// Класс, который содержит метод возвращающий входное число с цифрами в порядке убывания
    /// </summary>
    public static class Shifter
    {
        public static long GetShifter(long n) => long.Parse(string.Concat(n.ToString().OrderByDescending(x=>x)));
        
    }
}