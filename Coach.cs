namespace mp3
{
    public abstract class Coach
    {
        private double _baseSalary;

        public double BaseSalary
        {
            get => _baseSalary;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("salary value has to be grater than 0!");
                }
                _baseSalary = value;
            }
        }
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name of the coach can not be null  or empty!");
                }
                _name = value;
            }
        }
        private int _birthdayYear;
        public int BirthdayYear
        {
            get => _birthdayYear;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age value has to be grater than 0!");
                }
                _birthdayYear = value;
            }
        }

        public Coach(string name, int birthdayYear, double baseSalary)
        {
            Name = name;
            BirthdayYear = birthdayYear;
            BaseSalary = baseSalary;
        }
        public abstract double CalculateSalary();
    }
}