namespace task_4;

public class NotionApp
{
    private NotionAppLicenseManager licenseManager = new NotionAppLicenseManager();
    private string lisenceKey = "";

    private void CheckLisence()
    {
        Console.WriteLine("Enter The key");
        lisenceKey = Console.ReadLine()!;
    }

    private void Start()
    {
        Console.WriteLine($"Your access level is: {licenseManager.CheckLicense(lisenceKey)}");
    }
    
    /*
     * Main program implementation goes here. Performing different functions in it depends on
     * "licenseManager" properties: 'proAccess', 'trialAccess', 'commonAccess'
     */ 
    public void Implementation()
    {
        CheckLisence();
        Start();
    }
}