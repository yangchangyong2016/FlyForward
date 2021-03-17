using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using NetCore.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace FlyForward.Core.API
{
	/// <summary>
	///¼Ì³Ð»ù´¡µÄ
	/// </summary>
	public class Startup : StartupAbstract
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="env"></param>
		/// <param name="cfg"></param>
		public Startup(IHostEnvironment env, IConfiguration cfg) : base(env, cfg)
		{
		}
	}
}
