using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AttributesPractice
{
    class User
    {
        [Required(ErrorMessage = "Name Required")]
        [StringLength(20,ErrorMessage ="Name cannot be more than 20 characters")]
        public string Name{ get; set; }

        [Range(18, 60,ErrorMessage ="Age must be in between in 18 and 60")]
        public int Age { get; set; }

        [EmailAddress(ErrorMessage = "Enter valid email address")]
        public string EmailAddress { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Passowrds do not match")]
        public string ConfirmPassword { get; set; }

    }
    internal class Validation
    {
        static void Main()
        {
            Console.WriteLine("Using Validation Attributes");

            User u = new User();

            Console.WriteLine("Enter Name : ");
            u.Name = Console.ReadLine();
            Console.WriteLine("Enter Age : ");
            u.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mail Id : ");
            u.EmailAddress = Console.ReadLine();
            Console.WriteLine("Enter Password : ");
            u.Password = Console.ReadLine();
            Console.WriteLine("Enter Confrim Password : ");
            u.ConfirmPassword = Console.ReadLine();

            //validation engine 

            var context = new ValidationContext(u); // tels  system to validate curr obj

            var results = new List<ValidationResult>(); //collects validation error results 

            bool isValid = Validator.TryValidateObject(
                u, // instance obj
                context, // Validationcontext 
                results, //Validationresults list
                true);// validateAllProperties

            if(isValid)
            {
                Console.WriteLine("Validation Successful");
            }
            else
            {
                Console.WriteLine("Validation Failed");
                foreach(var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
        }
    }
}
