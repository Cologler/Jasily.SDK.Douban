using System;
using System.Runtime.Serialization;

namespace Jasily.SDK.Douban.Entities
{
    [DataContract]
    public class Movie : BaseEntity
    {
        [DataMember(Name = "images")]
        public Images Images { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "original_title")]
        public string OriginalTitle { get; set; }

        [DataMember(Name = "year")]
        public string Year { get; set; }

        /// <summary>
        /// "movie" or "TV"
        /// </summary>
        [DataMember(Name = "subtype")]
        public string SubType { get; set; }

        [DataMember(Name = "seasons_count")]
        public int? SeasonsCount { get; set; }

        [DataMember(Name = "episodes_count")]
        public string EpisodesCount { get; set; }

        [DataMember(Name = "current_season")]
        public string CurrentSeason { get; set; }
    }
}