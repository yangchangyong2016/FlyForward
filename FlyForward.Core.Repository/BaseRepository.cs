
using FlyForward.Core.Repository;
using FlyForward.Core.Model.Models;
using FlyForward.Core.IRepository;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using FlyForward.Core.Model.BaseModels;

namespace FlyForward.Core.Repository
{
	/// <summary>
	/// IBaseRepository
	/// </summary>	
	public class BaseRepository<T> : IBaseRepository<T> where T : IParam, new()
	{
		public virtual Task<int> Add(T model)
		{
			throw new NotImplementedException();
		}

		public virtual Task<int> Add(List<T> listEntity)
		{
			throw new NotImplementedException();
		}

		public virtual Task<bool> Delete(T model)
		{
			throw new NotImplementedException();
		}

		public virtual Task<bool> DeleteById(object id)
		{
			throw new NotImplementedException();
		}

		public virtual Task<bool> DeleteByIds(object[] ids)
		{
			throw new NotImplementedException();
		}

		public virtual Task<List<T>> Query()
		{
			throw new NotImplementedException();
		}

		public virtual Task<List<T>> Query(string strWhere)
		{
			throw new NotImplementedException();
		}

		public virtual Task<List<T>> Query(Expression<Func<T, bool>> whereExpression)
		{
			throw new NotImplementedException();
		}

		public virtual Task<List<TResult>> Query<TResult>(Expression<Func<T, TResult>> expression)
		{
			throw new NotImplementedException();
		}

		public virtual Task<T> QueryById(object objId)
		{
			throw new NotImplementedException();
		}

		public virtual Task<T> QueryById(object objId, bool blnUseCache = false)
		{
			throw new NotImplementedException();
		}

		public virtual Task<List<T>> QueryByIDs(object[] lstIds)
		{
			throw new NotImplementedException();
		}

		public virtual Task<bool> Update(T model)
		{
			throw new NotImplementedException();
		}

		public virtual Task<bool> Update(T entity, string strWhere)
		{
			throw new NotImplementedException();
		}

		public virtual Task<bool> Update(object operateAnonymousObjects)
		{
			throw new NotImplementedException();
		}

		public virtual Task<bool> Update(T entity, List<string> lstColumns = null, List<string> lstIgnoreColumns = null, string strWhere = "")
		{
			throw new NotImplementedException();
		}
	}
}

	//----------结束----------
	