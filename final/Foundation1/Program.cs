using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video = new Video("NO WAY!! DRIVING A CAR OFF A CLIFF! (SO MUCH DESTRUCTION)", "bigreddoggo", 875);
        video.StoreComment("Jacksucksatlife", "Staged.");
        video.StoreComment("gramsayofficialtotally", "Of course its staged, you donut!");
        video.StoreComment("bigreddoggosbro", "No way, hi gordon love your food!");
        videos.Add(video);

        video = new Video("Which Automation Mod Can Fly The Furthest On Car Jump Arena? PART 50 - BeamNG Drive Mods", "Neilogical", 900);
        video.StoreComment("@demomanchaos", "A 2nd pool swimmer, one of less than 5 to go swimming there, then a podium finish. What an episode.");
        video.StoreComment("@Thribbulous", "That podium shot was superb!");
        video.StoreComment("@mikekuschka998", "Holy crap. Second pool and the podium. Excelent 50th episode.");
        videos.Add(video);

        video = new Video("Master Oogway's Career Is OVER...", "Kotemon", 487);
        video.StoreComment("@Dion.0.7.2", "bro i fr thought u were a channel w 328k subs, UR WAY TOO UNDERATED WHAT?!?!?!");
        video.StoreComment("@Entroprox", "Edgy content is funny in my opinion. And racism doesn't matter to me personally.");
        video.StoreComment("@BraxtonEaves", "Bro these videos are on par with the big commentary YouTubers seriously keep up the good work.");
        videos.Add(video);

        foreach (Video video1 in videos)
        {
            video1.Report();
        }




    }
}