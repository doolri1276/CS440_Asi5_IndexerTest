using OOPconcepts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndexerTest
{
    public partial class Form1 : Form
    {
        University UNV = new University();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Student stFound = null;
            int idToSearch = int.Parse(txtStudentID.Text);
            //foreach(Student st in UNV.STA)
            //{
            //    if(st.Id == idToSearch)
            //    {
            //        stFound = st;
            //        break;
            //    }
            //}
            Student stFound = UNV[idToSearch];
            if (stFound != null)
                MessageBox.Show(stFound.ToString());
            else
                MessageBox.Show("student not found");
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            Student[] stFound = UNV[txtName.Text, checkLastName.Checked?NameType.LASTNAME:NameType.FIRSTNAME];
            if (stFound == null || stFound.Length == 0)
                MessageBox.Show("student not found");
            else
            {
                string out1 = "";
                foreach (Student st in stFound)
                    out1 += st.ToString();
                MessageBox.Show(out1);
            }
        }
    }
}
