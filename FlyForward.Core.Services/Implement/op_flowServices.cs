using FlyForward.Core.IRepository;
using FlyForward.Core.IServices;
using FlyForward.Core.Model.Models;

namespace FlyForward.Core.Services
{
	/// <summary>
	/// op_flowServices
	/// </summary>	
	public class op_flowServices : BaseServices<op_flow>, Iop_flowServices
    {
        IBaseRepository<op_flow> dal;
        public op_flowServices(IBaseRepository<op_flow> dal)
        {
            this.dal = dal;
            base.baseRepo = dal;
        }
       
    }
}