using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutionFeeIncrease
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalTutFee_Click(object sender, EventArgs e)
        {
            const int TUITION_PER_SEM = 6000;
            decimal result = TUITION_PER_SEM;
            const decimal percentageIncrease = 0.02m;
            lstBoxOutput.Items.Add("Year \tTution Fee Increased Per Year");
            for (int i = 1; i <= 5; i++)
            {
                result += (result * percentageIncrease);
                lstBoxOutput.Items.Add(i + "\t" +  result.ToString("C"));
            }
        }
    }
}
