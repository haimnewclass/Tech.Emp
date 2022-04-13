using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tech.Emp.Model;
namespace Tech.Emp.Dal
{
    public class LoadEmpFile
    {
        private const string fileName = @"C:\Users\haim\source\repos\Tech.Emp\Tech.Emp.Dal\EmployeeData.json";
        private const string TblFleName = @"C:\Users\haim\source\repos\Tech.Emp\Tech.Emp.Dal\EmployeeDataTbl.json";
        public Employee[] DeserilizationEmp()
        {
            string data = System.IO.File.ReadAllText(fileName);
            Employee[] list = JsonSerializer.Deserialize<Employee[]>(data);

            return list;
        }

        public void Save(Dictionary<int, Employee> tbl )
        {
            var str = JsonSerializer.Serialize(tbl);
            System.IO.File.WriteAllText(TblFleName, str);
        }

        public Dictionary<int, Employee> Load()
        {
            var str = System.IO.File.ReadAllText(TblFleName);

            var ret = JsonSerializer.Deserialize<Dictionary<int, Employee>>(str);

            return ret;
        }
        public Dictionary<int, Employee> LoadEmployeeTable()
        {
            Dictionary<int, Employee> tbl = new Dictionary<int, Employee>();
            var arr =  DeserilizationEmp();

            for (int i = 0; i < arr.Length; i++)
            {
                tbl.Add(arr[i].id, arr[i]);
            }

            return tbl;
        }

    }
}
