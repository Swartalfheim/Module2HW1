namespace HWen
{
    internal class Starter
    {
        private Loger _loger;
        private Actions _action;
        public Starter()
        {
            _loger = Loger.GetInstance();
            _action = new Actions();
        }

        public void Run()
        {
            Random random = new Random();
            Result rez;
            for (int i = 0; i < 100; i++)
            {
                int a = random.Next(0, 3);
                switch (a)
                {
                    case 0:
                        rez = _action.First();
                        break;
                    case 1:
                        rez = _action.Second();
                        break;
                    case 2:
                        rez = _action.Third();
                        break;
                    default:
                        rez = new Result(true);
                        break;
                }

                if (rez.Status == false)
                {
                    _loger.Write("Error", rez.Message);
                }
            }

            _loger.PrintInfo();
        }
    }
}
