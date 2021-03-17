using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using NetCore.WebHost.HostAppSetting;

namespace NetCore.WebHost
{
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// 启用WebHost
        /// </summary>
        /// <param name="app"></param>
        /// <param name="hostOptions"></param>
        /// <param name="env"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseWebHost(this IApplicationBuilder app, HostOptionsSetting hostOptions, IHostEnvironment env)
        {
			//异常处理
			//app.UseExceptionHandle();

			//设置默认文档
			//var defaultFilesOptions = new DefaultFilesOptions();
			//defaultFilesOptions.DefaultFileNames.Clear();
			//defaultFilesOptions.DefaultFileNames.Add("index.html");
			//app.UseDefaultFiles(defaultFilesOptions);

			app.UseDefaultPage();

			//app.UseDocs();

			////反向代理
			////if (hostOptions.Proxy)
			//{
			//    app.UseForwardedHeaders(new ForwardedHeadersOptions
			//    {
			//        ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
			//    });
			//}

			//路由
			app.UseRouting();

			////CORS
			//app.UseCors("Default");

			////认证
			//app.UseAuthentication();

			//授权
			app.UseAuthorization();

			//配置端点
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
			//if (env.IsDevelopment())
			//{
			//	app.UseDeveloperExceptionPage();
			//	app.UseSwagger();
			//	app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Lite.API v1"));
			//}

			//开启Swagger
			if (hostOptions.Swagger || env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint($"/swagger/V1/swagger.json", $"{"昌"} V1");
                    //c.IndexStream = "";
                    //路径配置，设置为空，表示直接在根域名（localhost:8001）访问该文件,注意localhost:8001/swagger是访问不到的，
                    //去launchSettings.json把launchUrl去掉，如果你想换一个路径，直接写名字即可，比如直接写c.RoutePrefix = "doc";
                    //c.RoutePrefix = "doc";
                }) ;
            }
            return app;
        }

        /// <summary>
        /// 启用默认页
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseDefaultPage(this IApplicationBuilder app)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/app");
            if (Directory.Exists(path))
            {
                var options = new StaticFileOptions
                {
                    FileProvider = new PhysicalFileProvider(path),
                    RequestPath = new PathString("/app")
                };

                app.UseStaticFiles(options);

                var rewriteOptions = new RewriteOptions().AddRedirect("^$", "app");

                app.UseRewriter(rewriteOptions);
            }

            return app;
        }

        /// <summary>
        /// 启动文档页
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseDocs(this IApplicationBuilder app)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/docs");
            if (Directory.Exists(path))
            {
                var options = new StaticFileOptions
                {
                    FileProvider = new PhysicalFileProvider(path),
                    RequestPath = new PathString("/docs")
                };

                app.UseStaticFiles(options);
            }

            return app;
        }

        /// <summary>
        /// 启用应用停止处理
        /// </summary>
        /// <returns></returns>
        public static IApplicationBuilder UseShutdownHandler(this IApplicationBuilder app)
        {
            var applicationLifetime = app.ApplicationServices.GetRequiredService<IHostApplicationLifetime>();
            applicationLifetime.ApplicationStopping.Register(() =>
            {
                //var handlers = app.ApplicationServices.GetServices<IAppShutdownHandler>().ToList();
                //foreach (var handler in handlers)
                //{
                //    handler.Handle();
                //}
            });

            return app;
        }
    }
}
