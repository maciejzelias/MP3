namespace mp3
{
    public class TacticCoach : Coach
    {
        public int _last5matchesVictoriesCount;
        public int last5matchesVictoriesCount
        {
            get => _last5matchesVictoriesCount;
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentException("last5matches value has to  be between 0-5");
                }
                _last5matchesVictoriesCount = value;
            }
        }
        public override double CalculateSalary()
        {
            double matchBonus = _last5matchesVictoriesCount * 1000;
            return BaseSalary + matchBonus;
        }

        public TacticCoach(string name, int birthdayYear, double baseSalary, int last5matchesVictoriesCount)
            : base(name, birthdayYear, baseSalary)
        {
            this.last5matchesVictoriesCount = last5matchesVictoriesCount;
        }

    }
}