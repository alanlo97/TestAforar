using System.Threading.Tasks;
using TestAforar.Entities;
using TestAforar.Response;

namespace TestAforar.Service.Interfaces
{
    public interface IIncorporador
    {
        Task<Result> Incorporar(Prestadora prestadora);
    }
}
