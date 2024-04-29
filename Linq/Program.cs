namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();


             Species specieCougar = new Species { Name = "cougars Blancs", SpeciesId = Guid.NewGuid() };

            Species specieTigre = new Species { Name = "tigres Blancs", SpeciesId = Guid.NewGuid() };

            Species specieTortue = new Species { Name = "tortue Albinos", SpeciesId = Guid.NewGuid() };
          

            for (int i = 0; i < 3; i++)
            {

                Animal animal = new Animal();
                animal.Name = "Cougar" ;
                animal.Species = specieCougar;
                animals.Add(animal);
               
            }

            Console.WriteLine("Il reste " +animals.Where(a => a.Species.Name == "cougars Blancs").Count() + specieCougar.Name);



            for (int i = 0; i < 100; i++)
            {
                Animal animal= new Animal();
                animal.Name = "Tigre " ;
                  animal.Species = specieTigre;
                animals.Add(animal);
                
            }

            Console.WriteLine("Il reste " +animals.Count(a => a.Species.Name == "tigres Blancs") + specieTigre.Name);

            for (int i = 0; i <15; i++)
            {
                Animal animal= new Animal();
                animal.Name = "tortue ";
                animal.Species = specieTortue;
                animals.Add(animal);   

            
            }
            Console.WriteLine("Il reste " +animals.Count(a=>a.Species.Name== "tortue Albinos") + specieTortue.Name);


        }

    }
}

