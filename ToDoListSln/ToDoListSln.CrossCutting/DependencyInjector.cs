using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToDoListSln.Application.AppQueries;
using ToDoListSln.Application.AppService;
using ToDoListSln.Domain.Interfaces;
using ToDoListSln.Infra.Contexts;
using ToDoListSln.Infra.Repositories;

namespace ToDoListSln.CrossCutting
{
    public class DependencyInjector
    {
        public static void Inject(IServiceCollection services)
        {
            services.AddTransient<IToDoListRepository, ToDoListRepository>();
            services.AddTransient<IToDoListAppQuery, ToDoListAppQuery>();
            services.AddTransient<IToDoListAppService, ToDoListAppService>();
            services.AddDbContext<ToDoListContext>(options => options.UseInMemoryDatabase("ToDoListDb"));
        }

    }
}
