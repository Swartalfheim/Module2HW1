namespace HWen
{
    internal class Loger
    {
        private string _log;
        private static Loger? _instance;
        private Loger()
        {
            _log = string.Empty;
        }

        public void Write(string type, string message)
        {
            string rez = $"{DateTime.Now.TimeOfDay}: {type}: {message}\n";
            Console.Write(rez);
            _log += rez;
        }

        public void PrintInfo()
        {
            File.WriteAllText("log.txt", _log);
        }

        public static Loger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Loger();
            }

            return _instance;
        }
    }
}
