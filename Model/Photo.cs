namespace MARS_ROVER.Model
{
    public class Photo
    {
        
        public int ID { get; set; } 
        public string Earth_Date { get; set; }   
        public string Img_Src { get; set; }  
        public string Sol { get; set; } 
        public Camera Camera { get; set; } 
        public Rover Rover { get; set; }    
        

    }
}