using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;

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
            InitializeAllLists("Aatrox", Lane.Top);
            InitializeAllLists("Ahri", Lane.Mid);
            InitializeAllLists("Akali", Lane.Mid);
            InitializeAllLists("Akali", Lane.Top);
            InitializeAllLists("Akshan", Lane.Mid);
            InitializeAllLists("Akshan", Lane.Adc);
            InitializeAllLists("Alistar", Lane.Support);
            InitializeAllLists("Amumu", Lane.Jungle);
            InitializeAllLists("Anivia", Lane.Mid);
            InitializeAllLists("Annie", Lane.Mid);
            InitializeAllLists("Annie", Lane.Support);
            InitializeAllLists("Aphelios", Lane.Adc);
            InitializeAllLists("Ashe", Lane.Adc);
            InitializeAllLists("Aurelion Sol", Lane.Mid);
            InitializeAllLists("Azir", Lane.Mid);
            InitializeAllLists("Bard", Lane.Support);
            InitializeAllLists("Blitzcrank", Lane.Support);
            InitializeAllLists("Brand", Lane.Support);
            InitializeAllLists("Brand", Lane.Mid);
            InitializeAllLists("Braum", Lane.Support);
            InitializeAllLists("Caitlyn", Lane.Adc);
            InitializeAllLists("Camille", Lane.Top);
            InitializeAllLists("Cassiopeia", Lane.Top);
            InitializeAllLists("Cassiopeia", Lane.Mid);
            InitializeAllLists("Cassiopeia", Lane.Adc);
            InitializeAllLists("Cho'Gath", Lane.Top);
            InitializeAllLists("Cho'Gath", Lane.Mid);
            InitializeAllLists("Corki", Lane.Mid);
            InitializeAllLists("Darius", Lane.Top);
            InitializeAllLists("Diana", Lane.Mid);
            InitializeAllLists("Diana", Lane.Jungle);
            InitializeAllLists("Dr.Mundo", Lane.Top);
            InitializeAllLists("Dr.Mundo", Lane.Jungle);
            InitializeAllLists("Draven", Lane.Adc);
            InitializeAllLists("Ekko", Lane.Mid);
            InitializeAllLists("Ekko", Lane.Jungle);
            InitializeAllLists("Elise", Lane.Jungle);
            InitializeAllLists("Evelynn", Lane.Jungle);
            InitializeAllLists("Ezreal", Lane.Adc);
            InitializeAllLists("Fiddlesticks", Lane.Jungle);
            InitializeAllLists("Fiora", Lane.Top);
            InitializeAllLists("Fizz", Lane.Mid);
            InitializeAllLists("Galio", Lane.Mid);
            InitializeAllLists("Galio", Lane.Support);
            InitializeAllLists("Gangplank", Lane.Top);
            InitializeAllLists("Garen", Lane.Top);
            InitializeAllLists("Garen", Lane.Mid);
            InitializeAllLists("Gnar", Lane.Top);
            InitializeAllLists("Gragas", Lane.Top);
            InitializeAllLists("Gragas", Lane.Jungle);
            InitializeAllLists("Gragas", Lane.Mid);
            InitializeAllLists("Graves", Lane.Mid);
            InitializeAllLists("Graves", Lane.Top);
            InitializeAllLists("Graves", Lane.Jungle);
            InitializeAllLists("Gwen", Lane.Jungle);
            InitializeAllLists("Gwen", Lane.Top);
            InitializeAllLists("Hecarim", Lane.Jungle);
            InitializeAllLists("Heimerdinger", Lane.Top);
            InitializeAllLists("Heimerdinger", Lane.Mid);
            InitializeAllLists("Illaoi", Lane.Top);
            InitializeAllLists("Irelia", Lane.Top);
            InitializeAllLists("Irelia", Lane.Mid);
            InitializeAllLists("Ivern", Lane.Support);
            InitializeAllLists("Ivern", Lane.Jungle);
            InitializeAllLists("Janna", Lane.Support);
            InitializeAllLists("Jarvan IV", Lane.Jungle);
            InitializeAllLists("Jax", Lane.Jungle);
            InitializeAllLists("Jax", Lane.Top);
            InitializeAllLists("Jayce", Lane.Top);
            InitializeAllLists("Jayce", Lane.Mid);
            InitializeAllLists("Jhin", Lane.Adc);
            InitializeAllLists("Jinx", Lane.Adc);
            InitializeAllLists("Kai'Sa", Lane.Adc);
            InitializeAllLists("Kai'Sa", Lane.Mid);
            InitializeAllLists("Kalista", Lane.Adc);
            InitializeAllLists("Karma", Lane.Support);
            InitializeAllLists("Karthus", Lane.Jungle);
            InitializeAllLists("Kassadin", Lane.Mid);
            InitializeAllLists("Katarina", Lane.Top);
            InitializeAllLists("Katarina", Lane.Mid);
            InitializeAllLists("Kayle", Lane.Mid);
            InitializeAllLists("Kayle", Lane.Top);
            InitializeAllLists("Kayn", Lane.Jungle);
            InitializeAllLists("Kennen", Lane.Top);
            InitializeAllLists("Kha'Zix", Lane.Jungle);
            InitializeAllLists("Kindred", Lane.Jungle);
            InitializeAllLists("Kled", Lane.Top);
            InitializeAllLists("Kog'Maw", Lane.Adc);
            InitializeAllLists("LeBlanc", Lane.Mid);
            InitializeAllLists("Lee Sin", Lane.Jungle);
            InitializeAllLists("Leona", Lane.Support);
            InitializeAllLists("Lillia", Lane.Jungle);
            InitializeAllLists("Lissandra", Lane.Mid);
            InitializeAllLists("Lucian", Lane.Adc);
            InitializeAllLists("Lulu", Lane.Support);
            InitializeAllLists("Lux", Lane.Support);
            InitializeAllLists("Lux", Lane.Mid);
            InitializeAllLists("Malphite", Lane.Mid);
            InitializeAllLists("Malphite", Lane.Top);
            InitializeAllLists("Malzahar", Lane.Mid);
            InitializeAllLists("Maokai", Lane.Support);
            InitializeAllLists("Master Yi", Lane.Jungle);
            InitializeAllLists("Miss Fortune", Lane.Adc);
            InitializeAllLists("Mordekaiser", Lane.Top);
            InitializeAllLists("Mordekaiser", Lane.Jungle);
            InitializeAllLists("Morgana", Lane.Support);
            InitializeAllLists("Nami", Lane.Support);
            InitializeAllLists("Nasus", Lane.Top);
            InitializeAllLists("Nasus", Lane.Jungle);
            InitializeAllLists("Nautilus", Lane.Support);
            InitializeAllLists("Neeko", Lane.Support);
            InitializeAllLists("Neeko", Lane.Mid);
            InitializeAllLists("Nidalee", Lane.Jungle);
            InitializeAllLists("Nocturne", Lane.Jungle);
            InitializeAllLists("Nunu & Willump", Lane.Jungle);
            InitializeAllLists("Olaf", Lane.Jungle);
            InitializeAllLists("Orianna", Lane.Mid);
            InitializeAllLists("Ornn", Lane.Top);
            InitializeAllLists("Pantheon", Lane.Top);
            InitializeAllLists("Pantheon", Lane.Mid);
            InitializeAllLists("Pantheon", Lane.Support);
            InitializeAllLists("Pantheon", Lane.Jungle);
            InitializeAllLists("Poppy", Lane.Jungle);
            InitializeAllLists("Poppy", Lane.Top);
            InitializeAllLists("Poppy", Lane.Support);
            InitializeAllLists("Pyke", Lane.Support);
            InitializeAllLists("Qiyana", Lane.Mid);
            InitializeAllLists("Qiyana", Lane.Jungle);
            InitializeAllLists("Quinn", Lane.Top);
            InitializeAllLists("Rakan", Lane.Support);
            InitializeAllLists("Rammus", Lane.Jungle);
            InitializeAllLists("Rek'Sai", Lane.Jungle);
            InitializeAllLists("Rell", Lane.Support);
            InitializeAllLists("Renata Glasc", Lane.Support);
            InitializeAllLists("Renekton", Lane.Top);
            InitializeAllLists("Renekton", Lane.Mid);
            InitializeAllLists("Rengar", Lane.Jungle);
            InitializeAllLists("Rengar", Lane.Top);
            InitializeAllLists("Riven", Lane.Top);
            InitializeAllLists("Rumble", Lane.Mid);
            InitializeAllLists("Ryze", Lane.Mid);
            InitializeAllLists("Ryze", Lane.Top);
            InitializeAllLists("Samira", Lane.Adc);
            InitializeAllLists("Sejuani", Lane.Jungle);
            InitializeAllLists("Senna", Lane.Support);
            InitializeAllLists("Seraphine", Lane.Support);
            InitializeAllLists("Sett", Lane.Support);
            InitializeAllLists("Sett", Lane.Top);
            InitializeAllLists("Shaco", Lane.Jungle);
            InitializeAllLists("Shaco", Lane.Support);
            InitializeAllLists("Shen", Lane.Top);
            InitializeAllLists("Shyvana", Lane.Jungle);
            InitializeAllLists("Singed", Lane.Top);
            InitializeAllLists("Singed", Lane.Mid);
            InitializeAllLists("Sion", Lane.Top);
            InitializeAllLists("Sion", Lane.Jungle);
            InitializeAllLists("Sivir", Lane.Adc);
            InitializeAllLists("Skarner", Lane.Jungle);
            InitializeAllLists("Sona", Lane.Support);
            InitializeAllLists("Soraka", Lane.Support);
            InitializeAllLists("Swain", Lane.Support);
            InitializeAllLists("Sylas", Lane.Mid);
            InitializeAllLists("Sylas", Lane.Top);
            InitializeAllLists("Syndra", Lane.Mid);
            InitializeAllLists("Tahm Kench", Lane.Top);
            InitializeAllLists("Taliyah", Lane.Jungle);
            InitializeAllLists("Talon", Lane.Jungle);
            InitializeAllLists("Talon", Lane.Mid);
            InitializeAllLists("Taric", Lane.Jungle);
            InitializeAllLists("Taric", Lane.Support);
            InitializeAllLists("Teemo", Lane.Top);
            InitializeAllLists("Thresh", Lane.Support);
            InitializeAllLists("Tristana", Lane.Adc);
            InitializeAllLists("Trundle", Lane.Jungle);
            InitializeAllLists("Trundle", Lane.Top);
            InitializeAllLists("Tryndamere", Lane.Top);
            InitializeAllLists("Twisted Fate", Lane.Mid);
            InitializeAllLists("Twitch", Lane.Adc);
            InitializeAllLists("Udyr", Lane.Jungle);
            InitializeAllLists("Urgot", Lane.Top);
            InitializeAllLists("Varus", Lane.Adc);
            InitializeAllLists("Vayne", Lane.Adc);
            InitializeAllLists("Vayne", Lane.Top);
            InitializeAllLists("Veigar", Lane.Mid);
            InitializeAllLists("Veigar", Lane.Support);
            InitializeAllLists("Veigar", Lane.Adc);
            InitializeAllLists("Vel'Koz", Lane.Support);
            InitializeAllLists("Vel'Koz", Lane.Mid);
            InitializeAllLists("Vex", Lane.Mid);
            InitializeAllLists("Vex", Lane.Support);
            InitializeAllLists("Vi", Lane.Jungle);
            InitializeAllLists("Viego", Lane.Jungle);
            InitializeAllLists("Viktor", Lane.Mid);
            InitializeAllLists("Vladimir", Lane.Top);
            InitializeAllLists("Vladimir", Lane.Mid);
            InitializeAllLists("Volibear", Lane.Top);
            InitializeAllLists("Volibear", Lane.Jungle);
            InitializeAllLists("Warwick", Lane.Jungle);
            InitializeAllLists("Warwick", Lane.Top);
            InitializeAllLists("Wukong", Lane.Top);
            InitializeAllLists("Xayah", Lane.Adc);
            InitializeAllLists("Xerath", Lane.Support);
            InitializeAllLists("Xerath", Lane.Mid);
            InitializeAllLists("Xin Zhao", Lane.Jungle);
            InitializeAllLists("Yasuo", Lane.Top);
            InitializeAllLists("Yasuo", Lane.Mid);
            InitializeAllLists("Yasuo", Lane.Adc);
            InitializeAllLists("Yone", Lane.Top);
            InitializeAllLists("Yone", Lane.Mid);
            InitializeAllLists("Yorick", Lane.Top);
            InitializeAllLists("Yuumi", Lane.Support);
            InitializeAllLists("Zac", Lane.Jungle);
            InitializeAllLists("Zac", Lane.Top);
            InitializeAllLists("Zed", Lane.Mid);
            InitializeAllLists("Zed", Lane.Jungle);
            InitializeAllLists("Zeri", Lane.Top);
            InitializeAllLists("Zeri", Lane.Mid);
            InitializeAllLists("Zeri", Lane.Adc);
            InitializeAllLists("Ziggs", Lane.Mid);
            InitializeAllLists("Ziggs", Lane.Adc);
            InitializeAllLists("Zilean", Lane.Mid);
            InitializeAllLists("Zilean", Lane.Support);
            InitializeAllLists("Zoe", Lane.Mid);
            InitializeAllLists("Zyra", Lane.Support);
        }

        private void AddChampionToList(Champion champion, Lane lane)
        {
            if (!Champions.Contains(champion))
            {
                Champions.Add(champion);
            }
            
            switch (lane)
            {
                case Lane.Top:
                    TopChampions.Add(champion);
                    break;
                case Lane.Jungle:
                    JungleChampions.Add(champion);
                    break;
                case Lane.Mid:
                    MidChampions.Add(champion);
                    break;
                case Lane.Adc:
                    AdcChampions.Add(champion);
                    break;
                case Lane.Support:
                    SupportChampions.Add(champion);
                    break;
            }
        }

        public Champion GetRandomChamp(Lane lane)
        {
            Random random = new Random();
            Champion champion = null;
            switch (lane)
            {
                case Lane.AllLanes:
                    var rnd = random.Next(0, this.Champions.Count);
                    Champions[rnd].ChampionImage = GetImageFromUrl(this.Champions[rnd].ChampionName.ToUpper());
                    champion = this.Champions[rnd];
                    break;
                case Lane.Top:
                    var rnd1 = random.Next(0, this.TopChampions.Count);
                    TopChampions[rnd1].ChampionImage = GetImageFromUrl(this.TopChampions[rnd1].ChampionName.ToUpper());
                    champion = this.TopChampions[rnd1];
                    break;
                case Lane.Jungle:
                    var rnd2 = random.Next(0, this.JungleChampions.Count);
                    JungleChampions[rnd2].ChampionImage = GetImageFromUrl(this.JungleChampions[rnd2].ChampionName.ToUpper());
                    champion = this.JungleChampions[rnd2];
                    break;
                case Lane.Mid:
                    var rnd3 = random.Next(0, this.MidChampions.Count);
                    MidChampions[rnd3].ChampionImage = GetImageFromUrl(this.MidChampions[rnd3].ChampionName.ToUpper());
                    champion = this.MidChampions[rnd3];
                    break;
                case Lane.Adc:
                    var rnd4 = random.Next(0, this.AdcChampions.Count);
                    AdcChampions[rnd4].ChampionImage = GetImageFromUrl(this.AdcChampions[rnd4].ChampionName.ToUpper());
                    champion = this.AdcChampions[rnd4];
                    break;
                case Lane.Support:
                    var rnd5 = random.Next(0, this.SupportChampions.Count);
                    SupportChampions[rnd5].ChampionImage = GetImageFromUrl(this.SupportChampions[rnd5].ChampionName.ToUpper());
                    champion = this.SupportChampions[rnd5];
                    break;
            }
            return champion;
        }

        private void InitializeAllLists(String name, Lane lane)
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
                    HttpWebRequest httpWebRequest = null;
                    try
                    {
                        httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                    }
                    catch (UriFormatException ex)
                    {
                        Console.WriteLine(url);
                        Console.WriteLine(name);
                        Console.WriteLine(ex);
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
