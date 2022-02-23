using System.Linq;
using PaloIT.Hiring.FeatureFlags.Models;
using PaloIT.Hiring.FeatureFlags.Service;
using Xunit;

namespace PaloIT.Hiring.FeatureFlags.Test.Service;

public class FeatureFlagServiceTest
{
    [Fact]
    public void ShouldPermitUserForFeature()
    {
        const string userId = "1";
        var featureFlagService = new FeatureFlagService();
        var newFlag = new FeatureFlag("TestFlag1");
        
        featureFlagService.permitUser(userId, newFlag);
        var isUserPermitted = featureFlagService.isUserPermitted(userId, newFlag);
        Assert.True(isUserPermitted);
    }

    [Fact]
    public void ShouldGetAllPermittedUsers()
    {
        const string userId1 = "1";
        const string userId2 = "2";

        var featureFlagService = new FeatureFlagService();
        var newFlag = new FeatureFlag("TestFlag1");
        
        featureFlagService.permitUser(userId1, newFlag);
        featureFlagService.permitUser(userId2, newFlag);
        
        var permittedUsers = featureFlagService.getPermittedUsers(newFlag);
        Assert.Equal(2, permittedUsers.Count());
    }

    
    [Fact]
    public void ShouldPermitUsersForZeroPercent()
    {
        const string userId1 = "1";
        const string userId2 = "2";
        const string userId3 = "3";

        var featureFlagService = new FeatureFlagService();
        var newFlag = new FeatureFlag("TestFlag1", 0);
        
        featureFlagService.permitUser(userId1, newFlag);
        featureFlagService.permitUser(userId2, newFlag);
        featureFlagService.permitUser(userId3, newFlag);
        
        var permittedUsers = featureFlagService.getPermittedUsers(newFlag);
        Assert.Empty(permittedUsers);
    }

        
    [Fact]
    public void SholdPermitHalfOfUsers()
    {
        const string userId1 = "1";
        const string userId2 = "2";
        const string userId3 = "3";
        const string userId4 = "4";


        var featureFlagService = new FeatureFlagService();
        var newFlag = new FeatureFlag("TestFlag1", 50);
        
        featureFlagService.permitUser(userId1, newFlag);
        featureFlagService.permitUser(userId2, newFlag);
        featureFlagService.permitUser(userId3, newFlag);
        featureFlagService.permitUser(userId4, newFlag);

        
        var permittedUsers = featureFlagService.getPermittedUsers(newFlag);
        Assert.Equal(2, permittedUsers.Count());
    }
}