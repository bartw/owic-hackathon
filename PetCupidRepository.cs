using System.Collections.Generic;
using System.Linq;

namespace PetCupid
{
    public class PetCupidRepository
    {
        private List<PetCupid> _data;

        public PetCupidRepository()
        {
          _data = new List<PetCupid>();

          _data.Add(new PetCupid{
              Id = 1,
              Name= "Princess",
            Kind= "chicken",
            Img= "images/chicken1.jpg",
            ProfileText= "Meet Princess Fluffybutt! She is one of the fluffiest chickens you will ever meet. Most often you'll find Princess cuddled up in the warmest spot she can find, and if that happens to be in your lap, well then that's fine for her too! Princess also enjoys nomming treats out of your hand, clucking softly under her breath, and following her three sisters around the yard. Get to know Princess today!",
            Popularity= 0
          });
        }

        public IEnumerable<PetCupid> Get()
        {
            return _data;
        }

        public PetCupid Get(int id)
        {
            return _data.SingleOrDefault(pc => pc.Id == id);
        }
    }
}