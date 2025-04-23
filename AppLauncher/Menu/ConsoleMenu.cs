namespace AppLauncher.Menu
{
    /// <summary>
    /// 控制台菜单
    /// 引用https://github.com/splttingatms/EasyConsole
    /// </summary>
    public class ConsoleMenu
    {
        private IList<Option> Options { get; set; }

        public ConsoleMenu()
        {
            Options = [];
        }

        public void Display()
        {
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, Options[i].Name);
            }
            int choice = Input.ReadInt("Choose an option:", min: 1, max: Options.Count);

            Options[choice - 1].Callback();
        }

        public ConsoleMenu Add(string option, Action callback)
        {
            return Add(new Option(option, callback));
        }

        public ConsoleMenu Add(Option option)
        {
            Options.Add(option);
            return this;
        }

        public bool Contains(string option)
        {
            return Options.FirstOrDefault((op) => op.Name.Equals(option)) != null;
        }
    }
}
