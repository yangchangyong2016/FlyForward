using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FlyForward.Core.API.Controllers
{
	/// <summary>
	/// 获取
	/// </summary>
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class UsersController: AbstractController
	{
		/// <summary>
		/// 获取
		/// </summary>
		public UsersController( )
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpGet("{id}")]
		public string Get(string id)
		{
			Log.Error("ddddddddddddddddddddddddddddddddd");
			return "value";
		}
	}
}
