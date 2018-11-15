using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vector2DLib;

namespace VectorCalculator2
{
    public partial class VectorCalculator : Form
    {
        private static int VECTOR_COUNT = 2;
        private VectorOperations operation;
        private TextBox[] txbCoords = new TextBox[VECTOR_COUNT * 4];
        private double[,] srcData = new double[VECTOR_COUNT, 4];
        private Vector2D[] vectors = new Vector2D[VECTOR_COUNT];

        public VectorCalculator()
        {
            InitializeComponent();

            txbCoords[0] = txbX11;
            txbCoords[1] = txbY12;
            txbCoords[2] = txbX13;
            txbCoords[3] = txbY14;
            txbCoords[4] = txbX21;
            txbCoords[5] = txbY22;
            txbCoords[6] = txbX23;
            txbCoords[7] = txbY24;

            for (int i = 0; i < vectors.Length; ++i)
            {
                vectors[i] = new Vector2D();
            }
        }

        private void txbX1_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                try
                {
                    string sData = ((TextBox)sender).Text;
                    string sTag = (string)((TextBox)sender).Tag;
                    int tag;
                    if (int.TryParse(sTag, out tag))
                    {
                        int i = tag / 10, j = tag % 10;
                        srcData[i - 1, j - 1] = double.Parse(sData);
                    }
                }
                catch (Exception ex)
                {}

            }
        }

        private void rbAddVector_Click(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                if (!btnUpdate.Enabled)
                {
                    btnUpdate.Enabled = true;
                }
                string tag = (string)((RadioButton)sender).Tag;
                operation = (VectorOperations)Enum.Parse(typeof(VectorOperations), tag);

                foreach (TextBox txb in txbCoords)
                {
                    txbX1_TextChanged(txb, null);
                }
                for (int i = 0; i < srcData.GetLength(0); ++i)
                {
                    for (int j = 0; j < srcData.GetLength(1); j += 2)
                    {
                        Point2D p = new Point2D(srcData[i, j], srcData[i, j + 1]);
                        if (j < 2)
                        {
                            vectors[i].StartPoint = p;
                        }
                        else
                        {
                            vectors[i].EndPoint = p;
                        }
                    }
                }

                object result = VectorUtils.ProcessVectorOperation(operation, vectors);
                lbResult.Text = string.Format("Result: {0}", result);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
