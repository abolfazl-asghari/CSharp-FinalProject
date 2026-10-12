using Model.DomainModels;

namespace Model.ServiceModels
{
    public class PersonServiceModel
    {
        #region [- SelectAll() -]
        public List<Person> SelectAll()
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    var persons = context.Person.ToList();
                    return persons;
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
        public void Insert(Person person)
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    context.Add(person);
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
        public void Update(Person person)
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    context.Update(person);
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
        public void Delete(Person person)
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    context.Remove(person);
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
