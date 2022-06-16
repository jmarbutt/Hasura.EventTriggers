

using Hasura.EventTriggers.Configuration;

namespace Hasura.EventTriggers;

public class HasuraServer
{
    
    public HasuraConfiguration Configuration { get; set; }
    
    public   HasuraServer(Action<HasuraConfiguration> configure)
    {
        var options = new HasuraConfiguration()
        {
            
        };

        configure(options);

        Configuration = options;
    }

    
    public void RegisterEventTrigger(Action<RegisterEventTriggerOptions> configure)
    {
        var options = new RegisterEventTriggerOptions();
        configure?.Invoke(options);
    }
    
    public void RegisterEventTrigger<T>(Action<RegisterEventTriggerOptions> configure)
    {
        var options = new RegisterEventTriggerOptions();
        configure?.Invoke(options);
    }
    
    public void RegisterEventTrigger<T>(string functionName)
    {
 
    }
  
}