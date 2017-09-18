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
            string lyric;
            switch (VerseNumber)
            {
                case 2:
                    lyric = $"{VerseNumber} bottles of beer on the wall, {VerseNumber} bottles of beer. \n" +
                            $"Take one down and pass it around, {VerseNumber -1} bottle of beer on the wall.";
                    break;
                case 1:
                    lyric = $"{VerseNumber} bottle of beer on the wall, {VerseNumber} bottle of beer. \n" +
                            $"Take it down and pass it around, no more bottles of beer on the wall.";
                    break;
                case 0:
                    lyric = $"No more bottles of beer on the wall, no more bottles of beer. \n" +
                            $"Go to the store and buy some more, 99 bottles of beer on the wall.";
                    break;
                default:
                    lyric = $"{VerseNumber} bottles of beer on the wall, {VerseNumber} bottles of beer. \n" +
                            $"Take one down and pass it around, {VerseNumber -1} bottles of beer on the wall.";
                    break;
            }
            return lyric;       
        }
    }
}
