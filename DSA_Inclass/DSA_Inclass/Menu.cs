// NAME: SAMUEL CHIDIEBUBE CHIEMELA
// ID NO: 2117053

using System;
namespace DSA2
{
	public class Menu
	{
		static public void Start()
		{
            while (true)
            {
                var company = Program.CreateCompanyTree();
                Console.WriteLine("***\t WELCOME TO EXTRAMUS COMPANY DEPARTMENTS SURVEY \t***");
                Console.WriteLine("input from the options below: ");
                Console.WriteLine("1. Display all departments, 2. Add departments, 3. Remove departments, " +
                    "4. Move employees to another department, 5. Move one Sub-department to another" +
                    "6. Calculate the number of employees in a department");
                Console.WriteLine("OPtion selected: ");
                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Methods.PrintAllDepartments(company);
                        break;
                    case 2:
                        Console.WriteLine("Which position would you like to add a department?: ");
                        string depInput = Console.ReadLine();
                        Console.WriteLine("Please input the name of Department, manager name, list of subdepartments and employees: ");
                        Department newDepartment = new Department(Console.ReadLine(), Console.ReadLine(), new List<Department>(), new List<string>());
                        Methods.AddDepartment(company, depInput,newDepartment);
                        break;

                    case 3:
                        Console.WriteLine("Which department would you like to delete?: ");
                        string deleteInput = Console.ReadLine();
                        Methods.RemoveDepartment(company, deleteInput);
                        break;

                    case 4:
                        Console.WriteLine("Which position would you like to move the employee: ");
                        string positionInput = Console.ReadLine();
                        Console.WriteLine("which employee would you like to move:");
                        string emplInput = Console.ReadLine();
                        Methods.MoveEmployees(company, positionInput, emplInput);
                        break;

                    case 5:
                        Console.WriteLine("Where would you like to move the department to: ");
                        string moveDepPosInput = Console.ReadLine();
                        Console.WriteLine("which department would you like to move it to:");
                        string moveDepInput = Console.ReadLine();
                        Methods.MoveDepartment(company, moveDepPosInput, moveDepInput);
                        break;

                    case 6:
                        Methods.CalcNoOfEmplInDept(company);
                        break;

                    default:
                        Console.WriteLine("Sorry invalid input");
                        break;
                }
            }
        }
    }
}

