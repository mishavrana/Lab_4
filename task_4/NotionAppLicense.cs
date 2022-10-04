using System.Diagnostics;

namespace task_4;

public class NotionAppLicenseManager: ApplicationLicense
{
    private bool trialAccess = false;
    private bool proAccess = false;
    private bool commonAccess = false;

    private static readonly string? pro_key = "prokey745"; 
    private static readonly string? trial_key = "trialkey634";

    public AccessLevel? CheckLicense(string key)
    {
        if
        (
            !String.IsNullOrEmpty(key) && 
            !String.IsNullOrEmpty(NotionAppLicenseManager.pro_key) &&
            !String.IsNullOrEmpty(NotionAppLicenseManager.trial_key)
        )
        {
            if (key == pro_key)
            {
                proAccess = true;
                return AccessLevel.Pro;
            }

            if (key == trial_key)
            {
                trialAccess = true;
                return AccessLevel.Trial;
            }
        }

        commonAccess = true;
        return AccessLevel.Common;
    }
}