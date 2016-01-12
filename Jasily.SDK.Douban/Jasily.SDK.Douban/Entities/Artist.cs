using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Jasily.SDK.Douban.Entities
{
    [DataContract]
    public class Artist : BaseEntity
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "name_en")]
        public string OriginName { get; set; }

        [DataMember(Name = "aka_en")]
        public List<string> OtherOriginNames { get; set; }

        [DataMember(Name = "avatars")]
        public Images Images { get; set; }
    }
}