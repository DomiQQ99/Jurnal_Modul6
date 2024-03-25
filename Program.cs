using System.Diagnostics;
using System.Reflection;
using System.Text;
internal class Program
{
    class random
    {
        public int idRandom()
        {
            Random id = new Random();
            return id.Next(10000, 99999);
        }
    }
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeUser> UploadedVideos;
        private string Username;

        public SayaTubeUser(string username)
        {
            this.Username = username;
            random random = new random();
            id = random.idRandom();
            UploadedVideos = new List<SayaTubeUser>();
        }

        public int GetTotalVideoPlayCount()
        {
            int N = 0;
            for (int i = 0; i < UploadedVideos.Count; i++)
            {
                N += UploadedVideos[i].GetTotalVideoPlayCount();
            }
            return N;
        }

        public void AddVideo(SayaTubeVideo a)
        {
            Debug.Assert(a != null);
            Debug.Assert(a.GetPlayCount <= 1000000000);
            UploadedVideos.Add(a);
        }
        public void PrintAllVIdeoPlayCount()
        {
            Console.WriteLine($"User: {this.Username}");
            for (int i = 0; i < UploadedVideos.Count || i < 8; i++)
            {
                Console.WriteLine("Video " + (i + 1) + "Judul" + UploadedVideos[i].Gettitle
            }
        }

    }
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playcount;

        public SayaTubeVideo(string title)
        {
            random random = new random();
            this.title = title;
            id = random.idRandom();
            playcount = 0;
        }

        public void IncreasePlayCount(int playcount)
        {
            this.playcount += playcount;
        }
        public string GetTitle()
        {
            return title;
        }
        public int GetPlayCount()
        {
            return playcount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {this.id}");
            Console.WriteLine($"Judul: {this.title}");
            Console.WriteLine($"PlayCount: {this.playcount}");
        }
    }
}
