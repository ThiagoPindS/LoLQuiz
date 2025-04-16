using LeagueQuests.Classes;
using LeagueQuests.Screens;

namespace LeagueQuests
{
    public partial class Menu : Form
    {
        public static Menu? instance;

        public Menu()
        {
            InitializeComponent();

            instance = this;

            Question.AddToList("What's the name of Veigar's ult??", "Primordial Burst", ["Primordial Burst", "Event Horizon", "Dark Matter", "Baleful Strike", "Phenomenal Evil Power"]);

            Question.AddToList("What's the name of Gangplank's ult??", "Cannon Barrage", ["Cannon Barrage", "Powder Keg", "Remove Scurvy", "Parrrley", "Trial by Fire"]);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();

            Game game = new Game();

            game.ShowDialog();

            if (game != null)
            {
                this.Show();
            }
        }
    }
}
