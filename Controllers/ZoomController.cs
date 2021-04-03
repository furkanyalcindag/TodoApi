using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZoomController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ZoomController> _logger;

        public ZoomController(ILogger<ZoomController> logger)
        {
            _logger = logger;
        }

        

        [HttpGet]
        public string Get()
        {


          /*  List<Reservation> reservationList = new List<Reservation>();
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization 
                         = new AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOm51bGwsImlzcyI6IllNbVJCV2ZfVFNPemVqRV9BYjZhalEiLCJleHAiOjE2MTgwODQzMjEsImlhdCI6MTYxNzQ3OTUyMn0.h05kFThPmESahWLDVfXQeHfmIkIiRRzm5vTF7_ebOIc");
                using (var response = httpClient.GetStringAsync("https://api.zoom.us/v2/users/eh0_muNMTvyU2Ddtq3J9Mg/meetings"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _logger.LogInformation(apiResponse);
                }
            }


            return null;
*/
         using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization 
                         = new AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOm51bGwsImlzcyI6IllNbVJCV2ZfVFNPemVqRV9BYjZhalEiLCJleHAiOjE2MTgwODQzMjEsImlhdCI6MTYxNzQ3OTUyMn0.h05kFThPmESahWLDVfXQeHfmIkIiRRzm5vTF7_ebOIc");
               var response = httpClient.GetStringAsync("https://api.zoom.us/v2/users/eh0_muNMTvyU2Ddtq3J9Mg/meetings").Result;
                {
                    string apiResponse = response;
                    _logger.LogInformation(apiResponse);
                }

                  return response;
            }


          
          
        }
    }
}
