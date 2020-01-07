namespace CodeSmells
{
    public class PropertiesClass
    {
        private string _property1;
        private string _property2;
        private string _property3;

        public PropertiesClass(string property1, string property2, string property3)
        {
            _property1 = property1;
            _property2 = property2;
            _property3 = property3;
        }

        public string GetProperty1()
        {
            return _property1;
        }

        public void SetProperty1(string porperty1)
        {
            _property1 = _property1;
        }

        public string Property2
        {
            get { return _property2; }
            set { _property2 = value; }
        }

        public string Property3 => _property3;
    }
}