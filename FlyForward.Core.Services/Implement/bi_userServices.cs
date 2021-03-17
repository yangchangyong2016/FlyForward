using FlyForward.Core.IRepository;
using FlyForward.Core.IServices;
using FlyForward.Core.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlyForward.Core.Services
{
	/// <summary>
	/// bi_userServices
	/// </summary>	
	public class bi_userServices : BaseServices<bi_user>, Ibi_userServices
    {
        IBaseRepository<bi_user> dal;
        public bi_userServices(IBaseRepository<bi_user> dal)
        {
            this.dal = dal;
            base.baseRepo = dal;
        }

        public async Task<List<bi_user>> GetUserByID(string Id)
        {
           return  await baseRepo.QueryByIDs(new object[] { Id });
        }
    }
}
	