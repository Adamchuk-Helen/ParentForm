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
    public partial class Child : Form
    {
        
        public Child()
        {
            InitializeComponent();
        }


        ParentForm pf = null;


        public Child(Form callingForm)
        {
            pf = callingForm as ParentForm;
            InitializeComponent();
        }

        private void Child_Load(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void btOk_Click(object sender, EventArgs e)
        {
            this.pf.Name = tbName.Text;
            this.pf.SurName = tbSurname.Text;
            this.pf.phone = tbPhone.Text;

            this.Close();
        }
    }
}
