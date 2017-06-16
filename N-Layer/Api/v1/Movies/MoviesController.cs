using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.v1.Movies
{
    public class MoviesController : ApiController
    {
        public List<MoviesModel> Get() {
            return new List<MoviesModel>();
        }
    }
}
