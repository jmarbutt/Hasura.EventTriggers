using Hasura.EventTriggers;
using Hasura.EventTriggers.Configuration;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using SampleFuncApp;
using SampleFuncApp.Models;


[assembly: FunctionsStartup(typeof(Startup))]

namespace SampleFuncApp
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var hasura = new HasuraServer(config =>
            {
                config.HasuraApiUrl = "https://localhost:8080/v1/metadata";
                config.AdminSecret = "12345";
                config.DefaultDatabaseType = DatabaseType.MsSql;
                config.BaseWebHookUrl = "{WEB_HOOK_API}";
            });


            hasura.RegisterEventTrigger(o =>
            {
                o.UrlPath = "Function1";
                o.Table = new Table("Todos", "dbo");
                o.Insert = new OperationSpec()
                {
                    Columns = new[] {"Id", "FirstName", "LastName"},
                    Payload = new[] {"Id", "FirstName", "LastName"},
                };

                o.Update = new OperationSpec()
                {
                    Columns = new[] {"Id", "FirstName", "LastName"},
                    Payload = new[] {"Id", "FirstName", "LastName"},
                };
                o.Delete = true;
            });

            hasura.RegisterEventTrigger<TodoModel>(o =>
            {
                o.UrlPath = "Function2";
                o.Table = new Table("Todos", "dbo");
            });


            hasura.RegisterEventTrigger<TodoModel>("Function3");
        }
    }
}