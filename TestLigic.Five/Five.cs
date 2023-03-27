using System.Text;

namespace TestLogic.Five
{
    /// <summary>
    /// Класс содержит методы, которые ничего не принимает и возвращают только 5
    /// </summary>
    public class Five
    {
        List<string> _list = new List<string>() { "fffffa","ffff","fffff","ffff","ffff"};
        public int GetFive() => "FFFFA".Length;

        public int GetFive1() => _list.First().IndexOf('a');

        public int GetFive2() => _list.Count();

        public int GetFive3() => (int)Weekday.Saturday;

        public int GetFive4() => Convert.ToInt32('!') ^ Convert.ToInt32('$');

        public int GetFive5()
        {
            int a = Convert.ToInt32('!');
            int b = Convert.ToInt32('U');
            return b >> a >> a >> a >> a;
        }

    }
}