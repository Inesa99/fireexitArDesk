using NewProject.MethodsConvertEndMath;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewProject
{
    public partial class Form1 : Form
    {
        int count = 0;
        Graph g { get; set; } 
       // public int Enterx;
      //  public int Entery;
       // public int ExitX;
       // public int ExitY;
        public Form1(Graph graph)
        {
            
            InitializeComponent();
            g = graph;
        }
        //public Form1(string value1, string value2, string value3, string value4)
        //{
        //    var tupleEnter = Element.GetCordinate(value1, value2);
        //    var tupleExit = Element.GetCordinate(value3, value4);
        //    Enterx = tupleEnter.Item1;
        //    Entery = tupleEnter.Item2;
        //    ExitX = tupleExit.Item1;
        //    ExitY = tupleExit.Item2;

        //    InitializeComponent();

        //}

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (g.Size.Width > int.Parse(Internaldoorx.Text) &&

                (g.Size.Height > int.Parse(internaldoory.Text)))
                {

                if (count < Element.qauntOfDoor)
                {
                    MethodsConvert coordinatsObstacles = new MethodsConvert(obstacleX.Text, obstacleY.Text);

                    var tuple = Element.GetCordinate(Internaldoorx.Text, internaldoory.Text);
                    int x = tuple.Item1;
                    int y = tuple.Item2;

                    
                    Label namelabel = new Label();
                    namelabel.Location = new Point(x, y);


                    if (count <= Element.qauntOfDoor 
                        && coordinatsObstacles.IsCordinatsNumericInt())
                    {
                        IntersectionPoint.AddCoordinatsObstacles(coordinatsObstacles.x, 
                                                                 coordinatsObstacles.y);
                        IntersectionPoint.NewLabel(new Point(coordinatsObstacles.x,
                                                             coordinatsObstacles.y), g, "Obs");
                        Element.InternalDoors[count] = new PointF(x, y);

                        count++;
                    }

                    namelabel.Text = "door";
                    namelabel.Size = new Size(20, 20);
                    g.Controls.Add(namelabel);

                    Internaldoorx.Text = String.Empty;
                    internaldoory.Text = String.Empty;
                    obstacleX.Text = String.Empty;
                    obstacleY.Text=String.Empty;
                    // this.Hide();

                }
                else { MessageBox.Show("You can add doors anymore "); }

            }

            else
            {
                MessageBox.Show($"x cant be larger than {g.Size.Height} && y cant be larger than{g.Size.Height}");
            }
        
        } 
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (count < Element.qauntOfDoor)
            {
                MessageBox.Show("you must insert all doors");
            }
            else
            {
                //Label namelabel = new Label();
                //namelabel.Location = new Point(Enterx, Entery);
                //Element.points[0] = new PointF(Enterx, Entery);

                //namelabel.Text = "Enter";
                //g.Controls.Add(namelabel);

                //Label namelabel2 = new Label();
                //namelabel2.Location = new Point(ExitX, ExitY);
                //Element.points[2] = new PointF(ExitX, ExitY);


                //namelabel2.Text = "Exit";
                //g.Controls.Add(namelabel2);

                g.Show();
                this.Close();

            }

        }
    }
}
