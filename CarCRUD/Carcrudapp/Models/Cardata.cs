
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace Carcrudapp.Models
{
  
        public class Cardata : ICloneable
        {
        public int Id { get; set; } = 0;

            public string? Name { get; set; }

            public string? Model { get; set; }

            public string? Color { get; set; }

            public int BrandId { get; set; }

            public int NPerson { get; set; }

            public object Clone()
            {
                return this.MemberwiseClone();
            }
        }

    public class CarBrandObj : ICloneable
    {
        public int Id { get; set; } = 0;

        public string? Name { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    

}
