using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using myModels.Interfaces; 
namespace תשתית_לניהול_חנות_פיצה_חני_גולדברג.Controllers;

public class ChanisPizzaController : BaceController
{
      IpizzaMannager _chanisPizza;
      public ChanisPizzaController(IpizzaMannager pizza)
      {
            _chanisPizza = pizza;
      }
      [Route("[action]")]
      [HttpGet]
      public IActionResult getPizzaList()
      {
            var p1 = _chanisPizza.getPizzaList();
            if (p1 != null)
                  Ok(p1);
            return NotFound("pizza list!!!!");
      }
      [Route("[action]/{id}")]
      [HttpGet]
      public IActionResult getPizza(int id)
      {
            var p2 = _chanisPizza.getPizzaById(id);
            if (p2 != null)
                  Ok(p2);
            return NotFound("pizza list!!!!");
      }

      [Route("~/[controller]/getPizzaByName/{name}")]
      [HttpGet]
      public IActionResult getPizzaByName(string name)
      {
            var p3 = _chanisPizza.getPizzaByName(name);
            if (p3 != null)
                  return Ok("pizzaName: " + p3.pizzaName + " id: " + p3.pizzaId + " with gloten? " + p3.ifGloten);
            return NotFound("there is no pizza with this id!!!!");
      }

      [Route("[action]/{name}/{id}/{ifGloten}")]
      [HttpPost]
      public IActionResult setPizza(string name, int id, bool ifGloten)
      {
            _chanisPizza.setPizza(name, id, ifGloten);
            return Created();
      }

      [Route("[action]/{id}")]
      [HttpDelete]
      public IActionResult deletePizza(int id)
      {

            bool b = _chanisPizza.deletePizza(id);
            if (b == true)
                  return Ok();
            return NotFound("there is no pizza with this id!!!!");
      }


      [Route("[action]/{id}/{ifGloten}")]
      [HttpPut]
      public IActionResult updatePizza(int id, bool ifGloten)
      {
            bool bb = _chanisPizza.updatePizza(id, ifGloten);
            if (bb == true)
                  return Ok($"yes we apdate pizza {id} to {ifGloten}");
            return NotFound("there is no pizza with this id!!!!");
      }
}
