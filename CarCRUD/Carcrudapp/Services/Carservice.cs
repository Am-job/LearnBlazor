using Carcrudapp.Models;


namespace Carcrudapp.Services
{
    public class Carservice
    {

        public List<Cardata> Carlist = new List<Cardata>
                {
                     new Cardata { Id = 1, Name = "ToyotaMarkII", Model="Toyota Mark II 2001",  BrandId = 1, Color="Gray", NPerson=4 },
                     new Cardata { Id = 2, Name = "TatayoSerkI", Model="TatayoSerkI 2099 HGS",  BrandId = 1, Color="White", NPerson=5 },
                     new Cardata { Id = 3 , Name = "SuzukiSwift", Model="Suzuki Swift 2019 (GLX)",  BrandId = 2, Color="Black", NPerson=4  },
                     new Cardata { Id = 4, Name = "SuzukiSwiftII", Model="Suzuki Swift 2020 (GLX)", BrandId = 2, Color="White", NPerson=4  },
                     new Cardata { Id = 5, Name = "MitsubishiEclipse", Model="Mitsubishi Eclipse Cross 2019", BrandId = 3,  Color="White", NPerson=5  },
                     new Cardata { Id = 6, Name = "MitsubishiEclipseII", Model="Mitsubishi Eclipse Mark 2020", BrandId = 3, Color="Black", NPerson=4  },
                     new Cardata { Id = 7, Name = "Nissan AD", Model="Nissan AD Van 2010", BrandId = 4, Color="Purple", NPerson=4 },
                     new Cardata { Id = 8, Name = "Nissan MD HLX", Model="Nissan MD 2015",  BrandId = 4, Color="Grey", NPerson=5 },
                     new Cardata { Id = 9, Name = "Honda CR", Model="Honda CR-V 2012",Color="White", BrandId = 5, NPerson=5 },
                     new Cardata { Id = 10, Name = "Honda Optima", Model="Honda Optima 2019 (GT Line)", BrandId = 5, Color="Red", NPerson=4 },
                     new Cardata { Id = 11, Name = "Ferrari Abarth 695", Model="Abarth 695 Tributo Ferrari 2011", BrandId = 6,  Color="Red", NPerson=4 },
                     new Cardata { Id = 12, Name = "Ferrari Optima", Model="Ferrari Optima 2019 (GTX Orange)", BrandId = 6,  Color="Orange", NPerson=4 },
                     new Cardata { Id = 13, Name = "Chevrolet Trax", Model="Chevrolet Trax 2023",  BrandId = 7, Color="White", NPerson=5 },
                     new Cardata { Id = 14, Name = "Chevrolet Optima", Model="Chevrolet Optima 2013 (GTA)", BrandId = 7,  Color="Red", NPerson=4 },
                };

        public List<CarBrandObj> carBrand = new List<CarBrandObj>
                {
                    new CarBrandObj { Id = 1, Name = "Toyota" },
                    new CarBrandObj { Id = 2, Name = "Suzuki"},
                    new CarBrandObj { Id = 3, Name = "Mitsubishi"},
                    new CarBrandObj { Id = 4, Name = "Nissan"},
                    new CarBrandObj { Id = 5, Name = "Honda"},
                    new CarBrandObj { Id = 6, Name = "Ferrari"},
                    new CarBrandObj { Id = 7, Name = "Chevrolet"}
                };


        public void AddCarList ( Cardata cardata )
        {
            Carlist.Add(cardata);
        }  

        public void DeleteCarlist ( Cardata cardata )
        {
            Carlist.Remove(cardata);
           
        }

        public void AddBrand ( CarBrandObj brandobj)
        {
               carBrand.Add(brandobj);
        }
        public void DeleteBrand (CarBrandObj brandobj)
        {
            carBrand.Remove(brandobj);
        }

        public void getId ( )
        {
          Carlist?.Last();
        }
    }


}