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
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            if(result != null)
            {
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch(Exception ex)
                {
                    throw;
                }
            }
        }


        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }


        public Person FindById(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Person Update(Person person)
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
    }
}
