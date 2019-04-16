using System.Threading.Tasks;

namespace Slick.Net.Core.Interfaces
{
    public interface ICommandHandler<in T> where T : Command
    {
        Task ExecuteAsync(T command);
    }
}
