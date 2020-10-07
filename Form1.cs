using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_Geometry2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckTriangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException();
            }
            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                throw new ArgumentException();
            }
        }

        private void btnComputeTriangle_Click(object sender, EventArgs e)
        {
            
            double side1 = 0.0;
            double side2 = 0.0;
            double side3 = 0.0;
            try
            {
                side1 = double.Parse(tbSide1.Text);
                side2 = double.Parse(tbSide2.Text);
                side3 = double.Parse(tbSide3.Text);
                CheckTriangle(side1, side2, side3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильно введена сторона {0}", ex.Message);
                return;
            }
            Triangle tr = new Triangle(side1, side2, side3);
            tbPerimeter.Text = tr.Perimeter().ToString();
            tbArea.Text = tr.Area().ToString();
        }

        private void btnClearTriangle_MouseClick(object sender, MouseEventArgs e)
        {
            tbSide1.Clear();
            tbSide2.Clear();
            tbSide3.Clear();
            tbPerimeter.Clear();
            tbArea.Clear();
        }

        private void lblSide1_Click(object sender, EventArgs e)
        {

        }

        private void CheckCircle(double radius)
        {
            if(radius <= 0)
            {
                throw new ArgumentException();
            }
        }

        private void btnComputeCircle_Click(object sender, EventArgs e)
        {
            double radius = 0.0;
            try
            {
                radius = double.Parse(tbRadius.Text);
                CheckCircle(radius);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Неправильно введений радіус");
                return;
            }
            Circle cr = new Circle(radius);
            tbPerimeterCircle.Text = cr.Perimeter().ToString();
            tbAreaCircle.Text = cr.Area().ToString();
        }

        private void btnClearCircle_Click(object sender, EventArgs e)
        {
            tbRadius.Clear();
            tbPerimeterCircle.Clear();
            tbAreaCircle.Clear();
        }

        private void CheckRectangle(double side1, double side2)
        {
            if(side1 <= 0 || side2 <= 0)
            {
                throw new ArgumentException();
            }
        }


        private void btnComputeRectangle_Click_1(object sender, EventArgs e)
        {
            double side1 = 0.0;
            double side2 = 0.0;
            try
            {
                side1 = double.Parse(tbSide1Rectangle.Text);
                side2 = double.Parse(tbSide2Rectangle.Text);
                CheckRectangle(side1, side2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильно введена сторона");
                return;
            }
            Rectangle rect = new Rectangle(side1, side2);
            tbPerimeterRectangle.Text = rect.Perimeter().ToString();
            tbAreaRectangle.Text = rect.Area().ToString();
        }

        private void btnClearRectangle_Click(object sender, EventArgs e)
        {
            tbSide1Rectangle.Clear();
            tbSide2Rectangle.Clear();
            tbPerimeterRectangle.Clear();
            tbAreaRectangle.Clear();
        }

        private void CheckSquare(double side)
        {
            if(side <= 0)
            {
                throw new ArgumentException();
            }
        }

        private void btnComputeSqure_Click(object sender, EventArgs e)
        {
            double side = 0.0;
            try
            {
                side = double.Parse(tbSideSquare.Text);
                CheckSquare(side);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Неправильно введена сторона");
                return;
            }
            Square sq = new Square(side);
            tbPerimeterSquare.Text = sq.Perimeter().ToString();
            tbAreaSquare.Text = sq.Area().ToString();
        }

        private void btnClearSquare_Click(object sender, EventArgs e)
        {
            tbSideSquare.Clear();
            tbPerimeterSquare.Clear();
            tbAreaSquare.Clear();
        }

        private void CheckRhomb(double diagonal1, double diagonal2)
        {
            if(diagonal1 <= 0 || diagonal2 <= 0)
            {
                throw new ArgumentException();
            }
        }

        private void btnComputeRhomb_Click(object sender, EventArgs e)
        {
            double diagonal1 = 0.0;
            double diagonal2 = 0.0;
            try
            {
                diagonal1 = double.Parse(tbDiagonal1Rhomb.Text);
                diagonal2 = double.Parse(tbDiagonal2Rhomb.Text);
                CheckRhomb(diagonal1, diagonal2);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Неправильно введена діагональ");
                return;
            }
            Rhomb rh = new Rhomb(diagonal1, diagonal2);
            tbPerimeterRhomb.Text = rh.Perimeter().ToString();
            tbAreaRhomb.Text = rh.Area().ToString();
        }

        private void btnClearRhomb_Click(object sender, EventArgs e)
        {
            tbDiagonal1Rhomb.Clear();
            tbDiagonal2Rhomb.Clear();
            tbPerimeterRhomb.Clear();
            tbAreaRhomb.Clear();
        }
    }
}
