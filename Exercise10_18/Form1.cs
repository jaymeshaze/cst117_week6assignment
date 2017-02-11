using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Create a program to display a circle and a line, and allow the user to choose which figures
//to move.Add text boxes to allow the user to input the amounts to move in the x and
//y directions, and a button for the user to request the move.Move the selected figure
//when the user presses the button.

namespace Exercise10_18
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void DrawIt()
        {
            g = this.CreateGraphics();
            circle1.Draw(g);
            line1.Draw(g);

            button2.Show();
            textBox1.Show();
            textBox2.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            checkBox1.Show();
            checkBox2.Show();
        }

        private void RedrawIt()
        {
            g.Clear(Color.White);
            circle1.Draw(g);
            line1.Draw(g);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DrawIt();
            button1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int xMove = int.Parse(textBox1.Text);
            int yMove = int.Parse(textBox2.Text);

            if (checkBox1.Checked)
            {
                circle1.Move(xMove, yMove);
            }
            if (checkBox2.Checked)
            {
                line1.Move(xMove, yMove);
            }

            RedrawIt();
        }
    }

    public abstract class Shape
    {
        protected Point location;

        public Shape()
        {
            location = new Point(0, 0);
        }

        public Shape(Point p)
        {
            location = p;
        }

        public abstract void Draw(Graphics g);

        public virtual void Move(int xamount, int yamount)
        {
            location += new Size(xamount, yamount);
        }
        public override String ToString()
        {
            return location.ToString();
        }
    }

    public class Line : Shape
    {
        protected Point end;
        public Line(int x1, int y1, int x2, int y2)
        : base(new Point(x1, y1))
        {
            end = new Point(x2, y2);
        }
        public override void Draw(Graphics g)
        {
            Pen blue = new Pen(Color.Blue, 3);
            g.DrawLine(blue, location, end);
        }
        public override String ToString()
        {
            return "Line from " + base.ToString()
            + " to " + end;
        }
        public override void Move(int xamount, int yamount)
        {
            base.Move(xamount, yamount);
            end += new Size(xamount, yamount);
        }
    }

    public class Circle : Shape
    {
        int radius;
        public Circle(Point p, int r) : base(p)
        {
            radius = r;
        }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Red, location.X - radius,
            location.Y - radius, 2 * radius, 2 * radius);
        }
        public override string ToString()
        {
            return "Circle at " + base.ToString()
            + " with radius " + radius;
        }
    }
}
