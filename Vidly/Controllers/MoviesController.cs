﻿using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
  public class MoviesController : Controller
  {
    public ApplicationDbContext _context;

    public MoviesController()
    {
      _context = new ApplicationDbContext();
    }

    protected override void Dispose(bool disposing)
    {
      _context.Dispose();
    }

    public ActionResult Random()
    {
      var movie = new Movie() {Name = "Shrek!" };

      var customers = new List<Customer>
      {
        new Customer {Name = "Customer 1"},
        new Customer {Name = "Customer 2"}
      };

      var viewModel = new RandomMovieViewModel
      {
        Movie = movie,
        Customers = customers
      };

      return View(viewModel);
    }

    public ViewResult Index()
    {
      var movies = _context.Movies.Include(m => m.Genre).ToList();
      return View(movies);    
    }

    public ViewResult Details(int id)
    {
      var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
      return View(movie);
    }


  }
}