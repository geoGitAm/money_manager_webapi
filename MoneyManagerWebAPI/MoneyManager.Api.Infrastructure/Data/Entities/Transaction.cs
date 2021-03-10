﻿using MoneyManager.Api.Infrastructure.Data.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoneyManager.Api.Infrastructure.Data.Entities
{
    public class Transaction : BaseEntity
    {
        // TODO: Range
        public TransactionType Type { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }

        [Range(1, 20000)]
        public int Amount { get; set; }
    }
}