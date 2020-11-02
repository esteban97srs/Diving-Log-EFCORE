namespace DivingLogs.Dtos
{
    public class DivingLogUpdateDto{
        public string date_log { get; set; }

        public string wind_direction { get; set; }

        public string surface_current { get; set; }

        public string diving_permit { get; set; }

        public string wave_height { get; set; }
        
        public string divers_number { get; set; }
    
        public string observations { get; set; }
    }
}