using Core.CrossCuttingConcern.Caching.Microsoft;
using Core.CrossCuttingConcern.Caching;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>(); //Burada yine dinamik bir yapı kullanmış olduk.
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //Servislerimizi çözümleyeceğimiz yerdir.
        }
    }
}
