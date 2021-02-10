using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MilliganNathaniel413Assignment4.Models
{
    public class Restaurant
    {
        public Restaurant(int Rank)
        {
            this.Rank = Rank;
        }
        public Restaurant()
        {
            Rank = 0;
            FavDish = "It's all tasty!";
            Website = "Coming Soon.";
        }
        //Rank, Restaurant Name, and Address all need to be included. The other fields are optional
        [Required]
        public string SubmitterName { get; set; }
        [Required]
        public int Rank { get; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public string Website { get; set; }
        public string FavDish { get; set; }
        //string? is nullable instead of string which requires an alphanumeric value
        #nullable enable
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Phone number.")]
        public string? PhoneNum { get; set; }



        public static Restaurant[] GetTopRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                Name = "Chick-fil-a",
                FavDish = "Chicken Sandwich",
                Address = "1234 Yeehaw Ln",
                PhoneNum = "321-321-1234",
                Website = "cfa1.com",
                SubmitterName = "nrmill"
            };
            Restaurant r2 = new Restaurant(2)
            {
                Name = "Chick-fil-a2",
                FavDish = "Chicken Sandwich2",
                Address = "2234 Yeehaw Ln",
                PhoneNum = "322-321-1234",
                Website = "cfa2.com",
                SubmitterName = "nrmill"
            };
            Restaurant r3 = new Restaurant(3)
            {
                Name = "Chick-fil-a3",
                FavDish = "Chicken Sandwich3",
                Address = "3234 Yeehaw Ln",
                PhoneNum = "323-321-1234",
                Website = "cfa3.com",
                SubmitterName = "nrmill"
            };
            Restaurant r4 = new Restaurant(4)
            {
                Name = "Chick-fil-a4",
                FavDish = "Chicken Sandwich4",
                Address = "4234 Yeehaw Ln",
                PhoneNum = "324-321-1234",
                Website = "cfa4.com",
                SubmitterName = "nrmill"
            };
            Restaurant r5 = new Restaurant(5)
            {
                Name = "Chick-fil-a5",
                FavDish = "Chicken Sandwich5",
                Address = "5234 Yeehaw Ln",
                PhoneNum = "325-321-1234",
                Website = "cfa5.com",
                SubmitterName = "nrmill"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }

    }
}
