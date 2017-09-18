using _99BottlesDemo;
using NUnit.Framework;
using System.Text;

namespace _99BottlesTest
{
    [TestFixture]
    public class SongTests
    {
        private Song song;
        [SetUp]
        public void Setup()
        {
            song = new Song();
            song.InitSong();
        }
        [Test]
        public void Song_Is_Not_Null()
        {
            Assert.IsNotNull(song);
        }
        [Test]
        public void Song_has_100_verses()
        {
            Assert.AreEqual(100, song.Verses.Count);
        }
        [Test]
        public void Test_Verse_99()
        {            
            var expectedVerse = "99 bottles of beer on the wall, 99 bottles of beer. \n" +
                        "Take one down and pass it around, 98 bottles of beer on the wall.";
            Assert.AreEqual(expectedVerse, song.PrintVerse(99));
        }
        [Test]
        public void Test_Verse_98()
        {
            var expectedVerse = "98 bottles of beer on the wall, 98 bottles of beer. \n" +
                        "Take one down and pass it around, 97 bottles of beer on the wall.";
            Assert.AreEqual(expectedVerse, song.PrintVerse(98));
        }
        [Test]
        public void Test_Verse_89()
        {
            var expectedVerse = "89 bottles of beer on the wall, 89 bottles of beer. \n" +
                        "Take one down and pass it around, 88 bottles of beer on the wall.";
            Assert.AreEqual(expectedVerse, song.PrintVerse(89));
        }
        [TestCase(98)]
        [TestCase(89)]
        [TestCase(12)]
        [TestCase(3)]
        public void Test_Verse_Many_Single(int verse)
        {
            var expectedVerse = $"{verse} bottles of beer on the wall, {verse} bottles of beer. \n" +
                        $"Take one down and pass it around, {verse-1} bottles of beer on the wall.";
            Assert.AreEqual(expectedVerse, song.PrintVerse(verse));
        }
        
        [Test]
        public void Test_Verse_2()
        {
            var expectedVerse = "2 bottles of beer on the wall, 2 bottles of beer. \n" +
                        "Take one down and pass it around, 1 bottle of beer on the wall.";
            Assert.AreEqual(expectedVerse, song.PrintVerse(2));
        }
        [Test]
        public void Test_Verse_1()
        {
            var expectedVerse = "One bottle of beer on the wall, one bottle of beer. \n" +
                        "Take it down and pass it around, no more bottles of beer on the wall.";
            Assert.AreEqual(expectedVerse, song.PrintVerse(1));
        }
        [Test]
        public void Test_Verse_0()
        {
            var expectedVerse = "No more bottles of beer on the wall, no more bottles of beer. \n" +
                        "Go to the store and buy some more, 99 bottles of beer on the wall.";
            Assert.AreEqual(expectedVerse, song.PrintVerse(0));
        }
        [Test]
        public void Test_Verse_99_and_98()
        {
            var sb = new StringBuilder();
            sb.AppendLine("99 bottles of beer on the wall, 99 bottles of beer. \n" +
                "Take one down and pass it around, 98 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("98 bottles of beer on the wall, 98 bottles of beer. \n" +
                "Take one down and pass it around, 97 bottles of beer on the wall.");
            sb.AppendLine();
            var expectedVerse = sb.ToString();
            Assert.AreEqual(expectedVerse, song.PrintVerses(99,98));
        }
        [Test]
        public void Test_Verse_2_through_0()
        {
            var sb = new StringBuilder();
            sb.AppendLine("2 bottles of beer on the wall, 2 bottles of beer. \n" +
                        "Take one down and pass it around, 1 bottle of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("One bottle of beer on the wall, one bottle of beer. \n" +
                        "Take it down and pass it around, no more bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("No more bottles of beer on the wall, no more bottles of beer. \n" +
                        "Go to the store and buy some more, 99 bottles of beer on the wall.");
            sb.AppendLine();
            var expectedVerse = sb.ToString();
            Assert.AreEqual(expectedVerse, song.PrintVerses(2, 0));
        }
        [Test]
        public void Test_Full_Song()
        {
            var sb = new StringBuilder();
            sb.AppendLine("99 bottles of beer on the wall, 99 bottles of beer. \n" +
                "Take one down and pass it around, 98 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("98 bottles of beer on the wall, 98 bottles of beer. \n" +
                "Take one down and pass it around, 97 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("97 bottles of beer on the wall, 97 bottles of beer. \n" +
                "Take one down and pass it around, 96 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("96 bottles of beer on the wall, 96 bottles of beer. \n" +
                "Take one down and pass it around, 95 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("95 bottles of beer on the wall, 95 bottles of beer. \n" +
                "Take one down and pass it around, 94 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("94 bottles of beer on the wall, 94 bottles of beer. \n" +
                "Take one down and pass it around, 93 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("93 bottles of beer on the wall, 93 bottles of beer. \n" +
                "Take one down and pass it around, 92 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("92 bottles of beer on the wall, 92 bottles of beer. \n" +
                "Take one down and pass it around, 91 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("91 bottles of beer on the wall, 91 bottles of beer. \n" +
                "Take one down and pass it around, 90 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("90 bottles of beer on the wall, 90 bottles of beer. \n" +
                "Take one down and pass it around, 89 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("89 bottles of beer on the wall, 89 bottles of beer. \n" +
                "Take one down and pass it around, 88 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("88 bottles of beer on the wall, 88 bottles of beer. \n" +
                "Take one down and pass it around, 87 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("87 bottles of beer on the wall, 87 bottles of beer. \n" +
                "Take one down and pass it around, 86 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("86 bottles of beer on the wall, 86 bottles of beer. \n" +
                "Take one down and pass it around, 85 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("85 bottles of beer on the wall, 85 bottles of beer. \n" +
                "Take one down and pass it around, 84 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("84 bottles of beer on the wall, 84 bottles of beer. \n" +
                "Take one down and pass it around, 83 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("83 bottles of beer on the wall, 83 bottles of beer. \n" +
                "Take one down and pass it around, 82 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("82 bottles of beer on the wall, 82 bottles of beer. \n" +
                "Take one down and pass it around, 81 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("81 bottles of beer on the wall, 81 bottles of beer. \n" +
                "Take one down and pass it around, 80 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("80 bottles of beer on the wall, 80 bottles of beer. \n" +
                "Take one down and pass it around, 79 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("79 bottles of beer on the wall, 79 bottles of beer. \n" +
                "Take one down and pass it around, 78 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("78 bottles of beer on the wall, 78 bottles of beer. \n" +
                "Take one down and pass it around, 77 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("77 bottles of beer on the wall, 77 bottles of beer. \n" +
                "Take one down and pass it around, 76 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("76 bottles of beer on the wall, 76 bottles of beer. \n" +
                "Take one down and pass it around, 75 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("75 bottles of beer on the wall, 75 bottles of beer. \n" +
                "Take one down and pass it around, 74 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("74 bottles of beer on the wall, 74 bottles of beer. \n" +
                "Take one down and pass it around, 73 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("73 bottles of beer on the wall, 73 bottles of beer. \n" +
                "Take one down and pass it around, 72 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("72 bottles of beer on the wall, 72 bottles of beer. \n" +
                "Take one down and pass it around, 71 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("71 bottles of beer on the wall, 71 bottles of beer. \n" +
                "Take one down and pass it around, 70 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("70 bottles of beer on the wall, 70 bottles of beer. \n" +
                "Take one down and pass it around, 69 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("69 bottles of beer on the wall, 69 bottles of beer. \n" +
                "Take one down and pass it around, 68 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("68 bottles of beer on the wall, 68 bottles of beer. \n" +
                "Take one down and pass it around, 67 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("67 bottles of beer on the wall, 67 bottles of beer. \n" +
                "Take one down and pass it around, 66 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("66 bottles of beer on the wall, 66 bottles of beer. \n" +
                "Take one down and pass it around, 65 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("65 bottles of beer on the wall, 65 bottles of beer. \n" +
                "Take one down and pass it around, 64 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("64 bottles of beer on the wall, 64 bottles of beer. \n" +
                "Take one down and pass it around, 63 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("63 bottles of beer on the wall, 63 bottles of beer. \n" +
                "Take one down and pass it around, 62 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("62 bottles of beer on the wall, 62 bottles of beer. \n" +
                "Take one down and pass it around, 61 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("61 bottles of beer on the wall, 61 bottles of beer. \n" +
                "Take one down and pass it around, 60 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("60 bottles of beer on the wall, 60 bottles of beer. \n" +
                "Take one down and pass it around, 59 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("59 bottles of beer on the wall, 59 bottles of beer. \n" +
                "Take one down and pass it around, 58 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("58 bottles of beer on the wall, 58 bottles of beer. \n" +
                "Take one down and pass it around, 57 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("57 bottles of beer on the wall, 57 bottles of beer. \n" +
                "Take one down and pass it around, 56 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("56 bottles of beer on the wall, 56 bottles of beer. \n" +
                "Take one down and pass it around, 55 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("55 bottles of beer on the wall, 55 bottles of beer. \n" +
                "Take one down and pass it around, 54 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("54 bottles of beer on the wall, 54 bottles of beer. \n" +
                "Take one down and pass it around, 53 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("53 bottles of beer on the wall, 53 bottles of beer. \n" +
                "Take one down and pass it around, 52 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("52 bottles of beer on the wall, 52 bottles of beer. \n" +
                "Take one down and pass it around, 51 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("51 bottles of beer on the wall, 51 bottles of beer. \n" +
                "Take one down and pass it around, 50 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("50 bottles of beer on the wall, 50 bottles of beer. \n" +
                "Take one down and pass it around, 49 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("49 bottles of beer on the wall, 49 bottles of beer. \n" +
                "Take one down and pass it around, 48 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("48 bottles of beer on the wall, 48 bottles of beer. \n" +
                "Take one down and pass it around, 47 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("47 bottles of beer on the wall, 47 bottles of beer. \n" +
                "Take one down and pass it around, 46 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("46 bottles of beer on the wall, 46 bottles of beer. \n" +
                "Take one down and pass it around, 45 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("45 bottles of beer on the wall, 45 bottles of beer. \n" +
                "Take one down and pass it around, 44 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("44 bottles of beer on the wall, 44 bottles of beer. \n" +
                "Take one down and pass it around, 43 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("43 bottles of beer on the wall, 43 bottles of beer. \n" +
                "Take one down and pass it around, 42 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("42 bottles of beer on the wall, 42 bottles of beer. \n" +
                "Take one down and pass it around, 41 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("41 bottles of beer on the wall, 41 bottles of beer. \n" +
                "Take one down and pass it around, 40 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("40 bottles of beer on the wall, 40 bottles of beer. \n" +
                "Take one down and pass it around, 39 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("39 bottles of beer on the wall, 39 bottles of beer. \n" +
                "Take one down and pass it around, 38 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("38 bottles of beer on the wall, 38 bottles of beer. \n" +
                "Take one down and pass it around, 37 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("37 bottles of beer on the wall, 37 bottles of beer. \n" +
                "Take one down and pass it around, 36 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("36 bottles of beer on the wall, 36 bottles of beer. \n" +
                "Take one down and pass it around, 35 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("35 bottles of beer on the wall, 35 bottles of beer. \n" +
                "Take one down and pass it around, 34 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("34 bottles of beer on the wall, 34 bottles of beer. \n" +
                "Take one down and pass it around, 33 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("33 bottles of beer on the wall, 33 bottles of beer. \n" +
                "Take one down and pass it around, 32 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("32 bottles of beer on the wall, 32 bottles of beer. \n" +
                "Take one down and pass it around, 31 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("31 bottles of beer on the wall, 31 bottles of beer. \n" +
                "Take one down and pass it around, 30 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("30 bottles of beer on the wall, 30 bottles of beer. \n" +
                "Take one down and pass it around, 29 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("29 bottles of beer on the wall, 29 bottles of beer. \n" +
                "Take one down and pass it around, 28 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("28 bottles of beer on the wall, 28 bottles of beer. \n" +
                "Take one down and pass it around, 27 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("27 bottles of beer on the wall, 27 bottles of beer. \n" +
                "Take one down and pass it around, 26 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("26 bottles of beer on the wall, 26 bottles of beer. \n" +
                "Take one down and pass it around, 25 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("25 bottles of beer on the wall, 25 bottles of beer. \n" +
                "Take one down and pass it around, 24 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("24 bottles of beer on the wall, 24 bottles of beer. \n" +
                "Take one down and pass it around, 23 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("23 bottles of beer on the wall, 23 bottles of beer. \n" +
                "Take one down and pass it around, 22 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("22 bottles of beer on the wall, 22 bottles of beer. \n" +
                "Take one down and pass it around, 21 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("21 bottles of beer on the wall, 21 bottles of beer. \n" +
                "Take one down and pass it around, 20 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("20 bottles of beer on the wall, 20 bottles of beer. \n" +
                "Take one down and pass it around, 19 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("19 bottles of beer on the wall, 19 bottles of beer. \n" +
                "Take one down and pass it around, 18 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("18 bottles of beer on the wall, 18 bottles of beer. \n" +
                "Take one down and pass it around, 17 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("17 bottles of beer on the wall, 17 bottles of beer. \n" +
                "Take one down and pass it around, 16 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("16 bottles of beer on the wall, 16 bottles of beer. \n" +
                "Take one down and pass it around, 15 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("15 bottles of beer on the wall, 15 bottles of beer. \n" +
                "Take one down and pass it around, 14 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("14 bottles of beer on the wall, 14 bottles of beer. \n" +
                "Take one down and pass it around, 13 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("13 bottles of beer on the wall, 13 bottles of beer. \n" +
                "Take one down and pass it around, 12 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("12 bottles of beer on the wall, 12 bottles of beer. \n" +
                "Take one down and pass it around, 11 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("11 bottles of beer on the wall, 11 bottles of beer. \n" +
                "Take one down and pass it around, 10 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("10 bottles of beer on the wall, 10 bottles of beer. \n" +
                "Take one down and pass it around, 9 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("9 bottles of beer on the wall, 9 bottles of beer. \n" +
                "Take one down and pass it around, 8 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("8 bottles of beer on the wall, 8 bottles of beer. \n" +
                "Take one down and pass it around, 7 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("7 bottles of beer on the wall, 7 bottles of beer. \n" +
                "Take one down and pass it around, 6 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("6 bottles of beer on the wall, 6 bottles of beer. \n" +
                "Take one down and pass it around, 5 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("5 bottles of beer on the wall, 5 bottles of beer. \n" +
                "Take one down and pass it around, 4 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("4 bottles of beer on the wall, 4 bottles of beer. \n" +
                "Take one down and pass it around, 3 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("3 bottles of beer on the wall, 3 bottles of beer. \n" +
                "Take one down and pass it around, 2 bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("2 bottles of beer on the wall, 2 bottles of beer. \n" +
                        "Take one down and pass it around, 1 bottle of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("One bottle of beer on the wall, one bottle of beer. \n" +
                        "Take it down and pass it around, no more bottles of beer on the wall.");
            sb.AppendLine();
            sb.AppendLine("No more bottles of beer on the wall, no more bottles of beer. \n" +
                        "Go to the store and buy some more, 99 bottles of beer on the wall.");
            sb.AppendLine();
            var expectedVerse = sb.ToString();
            Assert.AreEqual(expectedVerse, song.PrintSong());
        }
    }
}
