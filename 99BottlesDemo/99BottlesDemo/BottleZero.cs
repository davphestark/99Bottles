namespace _99BottlesDemo
{
    public class BottleZero : BottleNumber
    {
        public override BottleNumber Next => new BottleNumber(99);
        
        public override string Quanity => "no more";
        
        public override string Action => "Go to the store and buy some more";
    }
}
