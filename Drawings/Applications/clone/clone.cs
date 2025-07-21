using System;
using System.Collections;
using System.Windows.Forms;

using Tekla.Structures.Model;
using Tekla.Structures.Drawing;
using TSMUI = Tekla.Structures.Model.UI;

namespace DrawingTestApplication1
{
    public partial class clone : Form
    {
        public clone()
        {
            InitializeComponent();
        }

        private Model Model = new Model();
        private DrawingHandler DrawingHandler = new DrawingHandler();
       
        private void Create_click(object sender, EventArgs e)
        {
           
        }
       

        private void Clone_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}