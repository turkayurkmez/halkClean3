namespace InterfaceSegregationPrinciple
{
    public class Product
    {

    }

    public class Order
    {

    }
    public interface IRepository<T>
    {
        IList<T> GetAll();
        T Get(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);



    }

    public interface IProductRepository : IRepository<Product>
    {
        IList<Product> SearchByName(string name);
    }

    public class ProductRepository : IProductRepository
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Product> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }


    public interface IOrderRepository : IRepository<Order>
    {
        IList<Order> SearchByDate(DateTime minDate, DateTime maxDate);
    }

    public class OrderRepository : IOrderRepository
    {
        public void Create(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Order> SearchByDate(DateTime minDate, DateTime maxDate)
        {
            throw new NotImplementedException();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }



}
