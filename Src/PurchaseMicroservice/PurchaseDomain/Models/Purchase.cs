﻿namespace Purchase.Domain.Model
{
    using Common.Core;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Product Purchase Entity
    /// </summary>
    public class Purchase : Entity, IAggregateRoot
    {
        public string PurchaaseId { get; set; }

        public DateTime PurchaseDate { get; set; }

       public User User { get; set; }

        public IList<ProductLineItem> LineItems { get; set; }

        public Purchase()
        {
            LineItems = new List<ProductLineItem>();
        }
    }
}