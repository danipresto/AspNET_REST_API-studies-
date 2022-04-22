using PersonAPITest.Model;
using PersonAPITest.Model.Context;

namespace PersonAPITest.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {

        private PgContext _context;

        public PersonServiceImplementation(PgContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
            return person;
        }


        public void Delete(long id)
        {
            var result = _context.Person.SingleOrDefault(p => p.Id==id);
            if (result != null)
            {
                try
                {
                    _context.Person.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }


        public List<Person> FindAll()
        {
            return _context.Person.ToList();
        }


        public Person FindById(long id)
        {
            return _context.Person.SingleOrDefault(p => p.Id == id);
        }

        public Person Update(Person person)
        {

            var result = _context.Person.SingleOrDefault(p => p.Id == person.Id);
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return person;
        }


    }
}
