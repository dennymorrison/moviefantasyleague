using System;
using System.Configuration;
using System.Web.Mvc;
using MFL.Data;
using MFL.Data.Repository;
using MFL.Data.Repository.Contract;
using MFL.Data.Repository.Mock;

namespace MFL.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly bool _useMock = bool.Parse(ConfigurationManager.AppSettings["UseMockData"]);

        protected IMovieRepository MovieRepository
        {
            get
            {
                if(_useMock)
                    return new MockMovieRepository();
                else
                    return new MovieRepository();
            }
        }

        protected ISeasonRepository SeasonRepository
        {
            get
            {
                if (_useMock)
                    return new MockSeasonRepository();
                else
                    return new SeasonRepository();
            }
        }

        protected IPlayerRepository PlayerRepository
        {
            get
            {
                if (_useMock)
                    return new MockPlayerRepository();
                else
                    return new PlayerRepository();
            }
        }

        protected User CurrentUser
        {
            get
            {
                User result = new User();
                if (_useMock)
                {
                    result = PlayerRepository.GetById(MockDataSource.DennyId);
                }
                else
                {
                    if (Session["User"] != null)
                    {
                        result = Session["User"] as User;
                    }
                    else
                    {
                        if (User.Identity.IsAuthenticated)
                        {
                            // Do a repo lookup....how do i map from that user to a player? ...username ? 

                            Session.Add("User", null);
                        }
                    }
                }

                return result;
            }
        }

        protected Guid GetPlayerLeagueId()
        {
            if (_useMock)
            {
                return MockDataSource.LeagueId;
            }
            else
            {
                // Get the player and then grab the league...or in this version just hardcode the default league id here.
                // Eventually the player could be in multiple leagues so he/she would need to select the league they want to see; or I would need to grab all relevant or something.
                return Guid.NewGuid();
            }
        }        
    }
}