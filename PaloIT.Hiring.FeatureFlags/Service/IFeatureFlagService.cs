using System.Collections.Generic;
using PaloIT.Hiring.FeatureFlags.Models;

namespace PaloIT.Hiring.FeatureFlags.Service
{
    public interface IFeatureFlagService
    {
        void permitUser(string userId, FeatureFlag feature);

        bool isUserPermitted(string userId, FeatureFlag feature);

        IEnumerable<string> getPermittedUsers(FeatureFlag feature);

    }
}

