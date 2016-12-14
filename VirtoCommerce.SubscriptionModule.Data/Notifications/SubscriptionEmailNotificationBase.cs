﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtoCommerce.Platform.Core.Notifications;
using VirtoCommerce.SubscriptionModule.Core.Model;

namespace VirtoCommerce.SubscriptionModule.Data.Notifications
{
    public class SubscriptionEmailNotificationBase : EmailNotification
    {
        public SubscriptionEmailNotificationBase(IEmailNotificationSendingGateway gateway)
            : base(gateway)
        {
        }
        [NotificationParameter("Subscription")]
        public Subscription Subscription { get; set; }
    }
}
