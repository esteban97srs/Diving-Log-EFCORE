using System.Collections.Generic;
using DivingLogs.Models;
using System.Linq;

namespace DivingLogs.Data
{
    public class SqlDivingLogRepo : IDivingLogRepo
    {
        private readonly DivingLogContext _context;

        public SqlDivingLogRepo(DivingLogContext context){

            _context = context;
        }
        public IEnumerable<DivingLog> GetAllDivings()  //retorna datos de la BD en una lista
        {
            return _context.Divings.ToList();
        }

        public DivingLog GetDivingLogById(int id)  // retorna un dato por un ID entregado
        {
            return _context.Divings.FirstOrDefault(p => p.id == id);            
        }
    }
}