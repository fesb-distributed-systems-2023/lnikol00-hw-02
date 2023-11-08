/*
 **********************************
 * Author: Luka Nikolac
 * Project Task: Airport
 **********************************
 * Description:
 *  
 *  The program has endpoints to:
 *      1. Takes two parameters (Plane name, Airport name) from Route and return response with status OK and text
 *          "Plane {Plane name} lands at {Airport name} Airport :: from route"
 *      2. Takes two parameters (Plane name, Airport name) from Query and return response with status OK and text
 *          "Plane {Plane name} lands at {Airport name} Airport :: from query"
 *      3. Takes one parameter (Airport name) from Body and return response with status OK and textž
 *          "Hello from {Airport name} Airport!"
 *
 **********************************
 */

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirportApplications.Controllers
{
    [ApiController]
    public class AirportController : ControllerBase
    {
        // An endpoint that returns a plane and airport from route
        // Postman request: GET http://localhost:5282/airports/AntonovAn-32/Split
        // Postman response: Plane AntonovAn-32 lands at Split Airport :: from route
        [HttpGet]
        [Route("/airports/{planeName}/{airportName}")]
        public IActionResult GetFromRoute([FromRoute] string planeName, string airportName)
        {
            return Ok($"Plane {planeName} lands at {airportName} Airport :: from route");
        }

        // An endpoint that returns a plane and airport from quey
        // Postman request: GET http://localhost:5282/query?planeName=AntonovAn-124&airportName=Zagreb
        // Postman response: Plane AntonovAn-124 lands at Zagreb Airport :: from query
        [HttpGet]
        [Route("/query")]
        public IActionResult GetFromQuery([FromQuery] string planeName, string airportName)
        {
            return Ok($"Plane {planeName} lands at {airportName} Airport :: from query");
        }

        // An endpoint that returns a plane and airport from body
        // Postman request: POST http://localhost:5282/post
        // Postman response: Hello from Split Airport!
        [HttpPost]
        [Route("/post")]
        public IActionResult GetFromBody([FromBody] string airportName)
        {
            return Ok($"Hello from {airportName} Airport!");
        }
    }
}
