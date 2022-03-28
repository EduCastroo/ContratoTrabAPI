using ContratoTrabalhoAPI.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ContratoTrabalhoAPI.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> Get();

        Task<User> Get(int id);

        Task<User> Create(User user);

        Task Update(User user);

        Task Delete(int id);


    }
}
