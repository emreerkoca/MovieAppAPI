using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MovieApp.API.Data;
using MovieApp.API.Dtos;
using MovieApp.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IMovieRepository _appRepository;

        public MovieController(IMovieRepository appRepository)
        {
            _appRepository = appRepository;
        }

        [HttpPost]
        [Route("InsertMovieToDb")]
        public ActionResult InsertMovieToDb([FromBody] Movie movie)
        {
            _appRepository.Add(movie);
            return Ok(movie);
        }
    }
}