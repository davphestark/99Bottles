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
            Lyric = SetLyricFromNumber(new BottleNumber(number));
        }
        private string SetLyricFromNumber(BottleNumber bottleNumber)
        {
            return $"{Capitalize(bottleNumber.Quanity)} {bottleNumber.Container} of beer on the wall, " +
                $"{bottleNumber.Quanity} {bottleNumber.Container} of beer. \n" +
                $"{bottleNumber.Action}, " +
                $"{bottleNumber.QuanityNext} {bottleNumber.ContainerNext} of beer on the wall.";
        }
        
        private string Capitalize(string value)
        {
            return value.Substring(0, 1).ToUpper() + value.Substring(1);
        }
    }
}
