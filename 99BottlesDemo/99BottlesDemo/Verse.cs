using System;

namespace _99BottlesDemo
{
    public class Verse
    {
        public int VerseNumber { get; set; }
        public string Lyric { get; set; }
        public Verse(int number)
        {
            VerseNumber = number;
            Lyric = SetLyricFromNumber();
        }
        private string SetLyricFromNumber()
        {
            return $"{Capitalize(Quanity(VerseNumber))} {Container(VerseNumber)} of beer on the wall, " +
                $"{Quanity(VerseNumber)} {Container(VerseNumber)} of beer. \n" +
                $"{Action(VerseNumber)}, " +
                $"{Quanity(Next(VerseNumber))} {Container(Next(VerseNumber))} of beer on the wall.";
        }

        private int Next(int num)
        {
            return num == 0 ? 99 : num - 1;
        }

        private string Quanity(int num)
        {
            return num == 0 ? "no more" : num.ToString();
        }

        private string Pronoun(int num)
        {
            return num == 0 ? "it" : "one";
        }

        private string Container(int num)
        {
            return num == 1 ? "bottle" : "bottles";
        }
        private string Capitalize(string value)
        {
            return value.Substring(0, 1).ToUpper() + value.Substring(1);
        }
        private string Action(int num)
        {
            return num == 0 ? "Go to the store and buy some more" : $"Take {Pronoun(num - 1)} down and pass it around";
        }
    }
}
