// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An automated install ticket for a Power BI template app
    /// </summary>
    public partial class InstallTicket
    {
        /// <summary>
        /// Initializes a new instance of the InstallTicket class.
        /// </summary>
        public InstallTicket()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InstallTicket class.
        /// </summary>
        /// <param name="ticket">Install ticket</param>
        /// <param name="ticketId">The unique ID of an install ticket. Audit
        /// logs can be used to correlate operations that use this ticket with
        /// the generate ticket operation.</param>
        /// <param name="expiration">The expiration date and time (UTC) of the
        /// ticket</param>
        public InstallTicket(string ticket, System.Guid ticketId, System.DateTime expiration)
        {
            Ticket = ticket;
            TicketId = ticketId;
            Expiration = expiration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets install ticket
        /// </summary>
        [JsonProperty(PropertyName = "ticket")]
        public string Ticket { get; set; }

        /// <summary>
        /// Gets or sets the unique ID of an install ticket. Audit logs can be
        /// used to correlate operations that use this ticket with the generate
        /// ticket operation.
        /// </summary>
        [JsonProperty(PropertyName = "ticketId")]
        public System.Guid TicketId { get; set; }

        /// <summary>
        /// Gets or sets the expiration date and time (UTC) of the ticket
        /// </summary>
        [JsonProperty(PropertyName = "expiration")]
        public System.DateTime Expiration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Ticket == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Ticket");
            }
        }
    }
}
