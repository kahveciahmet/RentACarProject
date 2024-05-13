using Core.CrossCuttingConcerns;
using Core.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            //eğer daha sonra redise geçersen cache için, tek yapman gereken MemoryCacheManager kısmını RedisChaceManager olarak değiştirmek.
            serviceCollection.AddSingleton<Stopwatch>();
        }
    }
}
