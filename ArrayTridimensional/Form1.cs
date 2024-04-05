using Microsoft.VisualBasic;

namespace ArrayTridimensional
{
    public partial class Form1 : Form
    {
        private int[][][] matrixTridimensional;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateMatrix_Click(object sender, EventArgs e)
        {
            int dim1 = int.Parse(txtDim1.Text);
            int dim2 = int.Parse(txtDim2.Text);
            int dim3 = int.Parse(txtDim3.Text);

            matrixTridimensional = new int[dim1][][];

            for (int i = 0; i < dim1; i++)
            {
                matrixTridimensional[i] = new int[dim2][];

                for (int j = 0; j < dim2; j++)
                {
                    matrixTridimensional[i][j] = new int[dim3];
                }
            }

            MessageBox.Show("Three-dimensional array created with dimensions: " + dim1 + "x" + dim2 + "x" + dim3);
        }

        private void btnFillMatrix_Click(object sender, EventArgs e)
        {
            if (matrixTridimensional == null)
            {
                MessageBox.Show("First create the three-dimensional array.");
                return;
            }

            for (int i = 0; i < matrixTridimensional.Length; i++)
            {
                for (int j = 0; j < matrixTridimensional[i].Length; j++)
                {
                    for (int k = 0; k < matrixTridimensional[i][j].Length; k++)
                    {
                        string input = Interaction.InputBox($"Enter value for the position ({i}, {j}, {k}):", "Ingresar valor");
                        int valor;
                        if (int.TryParse(input, out valor))
                        {
                            matrixTridimensional[i][j][k] = valor;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid value.");
                            return;
                        }
                    }
                }
            }

            MessageBox.Show("Three-dimensional matrix filled correctly.");
        }

        private void btnShowMatrix_Click(object sender, EventArgs e)
        {
            if (matrixTridimensional == null)
            {
                MessageBox.Show("First create and fill the three-dimensional array.");
                return;
            }

            string content = "Three-dimensional array content:\n";
            for (int i = 0; i < matrixTridimensional.Length; i++)
            {
                content += $"Capa {i + 1}:\n";
                for (int j = 0; j < matrixTridimensional[i].Length; j++)
                {
                    content += "[";
                    for (int k = 0; k < matrixTridimensional[i][j].Length; k++)
                    {
                        content += $" {matrixTridimensional[i][j][k]}";
                    }
                    content += " ]\n";
                }
                content += "\n";
            }

            MessageBox.Show(content);
        }
    }
    }

