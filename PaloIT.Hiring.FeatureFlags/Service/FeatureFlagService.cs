using System;
using System.Collections.Generic;
using PaloIT.Hiring.FeatureFlags.Models;

namespace PaloIT.Hiring.FeatureFlags.Service
{
    public class FeatureFlagService : IFeatureFlagService
    {
        // TODO: Change type dynamic
        private dynamic _featureFlags;

        public void permitUser(string userId, FeatureFlag feature)
        {
            // TODO 1: permit user [userId] for the feature [feature]
            throw new NotImplementedException();
        }

        public bool isUserPermitted(string userId, FeatureFlag feature)
        {
            // TODO 2: Return if user [userId] is permitted to access the feature [feature]
            throw new NotImplementedException();
        }

        public IEnumerable<string> getPermittedUsers(FeatureFlag feature)
        {
            // TODO 3: Get all permitted users [collection of userId] for the feature [feature]
            throw new NotImplementedException();
        }
    }
}

