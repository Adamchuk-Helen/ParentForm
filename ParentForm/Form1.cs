using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentForm
{
    
    public partial class ParentForm : Form
    {
       
        public ParentForm()
        {
            InitializeComponent();
            
        }
        public string Name
        {
            
            set { tbName.Text = value; }
        }
        public string SurName
        {

            set { lbSunameText.Text = value; }
        }
        public string phone;
       
        
        private void btEdit_Click(object sender, EventArgs e)
        {
            Child ch = new Child(this);
            ch.Show();
          
        }
        Child ch = new Child();

        private void btPhone_Click(object sender, EventArgs e)
        {

            
            MessageBox.Show(phone);
            
        }
    }
}
