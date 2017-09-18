using System.Collections.Generic;
using System.Text;

namespace _99BottlesDemo
{
    public class Song
    {
        public List<Verse> Verses { get; set; }
        public Song()
        {
            Verses = new List<Verse>();
        }
        public void InitSong(int numVerses = 99)
        {
            for (var i = numVerses; i > -1; i--)
            {
                Verses.Add(new Verse(i));
            }
        }
        public string PrintSong()
        {
            var sb = new StringBuilder();
            foreach (var verse in Verses)
            {
                sb.AppendLine(verse.Lyric);
                sb.AppendLine();
            }
            return sb.ToString();
        }
        public string PrintVerses(int start,int end)
        {
            var sb = new StringBuilder();
            for (var i = start; i > end -1; i--)
            {
                sb.AppendLine(PrintVerse(i));
                sb.AppendLine();
            }
            return sb.ToString();
        }
        public string PrintVerse(int verseNumber)
        {
            return Verses.Find(v => v.VerseNumber == verseNumber).Lyric;
        }
    }
}
