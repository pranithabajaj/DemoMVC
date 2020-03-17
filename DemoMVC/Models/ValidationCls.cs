using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class ValidationCls
    {
        string firstName;
        string lastName;
        double salary;
        string panCard;
        string password;
        string confirmPassword;
        string phone;
        string email;
        DateTime doj;
        [Required(ErrorMessage ="Firstname is a must")]
        [StringLength(maximumLength:25,ErrorMessage ="Max Length is 25 only")]
        [Display(Name ="First Name")]
        public string FirstName { get => firstName; set => firstName = value; }
        [Required(ErrorMessage ="Lastname is a must")]
        public string LastName { get => lastName; set => lastName = value; }
        [Required(ErrorMessage = "Salary is  must")]
        [Range(10000,200000,ErrorMessage ="Salary must be in between 10000 and 200000")]
        public double Salary { get => salary; set => salary = value; }
        [Required(ErrorMessage = "PanCard is  must")]
        [RegularExpression("^[A-Z]{5}[0-9]{4}[A-Z]$",ErrorMessage ="Not a valid pan number")]
        public string PanCard { get => panCard; set => panCard = value; }
        [Required(ErrorMessage = "Password is  must")]
        public string Password { get => password; set => password = value; }
        [Required(ErrorMessage = "Password is  must")]
        [Compare("Password",ErrorMessage ="Password mismatch")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get => confirmPassword; set => confirmPassword = value; }
        [Required(ErrorMessage = "Phone num is  must")]
        [Phone(ErrorMessage ="Not a valid phone number")]
        [MinLength(10,ErrorMessage ="10 digits only")]
        [MaxLength(10,ErrorMessage ="10 digits only")]
        public string Phone { get => phone; set => phone = value; }
        [Required(ErrorMessage = "Email is  must")]
        [EmailAddress(ErrorMessage ="Not a valid email")]
        public string Email { get => email; set => email = value; }
        [Required(ErrorMessage = "Doj is  must")]
        //[CustomAge(ErrorMessage = "Age must be in between 21 and 58")]
        [CustomDoj(ErrorMessage ="Invalid")]
        
        public DateTime Doj { get => doj; set => doj = value; }
    }
}