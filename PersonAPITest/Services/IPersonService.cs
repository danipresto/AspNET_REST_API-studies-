using System.Collections.Generic;
using PersonAPITest.Model;



namespace PersonAPITest.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person Update(Person person);
        List<Person> FindAll();
        Person FindById(long id);
        void Delete(long id);

    }
}
