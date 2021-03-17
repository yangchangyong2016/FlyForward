using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NetCore.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyForward.Core.API
{
	/// <summary>
	/// 
	/// </summary>
	public class Program
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
			//new NetCoreHostBuilder().Run<Startup>(args);
		}
		public static IHostBuilder CreateHostBuilder(string[] args) =>
	//初始化默认主机Builder
	Host.CreateDefaultBuilder(args)
		.ConfigureWebHostDefaults(webBuilder =>
		{
			webBuilder
			.UseStartup<Startup>()
			.UseUrls("http://*:8081");
		});
	}
}
