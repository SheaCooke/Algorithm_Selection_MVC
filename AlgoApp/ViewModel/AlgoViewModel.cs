using AlgoApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlgoApp.ViewModel
{
    public class AlgoViewModel
    {

        [Required(ErrorMessage ="Must enter some values")]
        public string UserInput { get; set; }

        [Required(ErrorMessage = "This field is required.")] 
        //custom msg to make user slect an algo 
        public Algorithm Algorithm { get; set; }

        public List<SelectListItem> AlgorithmsList = new List<SelectListItem>
            {
                //new SelectListItem(Algorithm.Select.ToString(), ((int)Algorithm.Select).ToString()),
                new SelectListItem(Algorithm.BinarySearch.ToString(), ((int)Algorithm.BinarySearch).ToString())
            };

        public AlgoViewModel() { } 

    }
}
