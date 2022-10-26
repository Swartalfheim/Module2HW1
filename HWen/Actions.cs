namespace HWen
{
    public class Actions
    {
        private Loger _loger;
        public Actions()
        {
            _loger = Loger.GetInstance();
        }

        public Result First()
        {
            _loger.Write("Info", "Start method: First");
            return new Result(true);
        }

        public Result Second()
        {
            _loger.Write("Warning", "Skipped logic in method: Second");
            return new Result(true);
        }

        public Result Third()
        {
            return new Result(false, "I broke a logic: Third");
        }
    }
}
