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
    
    public partial class Season
    {
        public Season()
        {
            this.Movies = new HashSet<Movie>();
            this.Teams = new HashSet<Team>();
        }
    
        public System.Guid SeasonId { get; set; }
        public string Name { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public System.DateTime StartEdits { get; set; }
        public System.DateTime EndEdits { get; set; }
        public string Note { get; set; }
        public int Budget { get; set; }
        public Nullable<System.Guid> ChampionTeamId { get; set; }
    
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
