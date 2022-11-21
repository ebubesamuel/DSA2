// NAME: SAMUEL CHIDIEBUBE CHIEMELA
// ID NO: 2117053

using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2
{

	public class Company
	{
		public string companyName;
		public Company(string companyname)
		{
			companyName = companyname;
		}
	}

	public  class Department
	{
		public List<Department> departments = new List<Department>();
		public string departmentName;
		public string managerName;
		public List<string> employeeNames = new List<string>();
		List<Department> subDepartment = new List<Department>();
		
		public Department(string deptName, string mgrName, List<Department> subDept, List<string> emplNames) 
        {
			departmentName = deptName;
			managerName = mgrName;
            List<string> employeeNames = emplNames; 
			List<Department> subDepartment = subDept;
			
        }

	}
}



