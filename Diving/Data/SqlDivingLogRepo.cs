using System.Collections.Generic;
using DivingLogs.Models;
using System.Linq;
using System;

namespace DivingLogs.Data
{
    public class SqlDivingLogRepo : IDivingLogRepo
    {
        private readonly DivingLogContext _context;

        public SqlDivingLogRepo(DivingLogContext context){

            _context = context;
        }

        public void CreateDivingLog(DivingLog dl)
        {
            if(dl == null){
                throw new ArgumentNullException(nameof(dl));
            }
            _context.Divings.Add(dl);
        }

        public void DeleteDivingLog(DivingLog dl)
        {
            if(dl == null){
                throw new ArgumentNullException(nameof(dl));
            }
            _context.Divings.Remove(dl);
        }

        public IEnumerable<DivingLog> GetAllDivings()  //retorna datos de la BD en una lista
        {
            return _context.Divings.ToList();
        }

        public DivingLog GetDivingLogById(int id)  // retorna un dato por un ID entregado
        {
            return _context.Divings.FirstOrDefault(p => p.id == id);            
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateDivingLog(DivingLog dl)
        {
            
        }
    }
}