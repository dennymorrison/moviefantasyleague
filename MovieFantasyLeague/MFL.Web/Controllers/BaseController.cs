using MFL.Data.Repository;
using MFL.Data.Repository.Contract;
using MFL.Data.Repository.Mock;
using System.Web.Mvc;

namespace MFL.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly bool _useMock = true;

        protected IMovieRepository GetMovieRepository()
        {
            if (_useMock)
                return new MockMovieRepository();
            else
                return new MovieRepository();
        }
    }
}