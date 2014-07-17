using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MFL.Data;

namespace MFL.Web.Models
{
    public class PlayerTeamSummaryModel
    {
        public PlayerTeamSummaryModel() { }

        public PlayerTeamSummaryModel(Team t)
        {
            PlayerId = t.User.UserId;
            Player = t.User.Name;
            Season = new SeasonListItemModel() { Id = t.Season.SeasonId, Name = t.Season.Name };

            decimal total = 0;
            List<MovieTeamListModel> movies = new List<MovieTeamListModel>();

            foreach (var m in t.Movies)
            {
                movies.Add(new MovieTeamListModel(m));
                total += m.DomesticGross;
            }

            Movies = movies;
            Total = total;
        }

        public Guid PlayerId { get; set; }

        public string Player { get; set; }

        public SeasonListItemModel Season { get; set; }

        public List<MovieTeamListModel> Movies { get; set; }

        public decimal Total { get; set; }

        public decimal TeamEfficiency { get; set; }
    }
}