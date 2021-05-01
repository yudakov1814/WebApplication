using System;

namespace WebApplication.Services
{
    public class CalcService
    {
        public int First { get; private set; }
        public int Second { get; private set; }
        public int Sum => First + Second;
        public int Sub => First - Second;
        public int Mult => First * Second;
        public int Div => Second == 0 ? -1 : First / Second;

        public CalcService()
        {
            var rand = new Random();
            First = rand.Next() % 11;
            Second = rand.Next() % 11;
        }
    }
}
