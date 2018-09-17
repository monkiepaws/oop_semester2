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
        public MainWindow()
        {
            InitializeComponent();

            player = new Player
            {
                Name = "Player",
                Health = 100,
                WeaponType = new MeleeWeapon(10)
            };

            opponent = new Player
            {
                Name = "Opponent",
                Health = 100,
                WeaponType = new RangedWeapon(10)
            };
        }

        private void BtnFight_Click(object sender, RoutedEventArgs e)
        {
            TbFight.Text = "";

            do
            {
                Fight attacker = new Fight(player, opponent);
                TbFight.Text += attacker.Go();


                if (player.Health <= 0 || opponent.Health <= 0)
                {
                    break;
                }

                Fight defender = new Fight(opponent, player);
                TbFight.Text += defender.Go();
            }
            while (player.Health > 0 && opponent.Health > 0);
        }
    }
}
