using System;
using System.Drawing;
using System.Windows.Forms;

namespace League_of_Legends_Champion_Randomizer
{
    public partial class Form1 : Form
    {
        private Manager _manager;
        private Int32 _currentLinesInLastPickedChamps = 0;
        public Form1()
        {
            InitializeComponent();

            Console.WriteLine(new Random().Next(1, 6));
            this.Icon = new Icon(AppDomain.CurrentDomain.BaseDirectory + @"\icons\SoftwareIcon.ico");
            this.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icons\SoftwareBackground.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.SendToBack();

            _manager = new Manager();
            
            SetAllButtonImages();
        }

        private void SetAllButtonImages()
        {
            topButton.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icons\topIcon.png");
            topButton.BackgroundImageLayout = ImageLayout.Center;
            jglButton.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icons\jglIcon.png");
            jglButton.BackgroundImageLayout = ImageLayout.Center;
            midButton.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icons\midIcon.png");
            midButton.BackgroundImageLayout = ImageLayout.Center;
            adcButton.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icons\adcIcon.png");
            adcButton.BackgroundImageLayout = ImageLayout.Center;
            suppButton.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icons\suppIcon.png");
            suppButton.BackgroundImageLayout = ImageLayout.Center;
        }

        private void buttonClickEvent(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.DataBindings.Control.Name)
            {
                case "allButton":
                    UpdatePreviewRandomChamp(_manager.GetRandomChamp("all"));
                    break;
                case "topButton":
                    UpdatePreviewRandomChamp(_manager.GetRandomChamp("top"));
                    break;
                case "jglButton":
                    UpdatePreviewRandomChamp(_manager.GetRandomChamp("jgl"));
                    break;
                case "midButton":
                    UpdatePreviewRandomChamp(_manager.GetRandomChamp("mid"));
                    break;
                case "adcButton":
                    UpdatePreviewRandomChamp(_manager.GetRandomChamp("adc"));
                    break;
                case "suppButton":
                    UpdatePreviewRandomChamp(_manager.GetRandomChamp("supp"));
                    break;
            }
        }

        private void UpdatePreviewRandomChamp(Champion champion)
        {
            var widthCenter = this.Width / 2;
            var heightCenter = this.Height / 2;
            pictureBox1.Image = champion.ChampionImage;
            pictureBox1.Width = champion.ChampionImage.Width;
            pictureBox1.Height = champion.ChampionImage.Height;
            Point loc = new Point((this.Width / 2) - (pictureBox1.Width / 2), (this.Height / 2) - (pictureBox1.Height / 2));
            pictureBox1.Location = loc;
            rndChampNameLabel.Text = champion.ChampionName;
            UpdateLastRandomChampPickedLabel(champion.ChampionName);
        }

        private void UpdateLastRandomChampPickedLabel(String name)
        {
            if(_currentLinesInLastPickedChamps > 17)
            {
                _currentLinesInLastPickedChamps = 1;
                lastChampPicks.Text = "\n" + name;
                lastChampPicks.Invalidate();
                return;
            }
            lastChampPicks.Text += $"\n{name}";
            _currentLinesInLastPickedChamps++;
        }
    }
}
