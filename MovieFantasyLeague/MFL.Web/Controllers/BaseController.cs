using System;
using System.Configuration;
using System.Web.Mvc;
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

        protected Guid GetPlayerLeagueId()
        {
            if (_useMock)
            {
                return Guid.NewGuid();
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