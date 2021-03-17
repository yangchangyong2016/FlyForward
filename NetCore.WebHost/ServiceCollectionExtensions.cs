using System;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCore.Framework.Extensions.Swagger;
using NetCore.WebHost.HostAppSetting;

namespace NetCore.WebHost
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加WebHost
        /// </summary>
        /// <param name="services"></param>
        /// <param name="hostOptions"></param>
        /// <param name="env">环境</param>
        /// <param name="cfg"></param>
        /// <returns></returns>
        public static IServiceCollection AddWebHost(this IServiceCollection services, HostOptionsSetting hostOptions, IHostEnvironment env, IConfiguration cfg)
        {
            services.AddControllers();
            services.AddHttpContextAccessor();
            services.AddSingleton(hostOptions);

            services.AddSwagger();
            return services;
        }
    }
}
