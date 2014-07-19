using MFL.Data;
using System;
using System.Collections.Generic;

namespace MFL.Web.Models
{
    public class PlayerDetailsModel
    {
        public PlayerDetailsModel() 
        {
            Teams = new List<PlayerTeamSummaryModel>();
        }

        public PlayerDetailsModel(User u)
            : this()
        {
            PlayerId = u.UserId;
            Name = u.Name;
        }

        public Guid PlayerId { get; set; }

        public string Name { get; set; }

        public IList<PlayerTeamSummaryModel> Teams { get; set; }
    }
}