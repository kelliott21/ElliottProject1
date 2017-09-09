using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElliottProject1
{
    public partial class frmStackProgram : Form
    {
        //Creates new stack
        Stack stack = new Stack();

        //Form constructor
        public frmStackProgram()
        {
            InitializeComponent();
        }

        //Exits the program when clicking "Exit" button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Adds value from textbox to the linked list
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int value = 0;
            //Checks if value is an integer in textbox
            if (int.TryParse(txtValue.Text, out value))
            {
                stack.push(value);
                lblLastAction.Text = "Added integer " + value.ToString() + " to stack";
                lblList.Text = stack.getList();
                txtValue.Text = ""; //Removes value in textbox
            }
            else
                MessageBox.Show("Value needs to be an integer", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Removes value at the top of the stack
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int value = stack.pop();
                lblLastAction.Text = "Removed integer " + value.ToString() + " from stack";
                lblList.Text = stack.getList();
            }
            catch
            {
                MessageBox.Show("Stack is currently empty, remove cannot be performed.", "Empty stack", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Allows user to hit the Enter key to add a value
        private void txtValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd_Click(sender, e);
            }
        }

        //When program starts, puts the cursor into the text box
        private void frmStackProgram_Shown(object sender, EventArgs e)
        {
            txtValue.Focus();
        }
    }
}
