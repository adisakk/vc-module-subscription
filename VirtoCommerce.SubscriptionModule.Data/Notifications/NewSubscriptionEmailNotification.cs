﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtoCommerce.Platform.Core.Notifications;

namespace VirtoCommerce.SubscriptionModule.Data.Notifications
{
    public class NewSubscriptionEmailNotification : SubscriptionEmailNotificationBase
    {
        public NewSubscriptionEmailNotification(IEmailNotificationSendingGateway gateway)
            :base(gateway)
        {
        }

    }
}
