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
                return Guid.NewGuid();
            else
                return Guid.NewGuid();
        }

        protected Guid GetCurrentSeasonId()
        {
            if (_useMock)
            {
                return Guid.NewGuid();
            }
            else
            {
                // Figure out the season that we should be after....dates of seasons current date etc.

                return Guid.NewGuid();
            }
        }
    }
}