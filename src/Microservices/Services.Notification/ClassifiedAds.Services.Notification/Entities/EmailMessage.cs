﻿using ClassifiedAds.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ClassifiedAds.Services.Notification.Entities
{
    public class EmailMessage : AggregateRoot<Guid>
    {
        public string From { get; set; }

        public string Tos { get; set; }

        public string CCs { get; set; }

        public string BCCs { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public int AttemptCount { get; set; }

        public int MaxAttemptCount { get; set; }

        public DateTimeOffset? NextAttemptDateTime { get; set; }

        public DateTimeOffset? ExpiredDateTime { get; set; }

        public string Log { get; set; }

        public DateTimeOffset? SentDateTime { get; set; }

        public Guid? CopyFromId { get; set; }

        public ICollection<EmailMessageAttachment> EmailMessageAttachments { get; set; }
    }
}
