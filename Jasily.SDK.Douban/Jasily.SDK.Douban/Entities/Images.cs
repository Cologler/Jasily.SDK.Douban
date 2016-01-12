using System.Runtime.Serialization;

namespace Jasily.SDK.Douban.Entities
{
    [DataContract]
    public class Images
    {
        [DataMember(Name = "small")]
        public string Small { get; set; }

        [DataMember(Name = "large")]
        public string Large { get; set; }

        [DataMember(Name = "medium")]
        public string Medium { get; set; }
    }
}