
using System;
using System.Reflection;

//*Section 5: Custom Attribute*

//1️⃣1️⃣ Create a **custom attribute `BookCategoryAttribute`**

//Allowed categories:

//• Fiction
//• Science
//• Technology
//• History
//• Biography

//Apply this attribute to the **Category property**.

namespace LibraryManagementApp

{
    [AttributeUsage(AttributeTargets.Property)]
    public class BookCategoryAttribute : Attribute
    {
        public static readonly string[] AllowedCategories =
        {"Fiction","Science","Technology","History","Biography"};

        // category validator
        public static void ValidateCategory(object obj)
        {
            Type type = obj.GetType(); // creatng obj of type

            foreach (PropertyInfo prop in type.GetProperties()) // loop get properties 
            {
                if (Attribute.IsDefined(prop, typeof(BookCategoryAttribute))) // check if has book atttri
                {
                    string categoryValue = prop.GetValue(obj)?.ToString(); 

                    bool valid = false; 

                    foreach (var category in AllowedCategories)
                    {
                        if (category.Equals(categoryValue)) //check if curr category is allowed
                        {
                            valid = true;
                            break;
                        }
                    }

                    if (!valid)
                    {
                        throw new InvalidCategoryException(
                            $"Category '{categoryValue}' is invalid."
                        );
                    }
                }
            }
        }
    }
}