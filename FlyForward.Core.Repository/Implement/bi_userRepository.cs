using FlyForward.Core.Repository;
using FlyForward.Core.Model.Models;
using FlyForward.Core.IRepository;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FlyForward.Core.Repository
{	
	/// <summary>
	/// bi_userRepository
	/// </summary>	
	public class bi_userRepository : BaseRepository<bi_user>, Ibi_userRepository
    {
		//public override Task<List<bi_user>> QueryByIDs(object[] lstIds)
		//{

		//}
	}
}