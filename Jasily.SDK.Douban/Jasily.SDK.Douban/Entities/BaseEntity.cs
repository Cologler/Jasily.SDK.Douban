using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Jasily.SDK.Douban.Entities
{
    [DataContract]
    public abstract class BaseEntity
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "aka")]
        public List<string> OtherNames { get; set; }

        public virtual IEnumerable<string> AllNames()
            => this.OtherNames.EmptyIfNull().Where(z => !string.IsNullOrWhiteSpace(z));
    }
}