using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NetCore.WebHost;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.IO;
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
		/// 主函数进入
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			//CreateHostBuilder(args).Build().Run();

			//Log.Logger = new LoggerConfiguration()
			//		.MinimumLevel.Debug()
			//		.MinimumLevel.Override("Microsoft", LogEventLevel.Error)
			//		.WriteTo.Console()
			//		.WriteTo.File(Path.Combine("Logs", @"logxxx.log"), rollingInterval: RollingInterval.Infinite)
			//		//输出数据库
			//		//.WriteTo.MSSqlServer(conn, tablName, autoCreateSqlTable: true, columnOptions: columnOptions, restrictedToMinimumLevel: LogEventLevel.Debug)
			//		.CreateLogger();
			//Log.CloseAndFlush();
			new NetCoreHostBuilder().Run<Startup>(args);
		}
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		/// <returns></returns>
		//public static IHostBuilder CreateHostBuilder(string[] args) =>
		//		//初始化默认主机Builder
		//		Host.CreateDefaultBuilder(args)
		//			.ConfigureWebHostDefaults(webBuilder =>
		//			{
		//				webBuilder
		//				.UseStartup<Startup>()
		//				.UseUrls("http://*:8081");
		//			});
	}
}
