using System.Collections.Generic;

namespace MARS_ROVER.Model
{
    public class PhotoList
    {

        public List<Photo> Photos{ get; set; }
        public PhotoList(List<Photo> photos)
        {
            Photos = photos;
        }
    }
}