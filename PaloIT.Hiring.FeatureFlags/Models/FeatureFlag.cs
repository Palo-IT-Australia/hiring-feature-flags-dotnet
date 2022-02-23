using System.ComponentModel.DataAnnotations;
using System.Data;

namespace PaloIT.Hiring.FeatureFlags.Models
{
    public class FeatureFlag
    {
        private string _key;
        private decimal _percentagePermitted;

        public FeatureFlag(string key, int percentagePermitted = 100)
        {
            if (percentagePermitted > 100 || percentagePermitted < 0)
            {
                throw new ValidationException("Percentage should be between 0 and 100");
            }
            this._key = key;
            this._percentagePermitted = percentagePermitted;
        }
    } 
}

