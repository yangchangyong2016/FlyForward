using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCore.Common.Utils;
using NetCore.Framework.Extensions.Autofac;
using NetCore.WebHost.HostAppSetting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.WebHost
{
    public abstract class StartupAbstract
    {
        protected readonly IHostEnvironment Env;
        private readonly IConfiguration _cfg;
        private readonly HostOptionsSetting _hostOptions;

        protected StartupAbstract(IHostEnvironment env, IConfiguration cfg)
        {
            Env = env;
            _cfg = cfg;

            //主机配置
            _hostOptions = new HostOptionsSetting();
            cfg.GetSection("Host").Bind(_hostOptions);

            if (_hostOptions.Urls.IsNull())
                _hostOptions.Urls = "http://*:5000";
        }

        public virtual void ConfigureServices(IServiceCollection services)
        {
            services.AddWebHost(_hostOptions, Env, _cfg);
        }

        public virtual void Configure(IApplicationBuilder app)
        {
            app.UseWebHost(_hostOptions, Env);
            //app.UseShutdownHandler();
        }

        /// <summary>
        /// 整个方法被Autofa自动调用
        /// 负责注册各种服务
        /// 尽管Autofac 有专门的地方来注册服务
        /// 之前ServiceCollection注册的服务其实也会生效，接管过来；
        /// </summary>
        /// <param name="containerBuilder"></param>
        public void ConfigureContainer(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule(new AutofacModuleRegister());
        }
    }
}
