namespace TypeClassAndGetType
{
    public class Guy
    {

        private readonly string _name;
        public string Name { get { return _name; } }

        private readonly int _age;
        public int Age { get { return _age;} }

        public int Cash { get; private set; }

        public Guy(string name, int age, int cash)
        {
            _name = name;
            _age = age;
            Cash = cash;
        }
    }
}
