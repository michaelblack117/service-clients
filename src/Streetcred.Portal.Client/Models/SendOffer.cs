// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Streetcred.Portal.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SendOffer
    {
        /// <summary>
        /// Initializes a new instance of the SendOffer class.
        /// </summary>
        public SendOffer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SendOffer class.
        /// </summary>
        public SendOffer(string definitionId = default(string), string connectionId = default(string))
        {
            DefinitionId = definitionId;
            ConnectionId = connectionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "definitionId")]
        public string DefinitionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectionId")]
        public string ConnectionId { get; set; }

    }
}