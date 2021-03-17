using FlyForward.Core.IRepository;
using FlyForward.Core.IServices;
namespace FlyForward.Core.Services
{
	/// <summary>
	/// IBaseRepository
	/// </summary>	
	public class BaseServices<T> : IBaseServices<T> where T : class, new()
    {
		public IBaseRepository<T> baseRepo;
    }
}
	