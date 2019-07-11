// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.ContentModerator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class BodyModel
    {
        /// <summary>
        /// Initializes a new instance of the BodyModel class.
        /// </summary>
        public BodyModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BodyModel class.
        /// </summary>
        public BodyModel(string dataRepresentation = default(string), string value = default(string))
        {
            DataRepresentation = dataRepresentation;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DataRepresentation")]
        public string DataRepresentation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

    }
}