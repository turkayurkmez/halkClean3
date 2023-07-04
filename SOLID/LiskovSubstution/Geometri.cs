namespace LiskovSubstution
{
    public class GeometryFactory
    {
        public static IAreaCalcutable GetRectangle(int width, int? height = null)
        {
            //burda türlü işlemlerden sonra kare nesnesi dönüyor:
            if (height.HasValue)
            {
                return new Rectangle { Width = width, Height = height.Value };
            }
            else
            {
                return new Square() { EdgeLength = width };
            }

        }
    }

    public interface IAreaCalcutable
    {
        int GetArea();
    }
    //Dörtgen: 2 özelliği var
    public class Rectangle : IAreaCalcutable
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea() => Width * Height;
    }
    //Kare: 1 özelliği var
    public class Square : IAreaCalcutable //: Rectangle
    {
        //public override int Height { get => base.Height; set { base.Height = value; base.Width = value; } }
        //public override int Width { get => base.Width; set { base.Height = value; base.Width = value; } }

        public int EdgeLength { get; set; }

        public int GetArea()
        {
            return EdgeLength * EdgeLength;
        }
    }
}
