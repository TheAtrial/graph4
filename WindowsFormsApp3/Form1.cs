using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {

        DrawGraph G;
        List<Vertex> V;
        List<Edge> E;
        List<Neighbor> N;
        Random x = new Random();

        int selected1; //выбранные вершины, для соединения линиями
        int selected2;

        public Form1()
        {
            InitializeComponent();
            V = new List<Vertex>();
            G = new DrawGraph(sheet.Width, sheet.Height);
            E = new List<Edge>();
            N = new List<Neighbor>();
            sheet.Image = G.GetBitmap();
        }

        //кнопка - выбрать вершину
        private void SelectB_Click(object sender, EventArgs e)
        {
            SelectB.Enabled = false;
            VertexB.Enabled = true;
            EdgeB.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
            selected1 = -1;
        }

        //кнопка - рисовать вершину
        private void VertexB_Click(object sender, EventArgs e)
        {
            VertexB.Enabled = false;
            SelectB.Enabled = true;
            EdgeB.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
        }

        //кнопка - рисовать ребро
        private void EdgeB_Click(object sender, EventArgs e)
        {
            EdgeB.Enabled = false;
            SelectB.Enabled = true;
            VertexB.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
            selected1 = -1;
            selected2 = -1;
        }

        //кнопка - рассчет пути
        private void Shw_Click(object sender, EventArgs e)
        {

            const string caption2 = "Стартовой вершины не существует в графе!";
            const string caption3 = "Конечной вершины не существует в графе!";
            
            try
            {
                int start = int.Parse(textBox2.Text);
                int end = int.Parse(textBox3.Text);
                int c = int.Parse(textBox5.Text);
                if (start - 1 > V.Count || start - 1 < 0)
                {
                    MessageBox.Show(caption2);
                }
                else if (end - 1 > V.Count || end - 1 < 0)
                {
                    MessageBox.Show(caption3);
                }
                else if (E.Count == 0)
                {
                    MessageBox.Show("Ошибка! Не заданы ребра!");
                }
                else //if (start -1 <= V.Count && start > 0 && end -1 > 0 && end -1 < V.Count)
                {
                    List<Neighbor> _N = new List<Neighbor>();
                    //int r = G.deija(E, V, N, start);
                    int[] res = G.deija(E, V, _N, start);
                    int start1 = start - 1;
                    List<int> path = new List<int>();
                    int curver = end - 1;
                    int rez = V[curver].zn;
                    textBox4.Text += rez.ToString();
                    bool nedostizhimo = false;
                    int[] Vershini = new int[V.Count];
                    for (int i = 0; i < V.Count; i++)
                    {
                        Vershini[i] = i;
                    }
                    while (!nedostizhimo && curver != start - 1)
                    {
                        path.Insert(0, curver);
                        curver = res[curver];
                        if (curver == int.MaxValue)
                            nedostizhimo = true;
                    }
                    int q = 0;
                    if (!nedostizhimo)
                    {
                        path.Insert(0, start1);
                        textBox1.Clear();
                        foreach (int ver in path)
                        {
                            int kletka = Array.IndexOf(Vershini, ver) + 1;
                            if (kletka == c)
                            {
                                q++;
                            }
                            textBox1.Text += kletka.ToString() + " ";
                        }

                    }
                    if (q != 0)
                    {
                        MessageBox.Show("Проходит через заданную вершину");
                    }
                    else if (q == 0)
                    {
                        MessageBox.Show("Не проходит через заданную вершину");
                    }
                }
            }
            catch (FormatException)
            {
                const string caption4 = "Некорректное имя вершины! Используйте другое";
                MessageBox.Show(caption4);
            }
        }


        private void sheet_MouseClick(object sender, MouseEventArgs e)
        {
            int rand = x.Next(1, 50);
            bool metka = false;
            if (SelectB.Enabled == false)
            {
                for (int i = 0; i < V.Count; i++)
                {
                    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        if (selected1 != -1)
                        {
                            selected1 = -1;
                            G.clearSheet();
                            G.drawALLGraph(V, E);
                            sheet.Image = G.GetBitmap();
                        }
                    }
                }
            }
            // добавление вершины
            if (VertexB.Enabled == false)
            {
                V.Add(new Vertex(e.X, e.Y, metka, rand));
                G.drawVertex(e.X, e.Y, V.Count.ToString(), metka);
                sheet.Image = G.GetBitmap();
            }
            // добавление ребра
            if (EdgeB.Enabled == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    for (int i = 0; i < V.Count; i++)
                    {
                        if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                        {
                            if (selected1 == -1)
                            {
                                G.drawSelectedVertex(V[i].x, V[i].y);
                                selected1 = i;
                                sheet.Image = G.GetBitmap();
                                break;
                            }
                            if (selected2 == -1)
                            {
                                G.drawSelectedVertex(V[i].x, V[i].y);
                                selected2 = i;
                                E.Add(new Edge(selected1, selected2, rand, metka));
                                G.drawEdge(V[selected1], V[selected2], E[E.Count - 1], rand);
                                selected1 = -1;
                                selected2 = -1;
                                sheet.Image = G.GetBitmap();
                                break;
                            }
                        }
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    if ((selected1 != -1) &&
                        (Math.Pow((V[selected1].x - e.X), 2) + Math.Pow((V[selected1].y - e.Y), 2) <= G.R * G.R))
                    {
                        G.drawVertex(V[selected1].x, V[selected1].y, (selected1 + 1).ToString(), metka);
                        selected1 = -1;
                        sheet.Image = G.GetBitmap();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                aboutForm FormAbout = new aboutForm();
                FormAbout.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
