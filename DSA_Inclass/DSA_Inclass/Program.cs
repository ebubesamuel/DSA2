// NAME: SAMUEL CHIDIEBUBE CHIEMELA
// ID NO: 2117053

using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DSA2
{
    class Program
    {
        static Department department;
        static Department root;

        public static void Main(string[] args)
        {

            Menu.Start();

        }

        public static Department CreateCompanyTree()
        {

            

            var root = new Department("Extramus Company", "Mgr. G. Antonio ", new List<Department>(), new List<string>());
            Department Administrative = new Department("Administrative Dept.", "Mgr. D. Beckham", new List<Department>(), new List<string>()) ;
            Department NonAdministrative = new Department("Non-Administrative Dept.", "Mgr. C. Jones", new List<Department>(), new List<string>());
            root.departments.Add(Administrative);
            root.departments.Add(NonAdministrative);

                 Department Operations = new Department("Operations Dept.", "Mgr. R. Craig", new List<Department>(), new List<string>());
                 Department Support = new Department("Support Dept.", "Mgr. A. Andy", new List<Department>(), new List<string>());
                 Administrative.departments.Add(Operations);
                 Administrative.departments.Add(Support);

                  Department Janitor = new Department("Janitor Dept.", "Mgr. B. Simone", new List<Department>(), new List<string>() );
                  Department Catering = new Department("Catering Dept.", "Mgr. A. Angela", new List<Department>(), new List<string>());
                  NonAdministrative.departments.Add(Janitor);
                  NonAdministrative.departments.Add(Catering);

                         Department Legal = new Department("Legal Dept.", "Mgr. A. Angela", new List<Department>(), new List<string>());
                         Department Finance = new Department("Finance Dept.", "Mgr. A. Angela", new List<Department>(), new List<string>());
                         Department Ict = new Department("ICT Dept.", "Mgr. A. Angela", new List<Department>(), new List<string>());
                         Department Hr = new Department("Human Resources Dept.", "Mgr. A. Angela", new List<Department>(), new List<string>());
                         Department Customercare = new Department("Customer Care Dept.", "Mgr. A. Angela", new List<Department>(), new List<string>());
                         Operations.departments.Add(Legal);
                         Operations.departments.Add(Finance);
                         Operations.departments.Add(Ict);
                         Support.departments.Add(Hr);
                         Support.departments.Add(Customercare);
            
                            Department Taxmgmt = new Department("Tax Management Dept.", "Mgr. W. Angela", new List<Department>(), new List<string>());
                            Department Treasury = new Department("Treasury Dept.", "Mgr. W. WHite", new List<Department>(), new List<string>());
                            Department Budget = new Department("Budget Dept.", "Mgr. J. sins", new List<Department>(), new List<string>());
                            Department Development = new Department("Development Dept.", "Mgr. A. Anthony", new List<Department>(), new List<string>());
                            Department Nondevelopment = new Department("Non Development Dept.", "Mgr. A. Blinkens", new List<Department>(), new List<string>());
                            Finance.departments.Add(Taxmgmt);
                            Finance.departments.Add(Treasury);
                            Finance.departments.Add(Budget);
                            Ict.departments.Add(Development);
                            Ict.departments.Add(Nondevelopment);

                                Department Fullstack = new Department("FullStack Dept.", "Mgr. V. Myerrs", new List<Department>(), new List<string>());
                                Department Frontend = new Department("Front-End Dept.", "Mgr. S. Vladimir", new List<Department>(), new List<string>());
                                Department Backend = new Department("Back.End Dept.", "Mgr. P. Filip", new List<Department>(), new List<string>());
                                Department Uiux = new Department("UI/UX Dept.", "Mgr. K. Rei", new List<Department>(), new List<string>());
                                Department Qa = new Department("Quality Assurance Dept.", "Mgr. P. Filip", new List<Department>(), new List<string>());
                                Development.departments.Add(Fullstack);
                                Development.departments.Add(Frontend);
                                Development.departments.Add(Backend);
                                Nondevelopment.departments.Add(Uiux);
                                Nondevelopment.departments.Add(Qa);

                     return root;

        }

    }
}

