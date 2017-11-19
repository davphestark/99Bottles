namespace _99BottlesDemo
{
    public class BottleNumber
    {
        private int number;
        public BottleNumber()
        {}

        public BottleNumber(int number)
        {
            this.number = number;
        }

        public virtual BottleNumber Next => new BottleFactory().GetBottleNumberFor(number - 1);

        public virtual string Pronoun => "one";

        public virtual string Quanity => number.ToString();
        
        public virtual string Container => "bottles";
       
        public virtual string Action => $"Take {Pronoun} down and pass it around";
        
        public override string ToString() => $"{Quanity} {Container}";
    }
}
