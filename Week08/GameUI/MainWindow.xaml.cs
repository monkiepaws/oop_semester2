using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GameLibrary;
using WeaponLibrary;


namespace GameUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Player player;
        public Player opponent;
        public List<Player> opponentsFought;
        public Random rand;

        public MainWindow()
        {
            InitializeComponent();

            Style = (Style)FindResource(typeof(Window));

            player = new Player
            {
                Name = "Player",
                Health = 100,
                WeaponType = new MeleeWeapon(10)
            };

            opponentsFought = new List<Player>();

            rand = new Random();

            AddNewOpponent();

            UpdateCharacterDisplay();
        }

        private void BtnFight_Click(object sender, RoutedEventArgs e)
        {
            TbFight.Text = "";

            Fight(opponentsFought.Last());

            if (player.Health > 0)
            {
                if (player.Health + 40 > 100)
                {
                    player.Health = 100;
                }
                else
                {
                    player.Health += 40;
                }
            }
            else
            {
                TbFight.Text = "You are dead!";
                TbResultMessage.Text = $"You lasted {opponentsFought.Count} fights!";
            }

            AddNewOpponent();
        }

        private void Fight(Player opponent)
        {
            do
            {
                Battle attacker = new Battle(player, opponent);
                TbFight.Text = TbFight.Text.Insert(0, attacker.Go());

                UpdateCharacterDisplay();

                if (player.Health <= 0 || opponent.Health <= 0)
                {
                    break;
                }

                Battle defender = new Battle(opponent, player);
                TbFight.Text = TbFight.Text.Insert(0, defender.Go());

                UpdateCharacterDisplay();
            }
            while (player.Health > 0 && opponent.Health > 0);
        }

        private void AddNewOpponent()
        {
            Player nextOpponent = CreateOpponent();

            opponentsFought.Add(nextOpponent);

            DisplayCurrentOpponent();
        }

        private Player CreateOpponent()
        {
            Player opponent = new Player();

            opponent.Name = RandomName();
            opponent.Health = rand.Next(61) + 60;

            if (rand.Next(101) > 50)
            {
                opponent.WeaponType = new MeleeWeapon(rand.Next(9) + 5);
            }
            else
            {
                opponent.WeaponType = new RangedWeapon(rand.Next(9) + 5);
            }

            return opponent;
        }

        private string RandomName()
        {
            string[] names = { "Kooky", "Gripe", "Borris", "Daz", "MeatHead", "Warren", "LootyLootLoot", "Jas", "Poopy", "Troubles" };

            return names[rand.Next(10)];
        }

        private void UpdateCharacterDisplay()
        {
            DisplayPlayer();
            DisplayCurrentOpponent();
        }

        private void DisplayPlayer()
        {
            TbPlayerName.Text = player.Name;
            TbPlayerHealth.Text = player.Health.ToString();
            TbPlayerWeapon.Text = player.WeaponType.ToString();
        }

        private void DisplayCurrentOpponent()
        {
            TbOpponentName.Text = opponentsFought.Last().Name;
            TbOpponentHealth.Text = opponentsFought.Last().Health.ToString();
            TbOpponentWeapon.Text = opponentsFought.Last().WeaponType.ToString();
        }
    }
}
