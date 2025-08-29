using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; set; } = new CitiesDataStore();

        public CitiesDataStore() {
            //Cities = new List<CityDto>()
            //{
            //      new CityDto()
            //      {
            //          Id = 1,
            //          Name = "New York City",
            //          Description = "The one with taht big park."
            //      },
            //      new CityDto()
            //      {
            //          Id = 2,
            //          Name = "Antwerp",
            //          Description = "the one with the cathedral that was never really finished."
            //      }, 
            //      new CityDto()
            //      {
            //          Id = 3,
            //          Name = "Paris",
            //          Description = "The one with the big tower."
            //      }
            //};

            Cities = new List<CityDto>()
            {
                new CityDto()
                  {
                      Id = 1,
                      Name = "New York City",
                      Description = "The one with taht big park.",
                      PointsOfInterest = new List<PointsOfInterestDto>()
                      {
                          new PointsOfInterestDto()
                          {
                              Id = 1,
                              Name = "Central Park",
                              Description = "The most visited park"
                          },
                          new PointsOfInterestDto()
                          {
                              Id = 2,
                              Name = "Empire State Building",
                              Description = "The most visited park"
                          }
                      }
                  },
                  new CityDto()
                  {
                      Id = 2,
                      Name = "Antwerp",
                      Description = "the one with the cathedral that was never really finished.",
                      PointsOfInterest = new List<PointsOfInterestDto>()
                      {
                          new PointsOfInterestDto()
                          {
                              Id = 3,
                              Name = "Anties",
                              Description = "The most visited park"
                          },
                          new PointsOfInterestDto()
                          {
                              Id = 4,
                              Name = "Werpies Building",
                              Description = "The most visited park"
                          }
                      }
                  },
                  new CityDto()
                  {
                      Id = 3,
                      Name = "Paris",
                      Description = "The one with the big tower.",
                      PointsOfInterest = new List<PointsOfInterestDto>()
                      {
                          new PointsOfInterestDto()
                          {
                              Id = 5,
                              Name = "Towerrr",
                              Description = "The most visited park"
                          },
                          new PointsOfInterestDto()
                          {
                              Id = 6,
                              Name = "Eifel Towerz",
                              Description = "The most visited park"
                          }
                      }
                  }
            };

        }
    }
}
