using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace www.doenets.lk
{
    public partial class Welocme : Form
    {
        public Welocme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //store in index number
                string index =  txtIndex.Text;
                int a = int.Parse(index);

                Results rs = new Results();
                rs.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter Valid index number!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }
    }
}
