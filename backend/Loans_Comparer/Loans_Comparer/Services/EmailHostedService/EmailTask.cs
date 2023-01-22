﻿using Loans_Comparer.Entities.Enums;

namespace Loans_Comparer.Services.EmailHostedService
{
    public class EmailTask
    {
        public Guid Id { get; set; }
        public Guid inquiryId { get; set; }
        public BankNames BankId { get; set; }
        public string ExternalOfferId { get; set; }
        public string email { get; set; }
    }
}
