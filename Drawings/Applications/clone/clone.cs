using System;
using System.Collections;
using System.Windows.Forms;

using Tekla.Structures.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TSD=Tekla.Structures.Drawing;
using TSMUI = Tekla.Structures.Model.UI;

namespace CloneTest
{
    public partial class clone : Form
    {
        public clone()
        {
            InitializeComponent();
        }

        private Model Model = new Model();
        private TSD.DrawingHandler DrawingHandler = new TSD.DrawingHandler();
       
        // Кнопка выгрузить текущий чертеж:
        private void Create_click(object sender, EventArgs e)
        {
            PullOutTheDrawing();
        }

        //Сборный метод для выгрузки чертежа
        void PullOutTheDrawing() 
        {
            // Получить список объектов в текущем чертеже
            TSD.DrawingObjectEnumerator drawingObjects = DrawingHandler.GetActiveDrawing().GetSheet().GetAllObjects();
            foreach (TSD.DrawingObject item in drawingObjects)
            {
                string typeItem = item.GetType().ToString();
                
                switch (typeItem)
                {
                    case "Tekla.Structures.Drawing.Mark":
                        TSD.Mark item2 = item as TSD.Mark;
                        
                        break;
                    case "Tekla.Structures.Drawing.MarkSet":
                        TSD.MarkSet item3 = item as TSD.MarkSet;
                        
                        break;
                    case "Tekla.Structures.Drawing.LeaderLine":
                        TSD.LeaderLine item4 = item as TSD.LeaderLine;
                        
                        break;
                    case "Tekla.Structures.Drawing.Part":
                        TSD.Part item5 = item as TSD.Part;
                        
                        break;
                    case "Tekla.Structures.Drawing.StraightDimension":
                        TSD.StraightDimension item6 = item as TSD.StraightDimension;
                        
                        break;
                    case "Tekla.Structures.Drawing.View":
                        TSD.View item7 = item as TSD.View;
                        
                        break;
                    default:
                        break;
                }
            }
        }

        
        
        
        
        
        
        private void Clone_Load(object sender, EventArgs e)
        {

        }
    }
}