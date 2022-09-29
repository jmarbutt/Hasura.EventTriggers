using Hasura.EventTriggers.Configuration;
using Hasura.EventTriggers.Models;
using RestSharp;

namespace Hasura.EventTriggers;

public class HasuraServer
{
    public HasuraConfiguration Configuration { get; set; }

    public HasuraServer(Action<HasuraConfiguration> configure)
    {
        var options = new HasuraConfiguration()
        {
        };

        configure(options);

        Configuration = options;
    }

    public async Task RegisterEventTrigger<T>(Action<RegisterEventTriggerOptions> configure)
    {
        await RegisterEventTrigger(configure);
    }

    public async Task RegisterEventTrigger<T>(string urlPath)
    {
        await RegisterEventTrigger<T>(o => { o.UrlPath = urlPath; });
    }

    public async Task RegisterEventTrigger(Action<RegisterEventTriggerOptions> configure)
    {
        var options = new RegisterEventTriggerOptions();
        configure?.Invoke(options);

        var restClient = new RestClient(Configuration.HasuraApiUrl);

        var request = new RestRequest();
        request.AddHeader("AdminSecret", Configuration.AdminSecret);

        var eventCreateParams = new CreateEventTriggerModel
        {
            type = Configuration.DefaultDatabaseType == DatabaseType.Postgres
                ? "pg_create_event_trigger"
                : "mssql_create_event_trigger",

            args = new Args()
            {
                name = options.Name,
                source = Configuration.DefaultSource,
                table = options.Table,
                webhook = Configuration.BaseWebHookUrl + options.UrlPath,
                update = options.Update.ConvertToCreateModel(),
                insert = options.Insert.ConvertToCreateModel()
            }
        };

        request.AddBody(eventCreateParams);


        await restClient.PostAsync(request);
    }
}