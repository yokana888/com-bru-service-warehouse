﻿using Com.Bateeq.Service.Warehouse.Lib.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.Bateeq.Service.Warehouse.Lib.Models.InventoryModel
{
    public class InventoryMovement : BaseModel
    {
        public double After { get; set; }

        public double Before { get; set; }

        public DateTimeOffset Date { get; set; }

        [MaxLength(255)]
        public string ItemCode { get; set; }
        [MaxLength(255)]
        public string ItemArticleRealizationOrder { get; set; }

        public double ItemDomesticCOGS { get; set; }

        public double ItemDomesticRetail { get; set; }

        public double ItemDomesticSale { get; set; }

        public double ItemDomesticWholeSale { get; set; }

        public long ItemId { get; set; }

        public double ItemInternationalCOGS { get; set; }

        public double ItemInternationalRetail { get; set; }

        public double ItemInternationalSale { get; set; }

        public double ItemInternationalWholeSale { get; set; }

        [MaxLength(255)]
        public string ItemName { get; set; }

        [MaxLength(255)]
        public string ItemSize { get; set; }

        [MaxLength(255)]
        public string ItemUom { get; set; }

        public double Quantity { get; set; }
        [MaxLength(255)]
        public string Reference { get; set; }
        [MaxLength(1000)]
        public string Remark { get; set; }

        [MaxLength(255)]
        public string StorageCode { get; set; }

        public long StorageId { get; set; }

        public bool StorageIsCentral { get; set; }

        [MaxLength(255)]
        public string StorageName { get; set; }

        [MaxLength(255)]
        public string Type { get; set; }
    }
}
