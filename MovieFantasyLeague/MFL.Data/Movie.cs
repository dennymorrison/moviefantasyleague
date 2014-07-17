//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MFL.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movie
    {
        public Movie()
        {
            this.Teams = new HashSet<Team>();
        }
    
        public System.Guid MovieId { get; set; }
        public string Name { get; set; }
        public int DraftCost { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public decimal DomesticGross { get; set; }
        public string BoxOfficeMojoLink { get; set; }
        public string PosterLink { get; set; }
        public System.Guid SeasonId { get; set; }
        public string Note { get; set; }
        public bool IsReplacement { get; set; }
    
        public virtual Season Season { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
