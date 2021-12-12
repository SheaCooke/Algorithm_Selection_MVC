using AlgoApp.Data;
using AlgoApp.Models;
using AlgoApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgoApp.Controllers
{
    public class UserController : Controller
    {
        
       
       // [Route("/user/index/{id?}")]
        public IActionResult Index(/*[FromRoute]string id = ""*/) 
        {
           

            AlgoViewModel vm = new AlgoViewModel();
            
            return View(vm);
        }

        //method to take all user input, and then based on the selection from the drop down menu, call the appropriate function after validating input 

        [HttpPost]
        public IActionResult IndexPost(AlgoViewModel vm)
        {
            if (ModelState.IsValid)
            {
                if (vm.Algorithm.Equals(Algorithm.BinarySearch))
                {
                    ResponseData.Responses.Add(new results("working!!!!"));
                }


                return Redirect("Index");

            }
            

            

         

            return View("Index", vm);
        }
    }
}
