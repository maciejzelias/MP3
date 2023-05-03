namespace mp3
{
    public class Player
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name value can not be null or empty !");
                }
                _name = value;
            }
        }

        private PlayerType? _playerType;
        public PlayerType PlayerType
        {
            get => (PlayerType)_playerType;
            set
            {
                if (value == _playerType)
                {
                    throw new ArgumentException("You cant make player : " + value + " beacuse it is already this type !");
                }
                _playerType = value;
            }
        }

        private string? _role;
        public string Role
        {
            get => _role;
            set
            {
                if (PlayerType == PlayerType.Substitute)
                {
                    if (!String.IsNullOrEmpty(value))
                        throw new ArgumentException("You cant set role value on player type substitute !");
                }
                else if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Role value can not be set to null or empty");
                }
                _role = value;
            }
        }

        private string? _injuryDescription;
        public string InjuryDescription
        {
            get => _injuryDescription;
            set
            {
                if (PlayerType == PlayerType.Normal)
                {
                    if (!String.IsNullOrEmpty(value))
                        throw new ArgumentException("You cant set Injury value on player type normal !");
                }
                else if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Injury value can not be null or empty");
                }
                _injuryDescription = value;

            }
        }

        private Player(string name)
        {
            this.Name = name;
        }

        public static Player createNormalPlayer(string name, string role)
        {
            var player = new Player(name);
            player.makeNormal(role);

            return player;
        }

        public static Player createSubstitutePlayer(string name, string injury)
        {
            var player = new Player(name);
            player.makeSubstitute(injury);

            return player;
        }

        public void makeNormal(string role)
        {
            this.PlayerType = PlayerType.Normal;
            this.Role = role;
            this.InjuryDescription = null;
        }

        public void makeSubstitute(string injury)
        {
            this.PlayerType = PlayerType.Substitute;
            this.InjuryDescription = injury;
            this.Role = null;
        }
    }

    public enum PlayerType
    {
        Normal, Substitute
    }
}