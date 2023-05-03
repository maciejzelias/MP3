namespace mp3
{
    public class MotorCoach : Coach
    {
        public int YearsOfExperience { get; set; }

        public override double CalculateSalary()
        {
            double experienceBonus = YearsOfExperience * 1000;
            return BaseSalary + experienceBonus;
        }
        public MotorCoach(string name, int birthdayYear, double baseSalary, int yearsOfExperience)
            : base(name, birthdayYear, baseSalary)
        {
            YearsOfExperience = yearsOfExperience;
        }
    }
}