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
            if (t.User != null)
            {
                PlayerId = t.User.UserId;
                Player = t.User.Name;
            }

            if (t.Season != null)
            {
                Season = new SeasonListItemModel() { Id = t.Season.SeasonId, Name = t.Season.Name };
            }

            decimal total = 0;
            List<MovieTeamListModel> movies = new List<MovieTeamListModel>();

            if (t.Movies != null)
            {
                foreach (var m in t.Movies)
                {
                    movies.Add(new MovieTeamListModel(m));
                    total += m.DomesticGross;
                }
            }

            if (t.Season != null)
            {
                if (t.Season.Team != null)
                {
                    if (t.Season.Team.User != null)
                    {
                        ChampionId = t.Season.Team.User.UserId;
                        ChampionName = t.Season.Team.User.Name;
                        ShowSeasonChampion = true;
                    }
                }
            }
            else
            {
                ShowSeasonChampion = false;
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

        public bool ShowPlayerName { get; set; }

        public bool ShowSeasonName { get; set; }

        public bool ShowSeasonChampion { get; set; }

        public Guid ChampionId { get; set; }

        public string ChampionName { get; set; }
    }
}