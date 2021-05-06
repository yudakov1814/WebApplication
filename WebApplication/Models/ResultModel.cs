namespace WebApplication.Models
{
    public class ResultModel
    {
        public string Result { get; set; }

        public ResultModel(int first, int second, Operation op)
        {
            Result = op switch
            {
                Operation.Plus => $"{first} + {second} = {first + second}",
                Operation.Minus => $"{first} - {second} = {first - second}",
                Operation.Multiply => $"{first} * {second} = {first * second}",
                Operation.Divide => second == 0 ? "Нельзя делить на 0" : $"{first} / {second} = {first / second}",
                _ => "Не удалось посчитать результат"
            };
        }

        public ResultModel(CalcModel model) : this(model.First, model.Second, model.Operation) { }
    }
}
