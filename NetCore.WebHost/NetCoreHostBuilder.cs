using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using NetCore.Common.Utils;
using NetCore.WebHost.HostAppSetting;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.WebHost
{
	public class NetCoreHostBuilder
    {
        /// <summary>
        /// 启动
        /// </summary>
        /// <typeparam name="TStartup"></typeparam>
        /// <param name="args">启动参数</param>
        public void Run<TStartup>(string[] args) where TStartup : StartupAbstract
        {
            CreateBuilder<TStartup>(args).Build().Run();
        }

        /// <summary>
        /// 创建主机生成器
        /// </summary>
        /// <typeparam name="TStartup"></typeparam>
        /// <param name="args"></param>
        /// <returns></returns>
        public IHostBuilder CreateBuilder<TStartup>(string[] args) where TStartup : StartupAbstract
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", false)
                #if DEBUG
                .AddJsonFile("appsettings.Development.json", false)
                #endif
                .Build();

            var hostOptions = new HostOptionsSetting();
            config.GetSection("Host").Bind(hostOptions);

			if (hostOptions.Urls.IsNull())
				hostOptions.Urls = "http://*:5000";

			return Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
                    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                    .UseDefaultServiceProvider(options => { options.ValidateOnBuild = false; })
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder//.UseLogging()
                            .UseStartup<TStartup>()
                            .UseUrls(hostOptions.Urls);
                    }); 
        }
    }
}
