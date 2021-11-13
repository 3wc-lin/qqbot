using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using QQBot.Utils;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace QQBot.Web
{
    public class Program
    {

        /// <summary>
        /// ����Դ�ļ����µ��������ݵ����ļ���
        /// </summary>
        /// <param name="sources">Դ�ļ���·��</param>
        /// <param name="dest">���ļ���·��</param>
        static void CopyFolder(string sources, string dest)
        {
            if (!Directory.Exists(dest))
            {
                Directory.CreateDirectory(dest);
            }
            DirectoryInfo dinfo = new DirectoryInfo(sources);
            foreach (FileSystemInfo f in dinfo.GetFileSystemInfos())
            {
                string destName = Path.Combine(dest, f.Name);
                if (f is FileInfo)
                {
                    if (!File.Exists(destName))
                        File.Copy(f.FullName, destName, true);
                }
                else
                {
                    CopyFolder(f.FullName, destName);
                }
            }
        }

        public static void Main(string[] args)
        {
            Task.Run(() =>
            {
                CopyFolder("./scripts-bak", "./scripts");
                var dirs = new List<string> { "./scripts/limitRecord", "./scripts/ql", "./db/import" };
                foreach (var dir in dirs)
                {
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                }
            });
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var configBuilder = new ConfigurationBuilder();
            var config = InstallConfigHelper.Get();
            return Host.CreateDefaultBuilder(args)
            .UseDefaultServiceProvider(options =>
            {
                options.ValidateScopes = false;
            }).UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>().UseUrls("http://*:" + ((config == null || string.IsNullOrEmpty(config.Port)) ? "5010" : config.Port));
                });
        }
    }
}
