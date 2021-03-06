// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Payments
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    
    

    /// <summary>
    /// Describes a shipping option
    /// </summary>
    public partial class PaymentShippingOption
    {
        /// <summary>
        /// Initializes a new instance of the PaymentShippingOption class.
        /// </summary>
        public PaymentShippingOption() { }

        /// <summary>
        /// Initializes a new instance of the PaymentShippingOption class.
        /// </summary>
        public PaymentShippingOption(string id = default(string), string label = default(string), PaymentCurrencyAmount amount = default(PaymentCurrencyAmount), bool? selected = default(bool?))
        {
            Id = id;
            Label = label;
            Amount = amount;
            Selected = selected;
        }

        /// <summary>
        /// String identifier used to reference this PaymentShippingOption
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Human-readable description of the item
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Contains the monetary amount for the item
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public PaymentCurrencyAmount Amount { get; set; }

        /// <summary>
        /// Indicates whether this is the default selected
        /// PaymentShippingOption
        /// </summary>
        [JsonProperty(PropertyName = "selected")]
        public bool? Selected { get; set; }

    }
}
