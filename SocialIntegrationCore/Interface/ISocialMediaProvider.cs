
using System;
using System.Threading.Tasks;
using Android.App;
using Xamarin.Social;

namespace SocialIntegrationCore.Interface
{
    public interface ISocialMediaProvider
    {
        String AccessToken { get; set; }

        String AccessTokenSecret { get; set; }
        void Login(Activity currentActivity, Type destinationActivityType);

        Task<bool> Post(Activity destinationActivity, Item item);
    }
}