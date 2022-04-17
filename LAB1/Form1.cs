using System;
using System.Windows.Forms;
using SharpGL;

namespace LAB1
{
    public partial class Form1 : Form
    {
        OpenGL controller;
        readonly float[][] initTriangle =
            {
            new float[]{ 0.5F, 1, 0.5F, 1 },
            new float[]{ 0, 0, 0, 1 },
            new float[]{ 1, 0, 0, 1 },
            new float[]{ 0, 0, 1, 1 },
            new float[]{ 1, 0, 1, 1 }
        };

        float[][] triangle =
            {
            new float[]{ 0.5F, 1, 0.5F, 1 },
            new float[]{ 0, 0, 0, 1 },
            new float[]{ 1, 0, 0, 1 },
            new float[]{ 0, 0, 1, 1 },
            new float[]{ 1, 0, 1, 1 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void initDraw(object sender, RenderEventArgs args)
        {
            controller = this.openGLControl1.OpenGL; //получение контроллера openGl
            controller.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT); //Очищение цветового и глубинного буферов
            controller.LoadIdentity(); //всстанвление изначальной матрицы координат
            controller.Translate(-0.4f, -0.3f, -4.0f); //сдвигаем перо, для отображение по центру

            controller.Begin(OpenGL.GL_TRIANGLES);

            controller.Color(0.0f, 1.0f, 0.0f);
            controller.Vertex(triangle[0]);
            controller.Vertex(triangle[1]);
            controller.Vertex(triangle[2]);

            controller.Color(1.0f, 0.5f, 0.0f);
            controller.Vertex(triangle[0]);
            controller.Vertex(triangle[3]);
            controller.Vertex(triangle[4]);

            controller.Color(0.0f, 0.0f, 1.0f);
            controller.Vertex(triangle[1]);
            controller.Vertex(triangle[0]);
            controller.Vertex(triangle[3]);

            controller.Color(1.0f, 0.0f, 1.0f);
            controller.Vertex(triangle[2]);
            controller.Vertex(triangle[4]);
            controller.Vertex(triangle[0]);

            controller.End();

            controller.Begin(OpenGL.GL_QUADS);

            controller.Color(1.0f, 1.0f, 0.0f);
            controller.Vertex(triangle[1]);
            controller.Vertex(triangle[2]);
            controller.Vertex(triangle[4]);
            controller.Vertex(triangle[3]);

            controller.End();
            controller.Flush();


        }

        private void rotateBtn(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    this.axisList.SelectedItem.ToString();
                }
                catch (Exception ex)
                {
                    throw new AxisException("Выберите ось");
                }

                if (this.angleTextBox.Text.ToString() == "") throw new AngleException("Введите угол");
                Draw();
            }
            catch (AxisException ex)
            {
                MessageBox.Show(ex.Message, "Error! Ось не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (AngleException ex)
            {
                MessageBox.Show(ex.Message, "Error! Угол не введен!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error! Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private float[][] matrixMultiply(float[][] matrix, float[][] transformMatrix)
        {
            float[] temp = new float[20];
            float[] input1, input2;

            float[][] result =
            {
                new float [4],
                new float [4],
                new float [4],
                new float [4],
                new float [4]
            };
            int M = 5, N = 4;

            //convert input to line array
            input1 = new float[20];
            for (int i = 0; i < M; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    input1[i * N + j] = matrix[i][j];
                }
            }
            input2 = new float[16];
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    input2[i * N + j] = transformMatrix[i][j];
                }
            }

            for (int i = 0; i < M; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    temp[i * N + j] = 0;
                    for (int k = 0; k < N; ++k)
                        temp[i * N + j] += input1[i * N + k] * input2[k * N + j];
                }
            }

            for (int i = 0; i < M; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    result[i][j] = temp[i * N + j];
                    if (j == 3)
                    {
                        result[i][j] = 1;
                    }
                }
            }

            return result;
        }


        private void Draw()
        {
            controller = this.openGLControl1.OpenGL;

            controller.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            controller.LoadIdentity();

            double rad = float.Parse(this.angleTextBox.Text) * Math.PI / 180;
            float cos = (float)Math.Cos(rad);
            float sin = (float)Math.Sin(rad);
            float[][] transform = null;

            if (int.Parse(this.axisList.SelectedIndex.ToString()) == 0)
            {
                transform = new float [][]
                    { 
                    new float[]{ 1, 0, 0, 1 }, 
                    new float[]{ 0, cos, sin, 0 }, 
                    new float[]{ 0, -sin, cos, 0 }, 
                    new float[]{ 0, 0, 0, 1 } 
                    };
            }
            if (int.Parse(this.axisList.SelectedIndex.ToString()) == 1)
            {
                transform = new float[][] 
                {
                    new float[]{ cos, 0, -sin, 0 }, 
                    new float[]{ 0, 1, 0, 0 }, 
                    new float[]{ sin, 0, cos, 0 }, 
                    new float[]{ 0, 0, 0, 1 } 
                };
            }
            if (int.Parse(this.axisList.SelectedIndex.ToString()) == 2)
            {
                transform = new float[][] 
                { 
                    new float[]{ cos, sin, 0, 0 }, 
                    new float[]{ -sin, cos, 0, 0 }, 
                    new float[]{ 0, 0, 1, 0 }, 
                    new float[]{ 0, 0, 0, 1 } };
            }

            triangle = matrixMultiply(triangle, transform);

        }
        
        private void resetButton_Click(object sender, EventArgs e)
        {
            triangle = initTriangle;
        }


    }
}
