using NewProject;
using NewProject.ElementsCoordinats;
using NewProject.MethodsConvertEndMath;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewProject1
{
    public partial class DoorControl : Form
    {
        Graph g = new Graph();
        public DoorControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MethodsConvert convertFloatStartWall = new MethodsConvert(startOfWallX.Text, startOfWallY.Text);
            MethodsConvert convertFloatEndWall = new MethodsConvert(endOfWallX.Text, endOfWallY.Text);
            MethodsConvert convertIntEnter = new MethodsConvert(txt_EnterDoorX.Text, EnterY.Text);
            MethodsConvert convertIntExit = new MethodsConvert(ExitX.Text, ExitY.Text);
            if (convertFloatStartWall.IsCordinatsNumericFloat()
                            && convertFloatEndWall.IsCordinatsNumericFloat()
                            && convertIntEnter.IsCordinatsNumericInt()
                            && convertIntExit.IsCordinatsNumericInt())
            {
                if (g.Size.Width > convertIntEnter.x 
                    && g.Size.Width > convertIntExit.x
                    && g.Size.Height > convertIntEnter.y
                    && g.Size.Height > convertIntExit.y)
                {
                    g.StartPoint = new Point(
                                        convertIntEnter.x,
                                        convertIntEnter.y);
                    g.EndPoint = new Point(
                        convertIntExit.x,
                        convertIntExit.y);
                    IntersectionPoint.NewLabel(g.StartPoint, g, "end");
                    IntersectionPoint.NewLabel(g.EndPoint, g, "exit");
                    g.wall = new Wall(
                        convertFloatStartWall.X,
                        convertFloatStartWall.Y,
                        convertFloatEndWall.X,
                        convertFloatEndWall.Y);


                    Element.qauntOfDoor = int.Parse(Qaunt.Text);
                    Element.InternalDoors = new PointF[Element.qauntOfDoor];
                    // Form1 fm = new Form1(txt_EnterDoorX.Text, EnterY.Text, ExitX.Text, ExitY.Text);
                    Form1 fm =new Form1(g);
                    fm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"x cant be larger than {g.Size.Height}" +
                                  $" && y cant be larger than{g.Size.Height}");
                }
            }
            else
            {
 
                    MessageBox.Show("enter a corect coordinates");
            }



            //    if ((g.Size.Width > int.Parse(txt_EnterDoorX.Text) &&
            //    g.Size.Width > int.Parse(ExitX.Text)) &&
            //    (g.Size.Height > int.Parse(EnterY.Text) 
            //    && g.Size.Height> int.Parse(ExitY.Text)))
            //{
            //    Element.qauntOfDoor = int.Parse(Qaunt.Text);
            //    Element.InternalDoors = new PointF[Element.qauntOfDoor];
            //    Form1 fm = new Form1(txt_EnterDoorX.Text, EnterY.Text, ExitX.Text, ExitY.Text);
            //    fm.Show();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show($"x cant be larger than {g.Size.Height}" +
            //                  $" && y cant be larger than{g.Size.Height}");
            //}
        }
            
            
            
        }
       
        //private void Qaunt_TextChanged(object sender, EventArgs e)
        //{

        //}
    }

