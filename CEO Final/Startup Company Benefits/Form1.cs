using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//This was added so we can create files
using System.IO;

//Allison Santerre
//Esimated Time To Finish 2 hours
//Start Date & Time 10:28
//Finished Time pm 12:00
//Paragraph Analysis
/* I estimated the timing almost perfectly. I knew since I've been keeping up with the UI
 * and comments that this wouldn't take to long for both my final and UI assignment. To 
 * Improve time I could have made sure I looked over my design more consistantly and
 * always comment when I code. During the first two weeks I believe I didn't have any comments.
 * So that took a little away from my time because I wen't back to make sure I commented enough.
*/

namespace Startup_Company_Benefits
{
    public partial class Menu : Form
    {
		public static Menu Instance;

		public Menu()
        {
            InitializeComponent();
			Instance = this;
        }
        //Calcutlation for Yearly Salary
        float CalculateYearlySalary(float Hours, float Salary)
        {
            if (Hours == 0.0f)
            {
                return 0.0f;
            }
            else
            {
                return Salary * Hours;
            }
        }
        //Calculation for Raise
        float CalculateRaise(int YearsWorked)
        {
            //If else statment for different conditions when calculating raise
            if (YearsWorked <= 4)
            {
                return 0.05f;
            }
            else if (YearsWorked >= 4 && YearsWorked <= 10)
            {
                return 0.1f;
            }
            else
            {
                return 0.15f;
            }
        }
        //Calculation for PTO
        int CalculatePTO(int YearsWorked)
        {
            return (4 + YearsWorked) / 2;
        }
        //Our button function for our Calculate Yearly Salary Button
        private void CalculateYearlySalary_Click(object sender, EventArgs e)
        {
            //Our Variables
            float hours = 0.0f;
            float salary = 0.0f;
            //For Loop
            for (int i = 0; i < 100; i++)
            {
                //If statment to tell if an input is a number in our hours text box
                //and if it's not a message displays
                if (float.TryParse(HoursTextBox.Text, out hours) == false)
                {
                    MessageBox.Show("An invalid number was entered for hours");
                    return;
                }
                //If statment to tell if an input is a number in our salary text box
                //and if it's not a message displays
                if (float.TryParse(SalaryTextBox.Text, out salary) == false)
                {
                    MessageBox.Show("An invalid number was entered for salary");
                    return;
                }
                //Our Calculation
                float yearlySalary = CalculateYearlySalary(hours, salary);
                //Displays results in results text box
                ResultsTextBox.Text = yearlySalary.ToString("C");

                StreamWriter outputFile;
                //For our created file in this function (Calculate Yearly Salary)
                outputFile = File.CreateText("CalculateYearlySalary.txt");
                //Saves results to file
                outputFile.WriteLine(ResultsTextBox.Text);
                outputFile.Close();
                //A message to display that this information was saved
                MessageBox.Show("The results for Calculating Yearly Salary were saved.");
                return;
            }
        }
        //Our button function for Calulating Raise 
        private void CalculateRaise_Click(object sender, EventArgs e)
        {
            //Our Variable 
            int yearsWorked = 0;
            //For Loop
            for (int i = 0; i < 100; i++)
            {
                //Try Catch 
                try
                {
                    //When a user inputs something in the text box and it's a number
                    //It's true
                    yearsWorked = int.Parse(YearsWorkedTextBox.Text);
                }
                catch (Exception Error)
                {
                    //When a user inputs something that isnt a number
                    //It's false and displays a message
                    MessageBox.Show("An invalid number was entered for years worked");
                    return;
                }
                //Our Calcualtion
                float raise = CalculateRaise(yearsWorked);
                //Displays Our results in the results text box
                ResultsTextBox.Text = (raise * 100).ToString();

                StreamWriter outputFile;
                //For our created file in this function (Calculated Raise)
                outputFile = File.CreateText("CalculateRaise.txt");
                //Saves results to file
                outputFile.WriteLine(ResultsTextBox.Text);
                outputFile.Close();
                //A message to display that this information was saved
                MessageBox.Show("The results for Calculating Raise were saved.");
                return;
            }

        }
        //Our button function for Calculating PTO
        private void CalculatePTO_Click(object sender, EventArgs e)
        {
            //Our Variable
            int yearsWorked = 0;
            //For Loop
            for (int i = 0; i < 100; i++)
            {
                //If statment 
                if (int.TryParse(YearsWorkedTextBox.Text, out yearsWorked) == false)
                {
                    //When a invalid number is put into the text box 
                    //This will be false and display a message 
                    MessageBox.Show("An invalid number was entered for years worked");
                    return;
                }
                //Our Calculation
                float PTO = CalculatePTO(yearsWorked);
                //Displays our results to our results textbox
                ResultsTextBox.Text = PTO.ToString();

                StreamWriter outputFile;
                //For our created file in this function (Calculated PTO)
                outputFile = File.CreateText("CalculatePTO.txt");
                //Saves results to file
                outputFile.WriteLine(ResultsTextBox.Text);
                outputFile.Close();
                //A message to display that this information was saved
                MessageBox.Show("The results for Calculating PTO were saved.");
                return;
            }
        }
        //Our Exit Button Function
        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Closes the program when this button is clicked
            this.Close();
        }
        //Random Hour Generator button function
        private void RandomHourGenerator_Click(object sender, EventArgs e)
        {
            //Our Variable
            int hoursNumber;
            //Creates our random object
            Random rand = new Random();
            //Gets a random integer and assigns it to number between 1820 - 2496
            //Basically between 35 hours and 48 hours a week
            hoursNumber = rand.Next(1820, 2496);
            //Displays our random generated number in our hours text box
            HoursTextBox.Text = hoursNumber.ToString();
            //A message to show that the random hours were selected
            MessageBox.Show("Random hours were selected.");
            return;
        }
        //Button function for Calculate All
        private void CalculateAll_Click(object sender, EventArgs e)
        {
            //So Our results text box clears when we do another input
            ResultsTextBox.Text = "";
            //Our Array
            string[] results = new string[3];

            //Our Variables 
            float hours = 0.0f;
            float salary = 0.0f;
            int yearsWorked = 0;

            //If statment to tell if an input is a number in our hours text box
            //and if it's not a message displays
            if (float.TryParse(HoursTextBox.Text, out hours) == false)
            {
                MessageBox.Show("An invalid number was entered for hours");
                return;
            }
            //If statment to tell if an input is a number in our salary text box
            //and if it's not a message displays
            if (float.TryParse(SalaryTextBox.Text, out salary) == false)
            {
                MessageBox.Show("An invalid number was entered for salary");
                return;
            }
            if (int.TryParse(YearsWorkedTextBox.Text, out yearsWorked) == false)
            {
                //When a invalid number is put into the text box 
                //This will be false and display a message 
                MessageBox.Show("An invalid number was entered for years worked");
                return;
            }

            //If statment to run our variables 
            if (salary < 0 || hours < 0 || yearsWorked < 0)
            {
                return;
            }

            //Calculations for yearly salary, raise, and PTO
            float yearlySalary = CalculateYearlySalary(hours, salary);
            float raise = CalculateRaise(yearsWorked);
            float PTO = CalculatePTO(yearsWorked);

            //Our Array of results 
            results[0] = string.Format("Yearly Salary = {0}", yearlySalary);
            results[1] = string.Format("Raise = {0}", raise);
            results[2] = string.Format("PTO = {0}", PTO);

            //Instantly changes results label to all results when using the calculate all button
            label4.Text = "All Results";

            //For displaying all results 
            foreach (string result in results)
            {
                ResultsTextBox.Text += string.Concat(result, Environment.NewLine);
            }

            StreamWriter outputFile;
            //For our created file in this function (Calculated All)
            outputFile = File.CreateText("CalculateAll.txt");
            //Saves results to file
            outputFile.WriteLine(ResultsTextBox.Text);
            outputFile.Close();
            //A message to display that this information was saved
            MessageBox.Show("The results for Calculating All were saved.");
        }
        //Function for Calculating Employee Bonus
        int CalculateEmployeeBonus()
		{
			//Our List
			List<int> hashCodes = new List<int>();

			foreach (char letter in NameTextBox.Text)
			{
				hashCodes.Add(letter.GetHashCode());
			}
			//Variable for results 
			int result = 0;

			foreach (int hashCode in hashCodes)
			{
				result = result + hashCode;
			}
			//The modulus operator makes it so that the number is within the range of 0 and 10000
			int bonus = result % 100000;

			return bonus;
		}
        //Button function for Calculate Bonus 
        private void CalculateBonus_Click(object sender, EventArgs e)
        {
            //Variable for bonus
			int bonus = CalculateEmployeeBonus();

            //So our results display for our bonus 
            ResultsTextBox.Text = bonus.ToString("C");
            //Instantly changes our label results to bonus results when using this button
            label4.Text = "Bonus Result";

            StreamWriter outputFile;
            //For our created file in this function (Calculated Bonus)
            outputFile = File.CreateText("CalculateBonus.txt");
            //Saves results to file
            outputFile.WriteLine(ResultsTextBox.Text);
            outputFile.Close();
            //A message to display that this information was saved
            MessageBox.Show("The results for Calculating Bonus were saved.");
        }
        //Button function for Adding Employees
        private void AddEmployee_Click(object sender, EventArgs e)
        {
			//Our Variables 
			float hours = 0.0f;
			float salary = 0.0f;
			int yearsWorked = 0;

            //If statment to tell if an input is a number in our hours text box
            //and if it's not a message displays
            if (float.TryParse(HoursTextBox.Text, out hours) == false)
			{
				MessageBox.Show("An invalid number was entered for hours");
				return;
			}
			//If statment to tell if an input is a number in our salary text box
			//and if it's not a message displays
			if (float.TryParse(SalaryTextBox.Text, out salary) == false)
			{
				MessageBox.Show("An invalid number was entered for salary");
				return;
			}
            //If statment to tell if an input is a number in our years worked text box
            //and if it's not a message displays
            if (int.TryParse(YearsWorkedTextBox.Text, out yearsWorked) == false)
			{
				MessageBox.Show("An invalid number was entered for years worked");
				return;
			}

			//Calculations for yearly salary, raise, and PTO
			float YearlySalary = CalculateYearlySalary(hours, salary);
			float raise = CalculateRaise(yearsWorked);
			int PTO = CalculatePTO(yearsWorked);
			int bonus = CalculateEmployeeBonus();

			Employee newEmployee = new Employee();

            //Sets new employee name
			newEmployee.SetName(NameTextBox.Text);
            //Sets employees yearly salary
            newEmployee.SetSalary(YearlySalary);
            //Sets new employees raise
			newEmployee.SetRaise(raise);
            //Sets new employees PTO
			newEmployee.SetPTO(PTO);
            //Sets new employees Bonus
			newEmployee.SetBonus(bonus);

            //To add employees to grid
			newEmployee.Add();


		}
        //Button function for saving employees
        private void SaveEmployee_Click(object sender, EventArgs e)
        {
			Employee.Save();
        }
        //Button function for loading employees
        private void LoadEmployee_Click(object sender, EventArgs e)
        {
			Employee.Load();
        }
        //Button function for clearing employees
        private void ClearEmployee_Click(object sender, EventArgs e)
        {
			Employee.Clear();
        }
        //Button function for adding an item
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            //String to get our item name
			string itemName = ItemNameTextBox.Text;
            //Our variables 
			float itemPrice = 0.0f;
			int itemQuantity = 0;
            //If statment just in case if an invalid number is found in our item price text box
			if (float.TryParse(ItemPriceTextBox.Text, out itemPrice) == false)
			{
                //Will display this message if an invalid number is found
				MessageBox.Show("An invalid number was entered for the Item Price");
				return;
			}
            //If statment just in case if an invalid number is found in our item quantity text box
			if (int.TryParse(ItemQuantityTextBox.Text, out itemQuantity) == false)
			{
                //Will display this message if an invalid number is found
				MessageBox.Show("An invalid number was entered for the Item Quantity");
				return;
			}

			Item newItem = new Item();
            //To set our new items name, price, and quantity
			newItem.SetItemName(itemName);
			newItem.SetItemPrice(itemPrice);
			newItem.SetItemQuanity(itemQuantity);
            //To add our new item
			newItem.Add();
		}
        //Button function for loading items
        private void LoadItemButton_Click(object sender, EventArgs e)
        {
			Item.Load();
        }
        //Button function for saving items
        private void SaveItemButton_Click(object sender, EventArgs e)
        {
			Item.Save();
        }
        //Button function for clearing items 
        private void ClearItemButton_Click(object sender, EventArgs e)
        {
			Item.Clear();
        }
    }
}
