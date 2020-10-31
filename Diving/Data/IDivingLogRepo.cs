using System.Collections.Generic;
using DivingLogs.Models;

namespace DivingLogs.Data
{
    public interface IDivingLogRepo
    {
        IEnumerable<DivingLog> GetAllDivings();
        DivingLog GetDivingLogById(int id);
    }
}   