namespace DivingLogs.Dtos
{
    public class DivingLogCreateDto{
        
        public string DateLog { get; set; }

        public string WindDirection { get; set; }

        public string SurfaceCurrent { get; set; }

        public string DivingPermit { get; set; }

        public string WaveHeight { get; set; }
        
        public string DiversNumber { get; set; }
    
        public string Observations { get; set; }
    }
}