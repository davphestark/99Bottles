namespace _99BottlesDemo
{
    public class BottleNumber
    {
        private int number;

        public BottleNumber(int number)
        {
            this.number = number;
        }

        public int Next => number == 0 ? 99 : number - 1;

        private string Pronoun => Next == 0 ? "it" : "one";

        public string Quanity => number == 0 ? "no more" : number.ToString();
        
        public string Container => number == 1 ? "bottle" : "bottles";
       
        public string Action => number == 0 ? "Go to the store and buy some more" : $"Take {Pronoun} down and pass it around";
        
        public override string ToString() => $"{Quanity} {Container}";
    }
}
