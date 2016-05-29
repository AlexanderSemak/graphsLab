using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PrimForms
{
    public partial class Form1 : Form
    {
        private const int areaWidth = 420;
        private const int areaHeight = 300;
        private List<MyPoint> vertices = new List<MyPoint>();
        private Bitmap bitmapAll = new Bitmap(areaWidth, areaHeight);
        private Bitmap bitmapMST = new Bitmap(areaWidth, areaHeight);
        private List<Edge> MSTList = new List<Edge>();
        private List<Edge> allEdges = new List<Edge>();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            var p = new MyPoint(e.X, e.Y, vertices.Count);
            vertices.Add(p);
            comboBox1.Items.Add(p);
            comboBox2.Items.Add(p);
            DrawPoint(p, bitmapAll, pictureBoxAll, Color.Blue);
            if (vertices.Count > 1)
                comboBox1.SelectedIndex = comboBox1.SelectedIndex + 1;
            comboBox2.SelectedIndex = comboBox2.SelectedIndex + 1;
        }

        private void DrawPoint(MyPoint p, Bitmap bitmap, PictureBox pb, Color color)
        {
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawEllipse(new Pen(color), p.X, p.Y, 3, 3);
                g.DrawString(p.ToString(), new Font("Arial", 12), new SolidBrush(color), new Point(p.X, p.Y));
            }
            pb.Image = bitmap;
        }

        private void DrawPoint(MyPoint p, Bitmap bitmap, PictureBox pb, Color color, int size)
        {
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawEllipse(new Pen(color), p.X, p.Y, size, size);
                g.DrawString(p.ToString(), new Font("Arial", 12), new SolidBrush(color), new Point(p.X, p.Y));
            }
            pb.Image = bitmap;
        }

        private void buttonMakeEdge_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox2.SelectedIndex)
                return;
            if (!(comboBox1.SelectedItem is MyPoint) || !(comboBox2.SelectedItem is MyPoint))
                return;
            MyPoint p1 = (MyPoint)comboBox1.SelectedItem;
            MyPoint p2 = (MyPoint)comboBox2.SelectedItem;

            using (var g = Graphics.FromImage(bitmapAll))
            {
                g.DrawLine(new Pen(Color.Red), p1.X, p1.Y, p2.X, p2.Y);
            }
            Edge edge = new Edge(Math.Min(p1.Number, p2.Number), Math.Max(p1.Number, p2.Number), (int)numericUpDownWeight.Value);
            if (allEdges.Select(x => (x.v1 == edge.v1 && x.v2 == edge.v2) || (x.v1 == edge.v2 && x.v2 == edge.v1))
                    .Count(xc => xc) < 1)
            {
                allEdges.Add(edge);
                /* using (var g = Graphics.FromImage(bitmapAll))
                 {
                     g.DrawString(numericUpDownWeight.Value.ToString(), new Font("Arial", 12), new SolidBrush(Color.Blue), medium(p1, p2));
                 }*/
            }
            pictureBoxAll.Image = bitmapAll;
        }

        private Point medium(MyPoint p1, MyPoint p2)
        {
            return new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            vertices.Clear();
            allEdges.Clear();
            MSTList.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            using (var g = Graphics.FromImage(bitmapAll))
                g.Clear(Color.White);
            using (var g = Graphics.FromImage(bitmapMST))
                g.Clear(Color.White);
            pictureBoxAll.Image = bitmapAll;
            pictureBoxMST.Image = bitmapMST;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var g = Graphics.FromImage(bitmapAll))
                g.Clear(Color.White);
            pictureBoxAll.Image = bitmapAll;

            using (var g = Graphics.FromImage(bitmapMST))
                g.Clear(Color.White);
            pictureBoxMST.Image = bitmapMST;
        }

        private void buttonFindMST_Click(object sender, EventArgs e)
        {
            try
            {
                PrimAglorithm.AlgorithmByPrim(vertices.Count, allEdges, MSTList);
                foreach (var point in vertices)
                {
                    DrawPoint(point, bitmapMST, pictureBoxMST, Color.Red);
                }
                foreach (var edge in MSTList)
                {
                    var p1 = vertices[edge.v1];
                    var p2 = vertices[edge.v2];
                    using (var g = Graphics.FromImage(bitmapMST))
                    {
                        g.DrawLine(new Pen(Color.Red), p1.X, p1.Y, p2.X, p2.Y);
                        g.DrawString(edge.weight.ToString(), new Font("Arial", 12), new SolidBrush(Color.Blue),
                            medium(p1, p2));
                    }
                }
                pictureBoxMST.Image = bitmapMST;
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно побудовано граф");
            }
        }

        private void pictureBoxAll_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void pictureBoxAll_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void pictureBoxAll_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void buttonDFS_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(dfs);
            t.Start();
        }

        public void dfs()
        {
            Stack<MyPoint> S = new Stack<MyPoint>();
            S.Push(vertices[0]);

            while (S.Where(r => r.white).ToList().Count != 0)
            {
                if (S.Peek().white)
                {
                    var peek = S.Peek();
                    DrawPoint(peek, bitmapAll, pictureBoxAll, Color.Black);
                    S.Peek().white = false;
                    S.Pop();
                    Thread.Sleep(1000);

                    var listSuppv1 = allEdges.FindAll(ed => ed.v1 == peek.Number).ToList();
                    var listSuppv2 = allEdges.FindAll(ed => ed.v2 == peek.Number).ToList();
                    foreach (var edge in listSuppv1)
                    {
                        if (vertices[edge.v2].white)
                        {
                            S.Push(vertices[edge.v2]);
                        }
                    }
                    foreach (var edge in listSuppv2)
                    {
                        if (vertices[edge.v1].white)
                        {
                            S.Push(vertices[edge.v1]);
                        }
                    }
                }
            }
        }

        public void bfs()
        {
            List<MyPoint> list = new List<MyPoint>();
            list.Add(vertices[0]);
            while (list.FindAll(c => c.white).Count > 0)
            {

            }
        }

        private void buttonBFS_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(bfs);
            t.Start();
        }
    }
}