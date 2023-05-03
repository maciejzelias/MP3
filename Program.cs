
namespace mp3
{
    class main
    {
        static void Main(string[] args)
        {
            // Abstract / polimorfizm
            var motorCoach1 = new MotorCoach("Jacek Kowalski", 1986, 3000, 2);
            var tacticCoach1 = new TacticCoach("Michał Wisniewski", 1989, 3000, 3);

            Console.WriteLine(motorCoach1.CalculateSalary());
            Console.WriteLine(tacticCoach1.CalculateSalary());

            // Dynamic

            var player1 = Player.createNormalPlayer("Leo Messi", "Striker");
            Console.WriteLine("Role : " + player1.Role);
            Console.WriteLine("Injury Description : " + player1.InjuryDescription);

            player1.Role = "Attacker";
            Console.WriteLine("Role : " + player1.Role);
            Console.WriteLine("Injury Description : " + player1.InjuryDescription);

            // player1.makeNormal("Attacker"); // throws and error
            player1.makeSubstitute("Twisted ankle");
            Console.WriteLine("Role : " + player1.Role);
            Console.WriteLine("Injury Description : " + player1.InjuryDescription);


            // Overlapping

            var setPieceCoach = new SetPieceCoach("Jacek Muranski", 1955, 2000);

            setPieceCoach.makeCornerKickCoach(true);
            Console.WriteLine("Can teach screwing ball : " + setPieceCoach.CanTeachScrewingBall);
            Console.WriteLine("Can teach positioning : " + setPieceCoach.CanTeachPositioning);
            Console.WriteLine("Can teach panemka : " + setPieceCoach.CanTeachPanemka);

            setPieceCoach.makePenaltyKickCoach(true);
            setPieceCoach.makeFreeKickCoach(true);
            // setPieceCoach.makeCornerKickCoach(true) // throw error

            Console.WriteLine("Can teach screwing ball : " + setPieceCoach.CanTeachScrewingBall);
            Console.WriteLine("Can teach positioning : " + setPieceCoach.CanTeachPositioning);
            Console.WriteLine("Can teach panemka : " + setPieceCoach.CanTeachPanemka);

            setPieceCoach.removeCornerKickType();
            setPieceCoach.CanTeachPanemka = false;

            Console.WriteLine("Can teach screwing ball : " + setPieceCoach.CanTeachScrewingBall);
            Console.WriteLine("Can teach positioning : " + setPieceCoach.CanTeachPositioning);
            Console.WriteLine("Can teach panemka : " + setPieceCoach.CanTeachPanemka);
        }
    }
}