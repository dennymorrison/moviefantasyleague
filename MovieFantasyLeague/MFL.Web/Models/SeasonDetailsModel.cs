using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MFL.Data;

namespace MFL.Web.Models
{
    public class SeasonDetailsModel
    {
        public SeasonDetailsModel() 
        {
            Standings = new StandingsModel();
            PlayerSummaries = new List<PlayerTeamSummaryModel>();
        }

        public SeasonDetailsModel(Season s)
            : this()
        {
            Id = s.SeasonId;
            Name = s.Name;
            Notes = s.Note;
            StartDate = s.StartDate;
            EndDate = s.EndDate;
            StartEditDate = s.StartEdits;
            EndEditDate = s.EndEdits;
            EndTotalUpdateDate = s.LastUpdateDate;
            Budget = s.Budget;

            if(s.Team!=null)
            {
                if(s.Team.User!=null)
                {
                    Champion = s.Team.User.Name;
                }
            }            

            if (StartDate <= DateTime.Now && EndDate >= DateTime.Now)
            {
                Status = SeasonStatus.OnGoing;
            }
            else if (StartDate > DateTime.Now)
            {
                Status = SeasonStatus.Planned;
            }
            else if (StartEditDate <= DateTime.Now && EndEditDate >= DateTime.Now)
            {
                Status = SeasonStatus.DraftPeriod;
            }
            else
            {
                Status = SeasonStatus.Completed;
            }
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime StartEditDate { get; set; }

        public DateTime EndEditDate { get; set; }

        public DateTime EndTotalUpdateDate { get; set; }

        public string Champion { get; set; }

        public Guid ChampionId { get; set; }

        public int Budget { get; set; }

        public string Notes { get; set; }

        public StandingsModel Standings { get; set; }

        public SeasonStatus Status { get; set; }

        public IList<PlayerTeamSummaryModel> PlayerSummaries { get; set; }
    }
}