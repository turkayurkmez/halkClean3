namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            //Eğer bir sınıfta değişiklik yapmak için birden fazla sebebin varsa bu kuralı ihlal ediyorsun demektir.

        }

        public void ChangeBackgroundColor() { }
        public void ChangeForeColor() { }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            string name = textBoxName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);
            productService.CreateProductOnDb(name, price);

        }
    }
}