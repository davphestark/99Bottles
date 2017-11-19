namespace _99BottlesDemo
{
    public class BottleFactory
    {
        public BottleNumber GetBottleNumberFor(int number)
        {
            switch (number)
            {
                case 0:
                    return new BottleZero();
                case 1:
                    return new BottleOne();
            }
            return new BottleNumber(number);
        }
    }
}
