//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PayPal.Util;
using System;

namespace PayPal.Api
{
    /// <summary>
    /// Details about an individual payout item.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class PayoutItemDetails : PayPalRelationalObject
    {
        /// <summary>
        /// An ID for an individual payout. Provided by PayPal, such as in the case of getting the status of a batch request. 30 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payout_item_id")]
        public string payout_item_id { get; set; }

        /// <summary>
        /// Generated ID for the transaction. 30 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "transaction_id")]
        public string transaction_id { get; set; }

        /// <summary>
        /// Status of a transaction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "transaction_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PayoutTransactionStatus transaction_status { get; set; }

        /// <summary>
        /// Amount of money in U.S. dollars for fees.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payout_item_fee")]
        public Currency payout_item_fee { get; set; }

        /// <summary>
        /// An ID for the batch payout. Generated by PayPal. 30 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payout_batch_id")]
        public string payout_batch_id { get; set; }

        /// <summary>
        /// Sender-created ID for tracking the batch in an accounting system. 30 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sender_batch_id")]
        public string sender_batch_id { get; set; }

        /// <summary>
        /// The data for a payout item that the sender initially provided.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payout_item")]
        public PayoutItem payout_item { get; set; }

        /// <summary>
        /// Time of the last processing for this item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "time_processed")]
        public string time_processed { get; set; }

        /// <summary>
        /// Error information associated with this item, if any.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errors")]
        public Error error { get; set; }

        /// <summary>
        /// Obtain the status of a payout item by passing the item ID to the request URI.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="payoutItemId">Payouts generated payout_item_id to obtain status.</param>
        /// <returns>PayoutItemDetails</returns>
        [Obsolete("This method has been moved to the PayoutItem class.", false)]
        public static PayoutItemDetails Get(APIContext apiContext, string payoutItemId)
        {
            return PayoutItem.Get(apiContext, payoutItemId);
        }
    }
}
