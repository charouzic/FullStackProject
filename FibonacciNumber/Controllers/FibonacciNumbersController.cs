using Microsoft.AspNetCore.Mvc;
using FibonacciNumber.Data;
using FibonacciNumber.Models;
using System.Collections.Generic;

namespace FibonacciNumber.Controllers
 {
     //api/compute/{sequence}
     //[Route("api")]
     [Route("")]
     [ApiController]
     public class FibonacciNumbersController : ControllerBase
     {
        private readonly IFibonacciNumberRepo _repository;

        public FibonacciNumbersController(IFibonacciNumberRepo repository)
         {
             _repository = repository;
         }
         [HttpGet("compute/{n}")]
         public IActionResult ComputeNumber(int n)
         {
            var fibNumItem = _repository.CalculateFibonacciNumber(n);
            return Ok(fibNumItem);
         }
     }
 }