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
         public ActionResult ComputeNumber(int n)
        {
            if (n <= 0)
                return StatusCode(402);
            var fibNumItem = _repository.CalculateFibonacciNumber(n);
            return Ok(fibNumItem);
        }

        [HttpGet("fib_num")]
        public ActionResult <IEnumerable<FibonacciNumberObj>> GetAllFibonaccisInMockDB()
        {
            var fibNumItems = _repository.GetAppFibonaccis();
            return Ok(fibNumItems);
        }
        [HttpGet("fib_num/{n}")]
        public ActionResult <FibonacciNumberObj> GetFibNumBySeq(int n)
        {
            if (n < 0)
            {
                return (StatusCode(204));
            }

            var fibNum = _repository.GetFibNumBySeq(n);
            return Ok(fibNum);
        }
        [HttpPut("fib_num/{seq}_{val}")]
        // does check the correct input
        // needs to be fixed --> does not make changes to the list of fibonaccis
        public ActionResult CreateRecord(int seq, int val)
        {
             if (_repository.CheckRecordForSave(seq, val) == true)
                {
                    _repository.CreateFibonacciRecord(seq, val);
                    // created
                    return (StatusCode(201));
                }  
             else
                return StatusCode(402);
        }
        [HttpDelete("fib_num/{n}")]
        public ActionResult DeleteFibNum(int n)
        {
            var inRepo = _repository.GetFibNumBySeq(n);
            if(n == 0)
            {
                return NotFound();
            }
            _repository.DeleteFibonacciRecord(n);
            return NoContent();
        }
     }
 }