﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;

using AppTestUWP.Activation;

using Microsoft.WindowsAzure.Messaging;

using Windows.ApplicationModel.Activation;
using Windows.Networking.PushNotifications;

namespace AppTestUWP.Services
{
    // More about adding push notifications to your Windows app at https://docs.microsoft.com/azure/app-service-mobile/app-service-mobile-windows-store-dotnet-get-started-push
    internal class HubNotificationsService : ActivationHandler<ToastNotificationActivatedEventArgs>
    {
        public async Task InitializeAsync()
        {
            // TODO WTS: Set your Hub Name
            var hubName = "IISSNotificationHub";

            // TODO WTS: Set your DefaultListenSharedAccessSignature
            var accessSignature = "Endpoint=sb://iissnotificationhub.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=4QRYSSvgRadFjjMqnFjs8nwiNMWidOy+GAGQtH/zuSA=";
            try
            {
                var channel = await PushNotificationChannelManager.CreatePushNotificationChannelForApplicationAsync();

                var hub = new NotificationHub(hubName, accessSignature);
                var result = await hub.RegisterNativeAsync(channel.Uri);
                if (result.RegistrationId != null)
                {
                    // Registration was successful
                }

                // You can also send push notifications from Windows Developer Center targeting your app consumers
                // More details at https://docs.microsoft.com/windows/uwp/publish/send-push-notifications-to-your-apps-customers
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        protected override async Task HandleInternalAsync(ToastNotificationActivatedEventArgs args)
        {
            // TODO WTS: Handle activation from toast notification,
            // Be sure to use the template 'ToastGeneric' in the toast notification configuration XML
            // to ensure OnActivated is called when launching from a Toast Notification sent from Azure
            //
            // More about handling activation at https://docs.microsoft.com/windows/uwp/design/shell/tiles-and-notifications/send-local-toast
            await Task.CompletedTask;
        }
    }
}
