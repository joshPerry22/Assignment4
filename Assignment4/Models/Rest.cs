

using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class Rest
    {

         public Rest (int rank)
         {
            Rank = rank;
         }
        [Required]
        public int Rank { get;  }
        [Required]
        public string Name { get; set; }
        public string? Dish { get; set; }// = "It's all tasty!";
        [Required]
        public string Address { get; set; }
        public string Phone { get; set; }
        public string? Link { get; set; }// = "Coming Soon!";

        

        public static Rest[] GetRest()
        {
            Rest r1 = new Rest(1)
            {
                
                Name = "Cafe Rio",
                Dish = "Pork Salad",
                Address = "2244 N University Pkwy",
                Phone = "801-375-5133",
                Link = null

            };

            Rest r2 = new Rest(2)
            {
                
                Name = "Burgers Supreme",
                Dish = null,
                Address = "1796 N University Pkwy",
                Phone = "801-373-5713",
                Link = "www.burgerssupreme.com"

            };

            Rest r3 = new Rest(3)
            {
                
                Name = "Cafe Zupas",
                Dish = "Panini Sandwich",
                Address = "408 W 2230 N",
                Phone = "801-377-7687",
                Link = "www.cafezupas.com"

            };

            Rest r4 = new Rest(4)
            {
               
                Name = "JCW's The Burger Boys",
                Dish = null,
                Address = "396 W 2230 N",
                Phone = "801-374-5297",
                Link = "www.jcws.com"

            };

            Rest r5 = new Rest(5)
            {
                
                Name = "McDonalds",
                Dish = null,
                Address = "211 W 1230 N",
                Phone = "801-374-6909",
                Link = null

            };



            return new Rest[] { r1, r2, r3, r4, r5 };
        }


    }
}
