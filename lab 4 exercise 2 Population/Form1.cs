using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab_4_exercise_2_Population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void growthButton_Click(object sender, EventArgs e)
        {
            //Objective - create an application that displays constant growth 
            //Using Listboxes, loops, and streamwriter

            //Establish variables to be used throughout the program
            double increase = double.Parse(increaseTextBox.Text);
            double organisms = double.Parse(organismsTextBox.Text);

            try
            {
                //Declare a streamwriter output variable
                StreamWriter outputFile;

                //Open the population file for writing text
                outputFile = File.CreateText("population.txt");

                //Clear the Listbox
                populationListBox.Items.Clear();

                //Write the heading of the text file
                outputFile.WriteLine("Day\tApproximate Population");
                

                //Now make the program loop
                for (int days = 1; days <= int.Parse(daysTextBox.Text); days++)
                {
                    //Setup the table to be displayed
                    outputFile.WriteLine(days + "\t" + "\t" + organisms);
                    //outputFile.WriteLine(total);

                    //Calculate the growth and total
                    organisms = (organisms * increase);

                }
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Your File has been Saved!");
                }
                else
                {
                    MessageBox.Show("Your File has not been saved.");
                }

                //close the file
                outputFile.Close();
            }
            catch (Exception ex)
            {
                //Display an error message 
                MessageBox.Show(ex.Message);
            }
            try
            {
                //Declare a variable to be used inside of the listbox
                string population;

                //Declare a streamreader varibale
                StreamReader inputFile;

                //Open the file and get the streamreder object
                inputFile = File.OpenText("population.txt");

                //Read the file
                while(!inputFile.EndOfStream)
                {
                    //get the population
                    population = inputFile.ReadLine();

                    //Add the population information to the LitBox
                    populationListBox.Items.Add(population);
                }
                //Close the file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                //Display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
