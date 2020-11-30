using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace DetectiveAgency.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(10, 75, ErrorMessage = "Hours must be between 10 and 75.")]
        public double Hours { get; set; }
       [Required]
       [Range(15,75, ErrorMessage ="Rate should be between $15 and $75.")]
       public double Rate { get; set; }
      public double CalcSalary()
        {
            double grossPay = 0;
            double overtime = 0;
            double regPay = 0;
            if (Hours>40)
            {
                regPay = 40 * Rate;
                overtime = (Hours - 40) * (1.5 * Rate);
            }
            else
            {
                regPay = Hours * Rate;
            }
            grossPay = regPay + overtime;
            return grossPay;
        }
       
    }
}
