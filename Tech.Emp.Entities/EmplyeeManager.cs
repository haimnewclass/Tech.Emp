using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tech.Emp.Dal;
namespace Tech.Emp.Entities
{
    public class EmplyeeManager
    {
        private Dictionary<int, Tech.Emp.Model.Employee> EmployeeTable = new Dictionary<int, Model.Employee>();
        public void Load()
        {
            // load data from file
            LoadEmpFile loadEmpFile = new LoadEmpFile();
            EmployeeTable =  loadEmpFile.LoadEmployeeTable();
        }

        public void RemoveEmployee(int id)
        {
            if (EmployeeTable.ContainsKey(id))
                EmployeeTable.Remove(id);
        }

        public Tech.Emp.Model.Employee GetEmployeeById(int id)
        {
            Tech.Emp.Model.Employee ret = null;

            if(EmployeeTable.ContainsKey(id))
                ret = EmployeeTable[id];

            return ret; ;
        }

        public void Save()
        {
            LoadEmpFile loadEmpFile = new LoadEmpFile();
            loadEmpFile.Save(EmployeeTable);
        }
    }
}
