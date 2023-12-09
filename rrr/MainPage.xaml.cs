using RPGui.GameStuff.Character;

namespace RPGMaui
{
    public partial class MainPage : ContentPage
    {
        int totalPoints = 20, mPoints = 0, ePoints = 0, aPoints = 0, lPoints = 0;
        Player player;

        public MainPage()
        {
            InitializeComponent();
            pointText();
        }

        public void pointText()
        {
            lMight.Text = mPoints + "";
            lEndurance.Text = ePoints + "";
            lAgility.Text = aPoints + "";
            lLuck.Text = lPoints + "";
            lTotal.Text = totalPoints + " points left";
        }

        private void minusPoints(ref int points)
        {
            if (points > 0)
            {
                points--;
                totalPoints++;
            }
            pointText();
        }

        private void plusPoints(ref int points)
        {
            if (totalPoints > 0)
            {
                totalPoints--;
                points++;
            }
            pointText();
        }

        private void leftMight(object sender, EventArgs args)
        {
            minusPoints(ref mPoints);
        }

        private void rightMight(object sender, EventArgs args)
        {
            plusPoints(ref mPoints);
        }

        private void leftEndurance(object sender, EventArgs args)
        {
            minusPoints(ref ePoints);
        }

        private void rightEndurance(object sender, EventArgs args)
        {
            plusPoints(ref ePoints);
        }

        private void leftAgility(object sender, EventArgs args)
        {
            minusPoints(ref aPoints);
        }

        private void rightAgility(object sender, EventArgs args)
        {
            plusPoints(ref aPoints);
        }

        private void leftLuck(object sender, EventArgs args)
        {
            minusPoints(ref lPoints);
        }

        private void rightLuck(object sender, EventArgs args)
        {
            plusPoints(ref lPoints);
        }

        private void playerChange(Job job)
        {
            player = new Player(job);
            mPoints = player.might;
            ePoints = player.endurance;
            aPoints = player.agility;
            lPoints = player.luck;
            totalPoints = 0;
            pointText();
        }

        private void PlayClicked(object sender, EventArgs args)
        {
            if (rbWarrior.IsChecked || rbKnight.IsChecked || rbRogue.IsChecked || rbWarlock.IsChecked || rbDruid.IsChecked || rbTrickster.IsChecked)
            {
                App.Current.MainPage = new NavigationPage(new DialoguePage(player));
            }
            else
            {
                lFeedback.Text = "Please pick a class";
            }
        }

        private void warriorChecked(object sender, CheckedChangedEventArgs args)
        {
            playerChange(Job.Warrior);
        }

        private void knightChecked(object sender, CheckedChangedEventArgs args)
        {
            playerChange(Job.Knight);
        }

        private void rogueChecked(object sender, CheckedChangedEventArgs args)
        {
            playerChange(Job.Rogue);
        }

        private void warlockChecked(object sender, CheckedChangedEventArgs args)
        {
            playerChange(Job.Warlock);
        }

        private void druidChecked(object sender, CheckedChangedEventArgs args)
        {
            playerChange(Job.Druid);
        }

        private void tricksterChecked(object sender, CheckedChangedEventArgs args)
        {
            playerChange(Job.Trickster);
        }
    }
}
