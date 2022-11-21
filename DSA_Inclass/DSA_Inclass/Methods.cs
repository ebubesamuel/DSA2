// NAME: SAMUEL CHIDIEBUBE CHIEMELA
// ID NO: 2117053

using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DSA2
{
	public class Methods
	{
		public static Department FindDepartment(Department tree, string deptName )
		{
			foreach(var department in tree.departments)
			{
				if(department.departmentName== deptName)
				{
					return department;
				}
				var index = FindDepartment(department, deptName);
                if(index==null)
                {
                    continue;
                }
                return index;


			}
			return null;

		}

        public static string FindEmployee(Department tree, string employeeName)
        {
            foreach (var department in tree.departments)
            {
                foreach (var employee in department.employeeNames)
                {
                    if(employee.Equals(employeeName))
                    {
                        return employee;
                    }
                }
            }
            return null;
        }
		public static void AddDepartment(Department tree, string position, Department department)
		{
			var index = FindDepartment(tree, position);
			index.departments.Add(department);
		}

        public static void AddEmployee(Department tree, string position, string employee)
        {
            var index = FindDepartment(tree, position);
            index.employeeNames.Add(employee);
        }

        public static void RemoveDepartment(Department tree, string position)
        {
            tree.departments.RemoveAll(d => d.departmentName == position);
            foreach (var department in tree.departments)
            {

                department.departments.RemoveAll(d => d.departmentName == position);
                RemoveDepartment(department, position);
            }
        }
        
        public static void RemoveEmployee(Department tree, string employee)
        {
            foreach (var child in tree.employeeNames)
            {
                if (child==employee)
                {
                    tree.employeeNames.Remove(child);
                }
            }
            foreach (var department in tree.departments)
            {
                foreach (var child in department.employeeNames)
                {
                    if (child==employee)
                    {
                        department.employeeNames.Remove(child);
                    }
                }
            }
        }

        
        public static  void PrintAllDepartments(Department tree)
		{
			foreach (var department in tree.departments)
			{
				Console.WriteLine(" ".PadLeft(department.departments.Count * 5) +  department.departmentName);
				PrintAllDepartments(department);
			}


		}

        public static void PrintAllEmployees(Department tree)
        {
            foreach (var department in tree.departments)
            {
                Console.Write(" ".PadLeft(department.departments.Count * 5) + department.departmentName +" Employees: ");

                foreach (var employee in department.employeeNames)
                {
                    Console.Write(employee + " \n") ;

                }
                PrintAllEmployees(department);
            }


        }

        public static void MoveDepartment(Department tree, string position, string department)
        {
			var departmentName = FindDepartment(tree, department);
            RemoveDepartment(tree, department);
            AddDepartment(tree, position, departmentName);
        }

        

        public static void AddEmployee(Department tree, string position, List<string> employeeName)
        {
            var index = FindDepartment(tree, position);
                index.employeeNames.AddRange(employeeName);
        }

        public static void MoveEmployees(Department tree, string position, string employee)  
        {
            var departmentName = FindDepartment(tree, position);
            RemoveEmployee(tree, employee);
            AddEmployee(tree, position, employee);
        }
        static int index = 0;

        public static int CalcNoOfEmplInDept(Department tree)
        {
            foreach (var department in tree.departments)
            {

                index += department.employeeNames.Count();
                CalcNoOfEmplInDept(department);
            }
            return index;
        }

    }
}


