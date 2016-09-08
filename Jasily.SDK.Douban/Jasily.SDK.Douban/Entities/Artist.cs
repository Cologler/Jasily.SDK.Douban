using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Jasily.SDK.Douban.Entities
{
    [DataContract]
    public class Artist : BaseEntity
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "name_en")]
        public string OriginalName { get; set; }

        [DataMember(Name = "aka_en")]
        public List<string> OtherOriginalNames { get; set; }

        [DataMember(Name = "avatars")]
        public Images Images { get; set; }

        public override IEnumerable<string> AllNames()
        {
            if (!string.IsNullOrWhiteSpace(this.Name))
                yield return this.Name;

            if (!string.IsNullOrWhiteSpace(this.OriginalName))
                yield return this.OriginalName;

            foreach (var name in base.AllNames())
            {
                yield return name;
            }

            foreach (var name in this.OtherOriginalNames.EmptyIfNull().Where(z => !string.IsNullOrWhiteSpace(z)))
            {
                yield return name;
            }
        } 
    }
}