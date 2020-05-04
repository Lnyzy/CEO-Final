using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Startup_Company_Benefits
{
	//Our employee class
	public class Employee
	{
		//Our variables
		string Employee_Name;
		float Yearly_Salary;
		float Raise;
		int PTO;
		float Bonus;
		//Adds our employees to a list
		static List<Employee> AddedEmployees = new List<Employee>();
		//What our employee consists of 
		public Employee()
		{
			Employee_Name = "";
			Yearly_Salary = 0.0f;
			Raise = 0.0f;
			PTO = 0;
			Bonus = 0.0f;
		}
		//What our employee consists of
		public Employee(string newEmployee_Name, float newYearly_Salary, float newRaise, int newPTO, float newBonus)
		{
			Employee_Name = newEmployee_Name;
			Yearly_Salary = newYearly_Salary;
			Raise = newRaise;
			PTO = newPTO;
			Bonus = newBonus;
		}
		//Function for adding our employees
		public void Add()
		{
			AddedEmployees.Add(this);
			Menu.Instance.EmployeeGrid.Rows.Add(Employee_Name, Yearly_Salary, Raise, PTO, Bonus);
		}
		//Function for clearing our employees
		public static void Clear()
		{
			AddedEmployees.Clear();
			Menu.Instance.EmployeeGrid.Rows.Clear();
		}
		//Function for saving our employees
		public static void Save()
		{
			//Creates a file named Employee Data
			using (var fileStream = File.CreateText("EmployeeData.txt"))
			{
				foreach (var employee in AddedEmployees)
				{
					//Writes this info into our Employee Data text file
					fileStream.WriteLine(employee.Employee_Name);
					fileStream.WriteLine(employee.Yearly_Salary);
					fileStream.WriteLine(employee.Raise);
					fileStream.WriteLine(employee.PTO);
					fileStream.WriteLine(employee.Bonus);
				}
				fileStream.Close();
			}
		}
		//Function for loading our employees
		public static void Load()
		{
			//Looks at our employee data text
			if (File.Exists("EmployeeData.txt"))
			{
				using (var fileStream = File.OpenText("EmployeeData.txt"))
				{
					do
					{
						//If employees have been saved they will be displayed
						Employee newEmployee = new Employee();

						newEmployee.Employee_Name = fileStream.ReadLine();
						newEmployee.Yearly_Salary = float.Parse(fileStream.ReadLine());
						newEmployee.Raise = float.Parse(fileStream.ReadLine());
						newEmployee.PTO = int.Parse(fileStream.ReadLine());
						newEmployee.Bonus = float.Parse(fileStream.ReadLine());

						newEmployee.Add();
					}
					while (!fileStream.EndOfStream);
				}
			}
		}
		//A string function for getting employee name
		public string GetName()
		{
			return Employee_Name;
		}
		//A function for setting employee name
		public void SetName(string newName)
		{
			Employee_Name = newName;
		}
		//A function for getting salary
		public float GetSalary()
		{
			return Yearly_Salary;
		}
		//A function for setting salary
		public void SetSalary(float newYearly_Salary)
		{
			Yearly_Salary = newYearly_Salary;
		}
		//A function for getting raise
		public float GetRaise()
		{
			return Raise;
		}
		//A function for setting raise
		public void SetRaise(float newRaise)
		{
			Raise = newRaise;
		}
		//A function for getting PTO
		public int GetPTO()
		{
			return PTO;
		}
		//A function for setting PTO
		public void SetPTO(int newPTO)
		{
			PTO = newPTO;
		}
		//A function for getting bonus 
		public float GetBonus()
		{
			return Bonus;
		}
		//A function for setting bonus
		public void SetBonus(float newBonus)
		{
			Bonus = newBonus;
		}

	}
}
