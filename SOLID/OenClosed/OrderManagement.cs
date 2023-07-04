namespace OenClosed
{
    public class Customer
    {

    }

    //public enum Campaign
    //{
    //    SecondOneHalf,
    //    FreeFee,
    //    Standard
    //}

    public abstract class Campaign
    {
        public abstract double GetPrice(double price);

    }

    public class SecondOneHalfPrice : Campaign
    {
        public override double GetPrice(double price)
        {
            return price * .5;
        }
    }
    public class FreeFee : Campaign
    {
        public override double GetPrice(double price)
        {
            return price * .9;
        }
    }

    public class Standard : Campaign
    {
        public override double GetPrice(double price)
        {
            return price * .95;
        }
    }

    public class QuarterFree : Campaign
    {
        public override double GetPrice(double price)
        {
            return price * .75;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Campaign Campaign { get; set; }
    }
    public class OrderManagement
    {
        public double GetDiscountedPrice(Product product)
        {
            //switch (product.Campaign)
            //{
            //    case Campaign.SecondOneHalf:
            //        return product.Price * 0.5;
            //    case Campaign.FreeFee:
            //        return product.Price * 0.9;
            //    case Campaign.Standard:
            //        return product.Price * 0.95;
            //    default:
            //        return product.Price;

            //}
            return product.Campaign.GetPrice(product.Price);
        }
    }
}
