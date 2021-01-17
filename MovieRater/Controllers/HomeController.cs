using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRater.Models;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using static MovieRater.MyContext;

namespace MovieRater.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyContext _dbContext;

        public HomeController(MyContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
           if(_dbContext.Films.Count() == 0)
           {
               HttpClient client = new HttpClient();
               HttpResponseMessage response = await client.GetAsync("https://swapi.dev/api/films/");
               string responseBody = await response.Content.ReadAsStringAsync();
               Root root = JsonConvert.DeserializeObject<Root>(responseBody);
               foreach(var film in root.results)
               {
                    _dbContext.Add(new Film {
                        title = film.title,
                        opening_crawl = film.title,
                        director = film.director,
                        producer = film.producer,
                        release_date = film.release_date,
                        url = film.url,
                        numberOfVotes = 0,
                        avg = 0
                    });
               }
                _dbContext.SaveChanges();
               return View(root);
           }
           List<Film> films = _dbContext.Films.ToList();
           return View(new Root(films));
        }        

        public IActionResult Details(string title)
        {
            Film film = _dbContext.Films.Where(f => f.title == title).FirstOrDefault();
            return View(film);
        }


        [HttpPost]
        public IActionResult Details(string title, int vote)
        {
            Film film = _dbContext.Films.Where(f => f.title == title).FirstOrDefault();
            float newAvg = Helpers.GetAverage(film.avg, film.numberOfVotes, vote);
            film.numberOfVotes++;
            film.avg = newAvg;
            _dbContext.SaveChanges();
            return View(film);
        }
    }
}
