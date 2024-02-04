﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Sparcpoint.Products.Data
{
    public class InventoryItem
    {
        public string Sku { get; private set; }
        public int QuantityOnHand { get; set; }

        // The raw Json string from the database gets sent here to populate the publicly available dictionary. 
        internal string AttributesJson { 
            set {
                Attributes = JsonConvert.DeserializeObject<Dictionary<string,string>>(value);
            } 
        }

        // Public access to the inventory item attributes/metadata. This gives a degree of type safety without needing a flood of class overloads
        public Dictionary<string, string> Attributes { get; private set; }

        public InventoryItem()
        {
        }
    }
}
