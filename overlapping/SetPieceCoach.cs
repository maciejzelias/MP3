namespace mp3
{
    public class SetPieceCoach : Coach
    {
        private Boolean? _canTeachScrewingBall { get; set; }
        public Boolean? CanTeachScrewingBall
        {
            get => _canTeachScrewingBall;
            set
            {
                if (!types.Contains(SetPieceCoachType.CornerKick))
                {
                    throw new ArgumentException("You cant add canTeachScrewingBall property to SetPieceCoach that is not CornerKick type !");
                }
                _canTeachScrewingBall = value;
            }
        }

        private Boolean? _canTeachPositioning { get; set; }
        public Boolean? CanTeachPositioning
        {
            get => _canTeachPositioning; set
            {
                if (!types.Contains(SetPieceCoachType.FreeKick))
                {
                    throw new ArgumentException("You cant add canTeachPositioning property to SetPieceCoach that is not Free kick type !");
                }
                _canTeachPositioning = value;
            }
        }

        private Boolean? _canTeachPanemka { get; set; }
        public Boolean? CanTeachPanemka
        {
            get => _canTeachPanemka; set
            {
                if (!types.Contains(SetPieceCoachType.PenaltyKick))
                {
                    throw new ArgumentException("You cant add canTeachPanemka property to SetPieceCoach that is not penalty kick type !");
                }
                _canTeachPanemka = value;
            }
        }
        private HashSet<SetPieceCoachType> types = new HashSet<SetPieceCoachType> { SetPieceCoachType.setPieceCoach };

        public SetPieceCoach(string name, int birthdayYear, double baseSalary) : base(name, birthdayYear, baseSalary)
        {
        }

        public void makeFreeKickCoach(Boolean canTeachPositioning)
        {
            if (types.Contains(SetPieceCoachType.FreeKick))
            {
                throw new ArgumentException("You cant make this coach " + SetPieceCoachType.FreeKick + " type because it is already this type !");
            }
            this.types.Add(SetPieceCoachType.FreeKick);
            this.CanTeachPositioning = canTeachPositioning;
        }
        public void removeFreeKickType()
        {
            this._canTeachPositioning = null;
            this.types.Remove(SetPieceCoachType.FreeKick);
        }

        public void makePenaltyKickCoach(Boolean canTeachPanemka)
        {
            if (types.Contains(SetPieceCoachType.PenaltyKick))
            {
                throw new ArgumentException("You cant make this coach " + SetPieceCoachType.PenaltyKick + " type because it is already this type !");
            }
            this.types.Add(SetPieceCoachType.PenaltyKick);
            this.CanTeachPanemka = canTeachPanemka;
        }

        public void removePenaltyKickType()
        {
            this._canTeachPanemka = null;
            this.types.Remove(SetPieceCoachType.PenaltyKick);
        }


        public void makeCornerKickCoach(Boolean canTeachScrewingBall)
        {
            if (types.Contains(SetPieceCoachType.CornerKick))
            {
                throw new ArgumentException("You cant make this coach " + SetPieceCoachType.CornerKick + " type because it is already this type !");
            }
            this.types.Add(SetPieceCoachType.CornerKick);
            this.CanTeachScrewingBall = canTeachScrewingBall;
        }

        public void removeCornerKickType()
        {
            this._canTeachScrewingBall = null;
            this.types.Remove(SetPieceCoachType.CornerKick);
        }
        public override double CalculateSalary()
        {
            return BaseSalary;
        }
    }

    enum SetPieceCoachType
    {
        setPieceCoach,
        CornerKick,
        FreeKick,
        PenaltyKick,
    }


}