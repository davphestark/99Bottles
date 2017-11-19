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
            var bottleNumber = new BottleFactory().GetBottleNumberFor(VerseNumber);

            return Capitalize($"{bottleNumber} of beer on the wall, {bottleNumber} of beer. \n") +
                $"{bottleNumber.Action}, {bottleNumber.Next} of beer on the wall.";
        }
        
        private string Capitalize(string value)
        {
            return value.Substring(0, 1).ToUpper() + value.Substring(1);
        }
    }
}
