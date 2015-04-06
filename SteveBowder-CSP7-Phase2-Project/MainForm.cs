using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteveBowder_CSP7_Phase2_Project
{
    public partial class MainForm : Form
    {
        // Declare class const
        private const int INV_ARRAY_SIZE = 5;

        // Declare class array
        private Inventory[] invArray = new Inventory[INV_ARRAY_SIZE];

        public MainForm()
        {
            InitializeComponent();

            // Declare StreamReader
            StreamReader inputFile;

            // Declare a count variable (C# Arrays don't have a Push() method?)
            int count = 0;

            // Open the file
            inputFile = File.OpenText("Inventory.txt");

            // Read the file
            while (!inputFile.EndOfStream)
            {
                // Create a new inventory object
                Inventory inv = new Inventory(inputFile.ReadLine(), inputFile.ReadLine(),
                    decimal.Parse(inputFile.ReadLine()), double.Parse(inputFile.ReadLine()));

                // Display 
                listItems.Items.Add(inv.PartName + "\t" + inv.PartNumber + "\t" +
                    inv.MarkUpPct.ToString("P1") + "\t" + inv.Cost.ToString("C2"));

                // Add to array
                invArray[count] = inv;
                count++;
            }

            // Close the input file
            inputFile.Close();
        }

        private void btnSortCost_Click(object sender, EventArgs e)
        {
            // Sort by cost
            SortByCost(invArray);

            // Clear the listbox
            listItems.Items.Clear();

            // Repopulate ListBox
            for (int i = 0; i < invArray.Length; i++)
            {
                // Display 
                listItems.Items.Add(invArray[i].PartName + "\t" + invArray[i].PartNumber + "\t" +
                    invArray[i].MarkUpPct.ToString("P1") + "\t" + invArray[i].Cost.ToString("C2"));
            }
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            // Sort by name
            SortByName(invArray);

            // Clear the listbox
            listItems.Items.Clear();

            // Repopulate ListBox
            for (int i = 0; i < invArray.Length; i++)
            {
                // Display 
                listItems.Items.Add(invArray[i].PartName + "\t" + invArray[i].PartNumber + "\t" +
                    invArray[i].MarkUpPct.ToString("P1") + "\t" + invArray[i].Cost.ToString("C2"));
            }
        }

        /** SortByCost accepts an array and sorts it in ascending order by Cost **/
        private void SortByCost(Inventory[] invArray)
        {
            // Declare vars
            int min;
            Inventory tempInv;

            // Loop through the index one less time than the Length
            // (Maximum is the last index by default after all loops have completed)
            for (int i = 0; i < invArray.Length - 1; i++)
            {
                // Initially assume i is the minimum index
                min = i;

                // Begin each loop starting the index after i
                for (int j = i + 1; j < invArray.Length; j++)
                {
                    // If int stored at index j is less than the current min, set it to be swapped
                    if (invArray[j].Cost < invArray[min].Cost)
                    {
                        min = j;
                    }
                }

                // Replace each newfound minimum after each iteration
                tempInv = invArray[i];
                invArray[i] = invArray[min];
                invArray[min] = tempInv;
            }
        }

        /** SortByName accepts an array and sorts it in ascending order by Name **/
        private void SortByName(Inventory[] invArray)
        {
            // Declare vars
            int min;
            Inventory tempInv;

            // Loop through the index one less time than the Length
            // (Maximum is the last index by default after all loops have completed)
            for (int i = 0; i < invArray.Length - 1; i++)
            {
                // Initially assume i is the minimum index
                min = i;

                // Begin each loop starting the index after i
                for (int j = i + 1; j < invArray.Length; j++)
                {
                    // If int stored at index j is less than the current min, set it to be swapped
                    if (string.Compare(invArray[j].PartName, invArray[min].PartName) < 0)
                    {
                        min = j;
                    }
                }

                // Replace each newfound minimum after each iteration
                tempInv = invArray[i];
                invArray[i] = invArray[min];
                invArray[min] = tempInv;
            }
        }

        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Declare the form to display
            ItemForm itemForm = new ItemForm();

            // Set the labels of the ItemForm
            itemForm.lblName.Text = invArray[listItems.SelectedIndex].PartName;
            itemForm.lblNumber.Text = invArray[listItems.SelectedIndex].PartNumber;
            itemForm.lblCost.Text = invArray[listItems.SelectedIndex].Cost.ToString("C2");
            itemForm.lblPrice.Text = invArray[listItems.SelectedIndex].Price.ToString("C2");

            // Display the form
            itemForm.ShowDialog();
        }
    }
}
