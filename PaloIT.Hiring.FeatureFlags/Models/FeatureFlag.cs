namespace PaloIT.Hiring.FeatureFlags.Models;

public class FeatureFlag
{
    private string _key;
    private decimal _percentagePermitted;

    public FeatureFlag(string key, decimal percentagePermitted = 1)
    {
        this._key = key;
        this._percentagePermitted = percentagePermitted;
    }
}