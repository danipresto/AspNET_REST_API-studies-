using PersonAPITest.Model;

namespace PersonAPITest.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {

        private volatile int count;
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 5; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
               
            }

            return persons;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 01,
                Age = 35,
                FirstName = "Leandver",
                LastName = "Dust",
                Address = "Oslo - Norway",
                Gender = "Male",
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                Age = 35 + i,
                FirstName = "Mperson" + i,
                LastName = "Mock" + i,
                Address = "Mock Address" + i,
                Gender = "Mock"
            };
        }

        private int IncrementAndGet()
        {
            return Interlocked.Increment(ref count);    
        }
    }
}
