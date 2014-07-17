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
    
    public partial class League
    {
        public League()
        {
            this.Teams = new HashSet<Team>();
            this.Users = new HashSet<User>();
        }
    
        public System.Guid LeagueId { get; set; }
        public string Name { get; set; }
        public bool IsPrivate { get; set; }
        public System.Guid OwnerId { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}