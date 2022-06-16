namespace Hasura.EventTriggers.Configuration;

public class HasuraConfiguration
{
    public string HasuraApiUrl { get; set; }
    public string AdminSecret { get; set; }
    public DatabaseType DefaultDatabaseType { get; set; } = DatabaseType.MsSql;
    public string DefaultSource { get; set; } = "default";
    
}