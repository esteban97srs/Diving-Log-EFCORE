using System.Collections.Generic;
using DivingLogs.Models;

namespace DivingLogs.Data
{
    public interface IDivingLogRepo
    {
        bool SaveChanges();
        
        IEnumerable<DivingLog> GetAllDivings();

        DivingLog GetDivingLogById(int id);

        void CreateDivingLog(DivingLog dl);

        void UpdateDivingLog(DivingLog dl);

        void DeleteDivingLog(DivingLog dl);
    }
}   