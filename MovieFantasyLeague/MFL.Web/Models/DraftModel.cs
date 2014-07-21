using System;
using System.Collections.Generic;
using MFL.Data;

namespace MFL.Web.Models
{
    public class DraftModel
    {
        public DraftModel()
        {
            Movies = new List<MovieDraftListModel>();
        }

        public DraftModel(Season s, User u)
        {
            SeasonId = s.SeasonId;
            SeasonName = s.Name;
            StartEditDate = s.StartEdits;
            EndEditDate = s.EndEdits;
            IsEditable = (DateTime.Now >= s.StartEdits && DateTime.Now <= s.EndEdits);
            Budget = s.Budget;

            PlayerId = u.UserId;
            Player = u.Name;
        }

        public IList<MovieDraftListModel> Movies { get; set; }

        public Guid PlayerId { get; set; }

        public string Player { get; set; }

        public Guid SeasonId { get; set; }

        public string SeasonName { get; set; }

        public int Budget { get; set; }

        public int Spent { get; set; }

        public DateTime StartEditDate { get; set; }

        public DateTime EndEditDate { get; set; }

        public bool IsEditable { get; set; }
    }
}