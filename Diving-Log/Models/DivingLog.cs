namespace DivingLog.Models
{
    public class DivingLog{
        public int Id { get; set; }

        public string date_log { get; set; }

        public string wind_direction { get; set; }

        public int surface_current { get; set; }

        public string diving_permit { get; set; }

        public int wave_height { get; set; }
        
        public int number_divers { get; set; }
    
        public string observations { get; set; }
    }
}