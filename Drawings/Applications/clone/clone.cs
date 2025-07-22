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
       
        // Кнопка выгрузить текущий чертеж:
        private void Create_click(object sender, EventArgs e)
        {
            PullOutTheDrawing();
        }

        //Сборный метод для выгрузки чертежа
        void PullOutTheDrawing() 
        {
            //Получений текущего чертежа
            //Перебор всех элементов чертежа
        }

        
        
        
        
        
        
        private void Clone_Load(object sender, EventArgs e)
        {

        }
    }
}