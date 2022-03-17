using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
            this.Icon = new Icon(AppDomain.CurrentDomain.BaseDirectory + @"\gfx\SoftwareIcon.ico");
            this.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\gfx\SoftwareBackground.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.SendToBack();

            _manager = new Manager();
            
            SetAllButtonImages();
        }

        private void SetAllButtonImages()
        {
            topButton.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\gfx\topIcon.png");
            topButton.BackgroundImageLayout = ImageLayout.Center;
            jglButton.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\gfx\jglIcon.png");
            jglButton.BackgroundImageLayout = ImageLayout.Center;
            midButton.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\gfx\midIcon.png");
            midButton.BackgroundImageLayout = ImageLayout.Center;
            adcButton.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\gfx\adcIcon.png");
            adcButton.BackgroundImageLayout = ImageLayout.Center;
            suppButton.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\gfx\suppIcon.png");
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
