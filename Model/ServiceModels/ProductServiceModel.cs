using Model.DomainModels;

namespace Model.ServiceModels
{
    public class ProductServiceModel
    {
        #region [- SelectAll() -]
        public List<Product> SelectAll()
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    var products = context.Product.ToList();
                    return products;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Insert() -]
        public void Insert(Product product)
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    context.Add(product);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Update() -]
        public void Update(Product product)
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    context.Update(product);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Delete() -]
        public void Delete(Product product)
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    context.Remove(product);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion
    }
}
