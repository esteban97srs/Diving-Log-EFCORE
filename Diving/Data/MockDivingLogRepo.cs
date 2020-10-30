using System.Collections.Generic;
using DivingLogs.Models;

namespace DivingLogs.Data
{
    public class MockDivingLogRepo : IDivingLogRepo
    {
        public IEnumerable<DivingLog> GetAppDivings()
        {
            var divings = new List <DivingLog>
            {
                new DivingLog { id = 0, date_log = "22/10/2020",wind_direction = "viento 1", surface_current = "corriente 0", diving_permit = "permiso 0", wave_height = "altura 0", divers_number = "2", observations = "sin observaciones"},                                
                new DivingLog { id = 1, date_log = "22/10/2020",wind_direction = "viento 2", surface_current = "corriente 0", diving_permit = "permiso 0", wave_height = "altura 0", divers_number = "2", observations = "sin observaciones"},
                new DivingLog { id = 2, date_log = "22/10/2020",wind_direction = "viento 4", surface_current = "corriente 0", diving_permit = "permiso 0", wave_height = "altura 0", divers_number = "2", observations = "sin observaciones"}
            };

            return divings;
        }
        public DivingLog GetDivingLogById(int id)
        {
            return new DivingLog { id = 0, date_log = "22/10/2020", wind_direction = "viento 1", surface_current = "corriente 0", diving_permit = "permiso 0", wave_height = "altura 0", divers_number = "2", observations = "sin observaciones" };
        }
    }
}