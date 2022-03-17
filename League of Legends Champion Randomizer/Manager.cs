using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Legends_Champion_Randomizer
{
    public class Manager
    {
        public List<Champion> Champions { get; set; } = new List<Champion>();
        public List<Champion> TopChampions { get; set; } = new List<Champion>();
        public List<Champion> JungleChampions { get; set; } = new List<Champion>();
        public List<Champion> MidChampions { get; set; } = new List<Champion>();
        public List<Champion> AdcChampions { get; set; } = new List<Champion>();
        public List<Champion> SupportChampions { get; set; } = new List<Champion>();
        public Manager()
        {
            InitializeAllChamps();
        }

        private void InitializeAllChamps()
        {
            InitializeAllLists("Aatrox", "top");
            InitializeAllLists("Ahri", "mid");
            InitializeAllLists("Akali", "mid");
            InitializeAllLists("Akali", "top");
            InitializeAllLists("Akshan", "mid");
            InitializeAllLists("Akshan", "adc");
            InitializeAllLists("Alistar", "support");
            InitializeAllLists("Amumu", "jgl");
            InitializeAllLists("Anivia", "mid");
            InitializeAllLists("Annie", "mid");
            InitializeAllLists("Annie", "support");
            InitializeAllLists("Aphelios", "adc");
            InitializeAllLists("Ashe", "adc");
            InitializeAllLists("Aurelion Sol", "mid");
            InitializeAllLists("Azir", "mid");
            InitializeAllLists("Bard", "support");
            InitializeAllLists("Blitzcrank", "support");
            InitializeAllLists("Brand", "support");
            InitializeAllLists("Brand", "mid");
            InitializeAllLists("Braum", "support");
            InitializeAllLists("Caitlyn", "adc");
            InitializeAllLists("Camille", "top");
            InitializeAllLists("Cassiopeia", "top");
            InitializeAllLists("Cassiopeia", "mid");
            InitializeAllLists("Cassiopeia", "adc");
            InitializeAllLists("Cho'Gath", "top");
            InitializeAllLists("Cho'Gath", "mid");
            InitializeAllLists("Corki", "mid");
            InitializeAllLists("Darius", "top");
            InitializeAllLists("Diana", "mid");
            InitializeAllLists("Diana", "jgl");
            InitializeAllLists("Dr.Mundo", "top");
            InitializeAllLists("Dr.Mundo", "jgl");
            InitializeAllLists("Draven", "adc");
            InitializeAllLists("Ekko", "mid");
            InitializeAllLists("Ekko", "jgl");
            InitializeAllLists("Elise", "jgl");
            InitializeAllLists("Evelynn", "jgl");
            InitializeAllLists("Ezreal", "adc");
            InitializeAllLists("Fiddlesticks", "jgl");
            InitializeAllLists("Fiora", "top");
            InitializeAllLists("Fizz", "mid");
            InitializeAllLists("Galio", "mid");
            InitializeAllLists("Galio", "support");
            InitializeAllLists("Gangplank", "top");
            InitializeAllLists("Garen", "top");
            InitializeAllLists("Garen", "mid");
            InitializeAllLists("Gnar", "top");
            InitializeAllLists("Gragas", "top");
            InitializeAllLists("Gragas", "jgl");
            InitializeAllLists("Gragas", "mid");
            InitializeAllLists("Graves", "mid");
            InitializeAllLists("Graves", "top");
            InitializeAllLists("Graves", "jgl");
            InitializeAllLists("Gwen", "jgl");
            InitializeAllLists("Gwen", "top");
            InitializeAllLists("Hecarim", "jgl");
            InitializeAllLists("Heimerdinger", "top");
            InitializeAllLists("Heimerdinger", "mid");
            InitializeAllLists("Illaoi", "top");
            InitializeAllLists("Irelia", "top");
            InitializeAllLists("Irelia", "mid");
            InitializeAllLists("Ivern", "support");
            InitializeAllLists("Ivern", "jgl");
            InitializeAllLists("Janna", "support");
            InitializeAllLists("Jarvan IV", "jgl");
            InitializeAllLists("Jax", "jgl");
            InitializeAllLists("Jax", "top");
            InitializeAllLists("Jayce", "top");
            InitializeAllLists("Jayce", "mid");
            InitializeAllLists("Jhin", "adc");
            InitializeAllLists("Jinx", "adc");
            InitializeAllLists("Kai'Sa", "adc");
            InitializeAllLists("Kai'Sa", "mid");
            InitializeAllLists("Kalista", "adc");
            InitializeAllLists("Karma", "support");
            InitializeAllLists("Karthus", "jgl");
            InitializeAllLists("Kassadin", "mid");
            InitializeAllLists("Katarina", "top");
            InitializeAllLists("Katarina", "mid");
            InitializeAllLists("Kayle", "mid");
            InitializeAllLists("Kayle", "top");
            InitializeAllLists("Kayn", "jgl");
            InitializeAllLists("Kennen", "top");
            InitializeAllLists("Kha'Zix", "jgl");
            InitializeAllLists("Kindred", "jgl");
            InitializeAllLists("Kled", "top");
            InitializeAllLists("Kog'Maw", "adc");
            InitializeAllLists("LeBlanc", "mid");
            InitializeAllLists("Lee Sin", "jgl");
            InitializeAllLists("Leona", "support");
            InitializeAllLists("Lillia", "jgl");
            InitializeAllLists("Lissandra", "mid");
            InitializeAllLists("Lucian", "adc");
            InitializeAllLists("Lulu", "support");
            InitializeAllLists("Lux", "support");
            InitializeAllLists("Lux", "mid");
            InitializeAllLists("Malphite", "mid");
            InitializeAllLists("Malphite", "top");
            InitializeAllLists("Malzahar", "mid");
            InitializeAllLists("Maokai", "support");
            InitializeAllLists("Master Yi", "jgl");
            InitializeAllLists("Miss Fortune", "adc");
            InitializeAllLists("Mordekaiser", "top");
            InitializeAllLists("Mordekaiser", "jgl");
            InitializeAllLists("Morgana", "support");
            InitializeAllLists("Nami", "support");
            InitializeAllLists("Nasus", "top");
            InitializeAllLists("Nasus", "jgl");
            InitializeAllLists("Nautilus", "support");
            InitializeAllLists("Neeko", "support");
            InitializeAllLists("Neeko", "mid");
            InitializeAllLists("Nidalee", "jgl");
            InitializeAllLists("Nocturne", "jgl");
            InitializeAllLists("Nunu & Willump", "jgl");
            InitializeAllLists("Olaf", "jgl");
            InitializeAllLists("Orianna", "mid");
            InitializeAllLists("Ornn", "top");
            InitializeAllLists("Pantheon", "top");
            InitializeAllLists("Pantheon", "mid");
            InitializeAllLists("Pantheon", "support");
            InitializeAllLists("Pantheon", "jgl");
            InitializeAllLists("Poppy", "jgl");
            InitializeAllLists("Poppy", "top");
            InitializeAllLists("Poppy", "support");
            InitializeAllLists("Pyke", "support");
            InitializeAllLists("Qiyana", "mid");
            InitializeAllLists("Qiyana", "jgl");
            InitializeAllLists("Quinn", "top");
            InitializeAllLists("Rakan", "support");
            InitializeAllLists("Rammus", "jgl");
            InitializeAllLists("Rek'Sai", "jgl");
            InitializeAllLists("Rell", "support");
            InitializeAllLists("Renata Glasc", "support");
            InitializeAllLists("Renekton", "top");
            InitializeAllLists("Renekton", "mid");
            InitializeAllLists("Rengar", "jgl");
            InitializeAllLists("Rengar", "top");
            InitializeAllLists("Riven", "top");
            InitializeAllLists("Rumble", "mid");
            InitializeAllLists("Ryze", "mid");
            InitializeAllLists("Ryze", "top");
            InitializeAllLists("Samira", "adc");
            InitializeAllLists("Sejuani", "jgl");
            InitializeAllLists("Senna", "support");
            InitializeAllLists("Seraphine", "support");
            InitializeAllLists("Sett", "support");
            InitializeAllLists("Sett", "top");
            InitializeAllLists("Shaco", "jgl");
            InitializeAllLists("Shaco", "support");
            InitializeAllLists("Shen", "top");
            InitializeAllLists("Shyvana", "jgl");
            InitializeAllLists("Singed", "top");
            InitializeAllLists("Singed", "mid");
            InitializeAllLists("Sion", "top");
            InitializeAllLists("Sion", "jgl");
            InitializeAllLists("Sivir", "adc");
            InitializeAllLists("Skarner", "jgl");
            InitializeAllLists("Sona", "support");
            InitializeAllLists("Soraka", "support");
            InitializeAllLists("Swain", "support");
            InitializeAllLists("Sylas", "mid");
            InitializeAllLists("Sylas", "top");
            InitializeAllLists("Syndra", "mid");
            InitializeAllLists("Tahm Kench", "top");
            InitializeAllLists("Taliyah", "jgl");
            InitializeAllLists("Talon", "jgl");
            InitializeAllLists("Talon", "mid");
            InitializeAllLists("Taric", "jgl");
            InitializeAllLists("Taric", "support");
            InitializeAllLists("Teemo", "top");
            InitializeAllLists("Thresh", "support");
            InitializeAllLists("Tristana", "adc");
            InitializeAllLists("Trundle", "jgl");
            InitializeAllLists("Trundle", "top");
            InitializeAllLists("Tryndamere", "top");
            InitializeAllLists("Twisted Fate", "mid");
            InitializeAllLists("Twitch", "adc");
            InitializeAllLists("Udyr", "jgl");
            InitializeAllLists("Urgot", "top");
            InitializeAllLists("Varus", "adc");
            InitializeAllLists("Vayne", "adc");
            InitializeAllLists("Vayne", "top");
            InitializeAllLists("Veigar", "mid");
            InitializeAllLists("Veigar", "support");
            InitializeAllLists("Veigar", "adc");
            InitializeAllLists("Vel'Koz", "support");
            InitializeAllLists("Vel'Koz", "mid");
            InitializeAllLists("Vex", "mid");
            InitializeAllLists("Vex", "support");
            InitializeAllLists("Vi", "jgl");
            InitializeAllLists("Viego", "jgl");
            InitializeAllLists("Viktor", "mid");
            InitializeAllLists("Vladimir", "top");
            InitializeAllLists("Vladimir", "mid");
            InitializeAllLists("Volibear", "top");
            InitializeAllLists("Volibear", "jgl");
            InitializeAllLists("Warwick", "jgl");
            InitializeAllLists("Warwick", "top");
            InitializeAllLists("Wukong", "top");
            InitializeAllLists("Xayah", "adc");
            InitializeAllLists("Xerath", "support");
            InitializeAllLists("Xerath", "mid");
            InitializeAllLists("Xin Zhao", "jgl");
            InitializeAllLists("Yasuo", "top");
            InitializeAllLists("Yasuo", "mid");
            InitializeAllLists("Yasuo", "adc");
            InitializeAllLists("Yone", "top");
            InitializeAllLists("Yone", "mid");
            InitializeAllLists("Yorick", "top");
            InitializeAllLists("Yuumi", "support");
            InitializeAllLists("Zac", "jgl");
            InitializeAllLists("Zac", "top");
            InitializeAllLists("Zed", "mid");
            InitializeAllLists("Zed", "jgl");
            InitializeAllLists("Zeri", "top");
            InitializeAllLists("Zeri", "mid");
            InitializeAllLists("Zeri", "adc");
            InitializeAllLists("Ziggs", "mid");
            InitializeAllLists("Ziggs", "adc");
            InitializeAllLists("Zilean", "mid");
            InitializeAllLists("Zilean", "support");
            InitializeAllLists("Zoe", "mid");
            InitializeAllLists("Zyra", "support");
        }

        //private void InitializeAllLists(String name, String lane)
        //{
        //    var championName = "";
        //    Image championImage = null;
        //    var currentImagePath = AppDomain.CurrentDomain.BaseDirectory + @"gfx\Champions\";
        //    if(File.Exists($"{currentImagePath}{name}.gif"))
        //    {
        //        championImage = Image.FromFile(currentImagePath + name + ".gif");
        //        championName = Path.GetFileNameWithoutExtension($"{currentImagePath}{name}.gif");
        //        AddChampionToList(new Champion(championName, championImage), lane);
        //    } else
        //    {
        //        Console.WriteLine(name + " ist der Verräter");
        //    }
            
        //}

        private void AddChampionToList(Champion champion, String lane)
        {
            if (!Champions.Contains(champion))
            {
                Champions.Add(champion);
            }
            
            switch (lane)
            {
                case "top":
                    TopChampions.Add(champion);
                    break;
                case "jgl":
                    JungleChampions.Add(champion);
                    break;
                case "mid":
                    MidChampions.Add(champion);
                    break;
                case "adc":
                    AdcChampions.Add(champion);
                    break;
                case "support":
                    SupportChampions.Add(champion);
                    break;
            }
        }

        public Champion GetRandomChamp(String lane)
        {
            Random random = new Random();
            Champion champion = null;
            switch (lane)
            {
                case "all":
                    var rnd = random.Next(0, this.Champions.Count);
                    Champions[rnd].ChampionImage = GetImageFromUrl(this.Champions[rnd].ChampionName.ToUpper());
                    champion = this.Champions[rnd];
                    break;
                case "top":
                    var rnd1 = random.Next(0, this.TopChampions.Count);
                    TopChampions[rnd1].ChampionImage = GetImageFromUrl(this.TopChampions[rnd1].ChampionName.ToUpper());
                    champion = this.TopChampions[rnd1];
                    break;
                case "jgl":
                    var rnd2 = random.Next(0, this.JungleChampions.Count);
                    JungleChampions[rnd2].ChampionImage = GetImageFromUrl(this.JungleChampions[rnd2].ChampionName.ToUpper());
                    champion = this.JungleChampions[rnd2];
                    break;
                case "mid":
                    var rnd3 = random.Next(0, this.MidChampions.Count);
                    MidChampions[rnd3].ChampionImage = GetImageFromUrl(this.MidChampions[rnd3].ChampionName.ToUpper());
                    champion = this.MidChampions[rnd3];
                    break;
                case "adc":
                    var rnd4 = random.Next(0, this.AdcChampions.Count);
                    AdcChampions[rnd4].ChampionImage = GetImageFromUrl(this.AdcChampions[rnd4].ChampionName.ToUpper());
                    champion = this.AdcChampions[rnd4];
                    break;
                case "supp":
                    var rnd5 = random.Next(0, this.SupportChampions.Count);
                    SupportChampions[rnd5].ChampionImage = GetImageFromUrl(this.SupportChampions[rnd5].ChampionName.ToUpper());
                    champion = this.SupportChampions[rnd5];
                    break;
            }
            return champion;
        }

        private void InitializeAllLists(String name, String lane)
        {
            var championName = "";
            Image championImage = null;
            championImage = null;
            championName = name;
            AddChampionToList(new Champion(championName, championImage), lane);

        }

        private Image GetImageFromUrl(String name)
        {
            //Read file
            String[] lines = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"Champions.txt");
            String url;
            Image image = null;
            foreach (String line in lines)
            {
                if(line.StartsWith(name.ToUpper()))
                {
                    url = line.Substring(name.ToUpper().Length + 1);
                    HttpWebRequest httpWebRequest;
                    try
                    {
                        httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                    }
                    catch (UriFormatException ex)
                    {
                        Console.WriteLine(url);
                        Console.WriteLine(ex);
                        throw;
                    }
                    
                    HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    Stream stream = httpWebReponse.GetResponseStream();
                    image = Image.FromStream(stream);
                    httpWebRequest.Abort();
                    httpWebReponse.Close();
                    stream.Close();
                }
            }

            return image;
        }
    }
}
