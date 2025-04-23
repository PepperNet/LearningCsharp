static class EX_const_vs_readonly
{
    public static void RunExample()
    {

        // Використання
        Console.WriteLine($"Назва програми: {ConfigurationSettings.AppName}");
        Console.WriteLine($"Версія конфігурації: {ConfigurationSettings.ConfigVersion}");

        var prodConfig = new ConfigurationSettings("Production");
        var testConfig = new ConfigurationSettings("Testing");

        Console.WriteLine($"Конфігурація 1 - Середовище: {prodConfig.Environment}, Час запуску: {prodConfig.StartupTime}");
        Console.WriteLine($"Конфігурація 2 - Середовище: {testConfig.Environment}, Час запуску: {testConfig.StartupTime}");

    }
}

public class ConfigurationSettings
{
    // Константи - встановлюються на етапі компіляції
    public const string AppName = "MyApplication";
    public const int MaxRetryCount = 3;
    
    // Readonly поля - можуть бути встановлені під час виконання
    public readonly string Environment;
    public readonly DateTime StartupTime;
    
    // Статичне readonly поле - одне для всіх екземплярів, але може залежати від виконання
    public static readonly double ConfigVersion = Math.Round(1.5, 1);
    
    public ConfigurationSettings(string environment)
    {
        Environment = environment;
        StartupTime = DateTime.Now;
    }
}
#region Result
// Результат показує, що константи однакові для всіх,
// а readonly поля можуть відрізнятися для різних екземплярів
#endregion
