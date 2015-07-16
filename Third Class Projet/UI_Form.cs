using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Third_Class_Projet
{
    public partial class UI_Form : Form
    {
        public UI_Form()
        {
            InitializeComponent();
        }
        private Boolean check_dice_number()
        {

        }
        private Boolean check_dice_roll()
        {

        }
        private Boolean check_seed()
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    public class aDie : Random
    {
        public static int incrementer = 1;
        public aDie()
            : base(Environment.TickCount + incrementer)
        {
            incrementer++;
        }
        private int result;
        public int Result
        {
            get { return this.Next(6) + 1; }
        }
    }
    public class Histogram : Dictionary
    {
        public Histogram( ) : base()
        {

        }
    }
}
