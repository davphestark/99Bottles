namespace _99BottlesDemo
{
    public class BottleOne : BottleNumber
    {
        public BottleOne() :base(1)
        {
        }
        public override BottleNumber Next => new BottleZero();

        public override string Pronoun => "it";

        public override string Container => "bottle";
    }
}
