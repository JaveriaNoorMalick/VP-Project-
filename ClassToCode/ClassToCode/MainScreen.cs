using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_PROJECT;

namespace ClassToCode
{
    public partial class MainScreen : Form
    {
        bool isPressed = false;
        bool isAssociationActive = false;
        int countClasses = 0;

        ErrorList el;

        public MainScreen()
        {
            InitializeComponent();
            el = new ErrorList(" ",' ');
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            MainScreen mn = new MainScreen();
            mn.Text = "UML Class To Code";
            el.MdiParent = this;
        }
        //FOR DRAWING RELATIONS
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen p = new Pen(Color.Black))
            using (GraphicsPath capPath = new GraphicsPath())
            {
                // A triangle
                capPath.AddLine(-20, 0, 20, 0);
                capPath.AddLine(-20, 0, 0, 20);
                capPath.AddLine(0, 20, 20, 0);

                p.CustomEndCap = new System.Drawing.Drawing2D.CustomLineCap(null, capPath);

                e.Graphics.DrawLine(p, 0, 50, 100, 50);
                //e.Graphics.DrawLine(p, Utilities.getLocationOfArrw(), P2);
            }
        }

        #region[Generating Class Shapes]

        private void btnShowShapesPannel_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (isPressed == false)
                {
                    // panelShapes.Location = new Point(25,99);
                    panelShapes.Visible = true;
                    isPressed = true;
                    //toolStripVerticalLeft.Visible = false;
                }
                else if (isPressed == true)
                {
                    panelShapes.Visible = false;
                    isPressed = false;
                    toolStripVerticalLeft.Visible = true;

                }
            }
            catch (Exception err)
            {
                // el = new ErrorList(err.Message, 'e');
                // el.Show();
            }
        }
        private void btnClosShapPnl_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripVerticalLeft.Visible = true;
                panelShapes.Visible = false;
                isPressed = false;
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        private void metroTileClass_Click(object sender, EventArgs e)
        {
            try
            {
                countClasses++;
                ClassName fm = new ClassName();
                fm.Text = "Class";
                Utilities.WhichNotation(fm.Text);
                fm.MdiParent = this;
                fm.Show();

            }
            catch (Exception err)
            {
                //el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }
        private void metroTileStruct_Click(object sender, EventArgs e)
        {
            try
            {
                ClassName fm = new ClassName();
                MainScreen mn = new MainScreen();
                fm.Text = "Structure";
                fm.MdiParent = this;
                Utilities.WhichNotation(fm.Text);
                fm.Show();

            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }
        private void metroTileInterfac_Click(object sender, EventArgs e)
        {
            try
            {
                countClasses++;
                ClassName fm = new ClassName();
                MainScreen mn = new MainScreen();
                fm.Text = "Interface";
                fm.MdiParent = this;
                Utilities.WhichNotation(fm.Text);

                fm.Show();

            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }
        private void metroTileEnum_Click(object sender, EventArgs e)
        {
            try
            {
                ClassName fm = new ClassName();
                MainScreen mn = new MainScreen();
                fm.Text = "Enumeration";
                fm.MdiParent = this;
                Utilities.WhichNotation(fm.Text);

                fm.Show();

            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        #endregion

        #region [Generating Relations ]

        private void btnShwReltnPnl_Click(object sender, EventArgs e)
        {
            try
            {
                if (isPressed == false)
                {
                    //toolStripVerRight.Visible = false;
                    isPressed = true;
                    pnlMainForRltns.Visible = true;
                }
                else if (isPressed == true)
                {
                    isPressed = false;
                    pnlMainForRltns.Visible = false;
                }
            }
            catch (Exception err)
            {
                //el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }
        private void btnClosPnlReltn_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripVerRight.Visible = true;
                pnlMainForRltns.Visible = false;
                isPressed = false;
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        private void metroTileAsso_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAssociationActive == false)
                {
                    isAssociationActive = true;
                    Utilities.setAssociation(true);
                    el = new ErrorList("You are in Association mode.\nClick again to disable association", 'm');
                }
                else
                {
                    isAssociationActive = false;
                    Utilities.setAssociation(false);
                    el = new ErrorList("Association mode disabled", 'm');
                
                }
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        private void metroTileGen_Click(object sender, EventArgs e)
        {
            try
            {

                if (countClasses >= 2)
                {
                    if (Utilities.getNotation == "struct")
                    {
                        el = new ErrorList("Structures don't support inheritence", 'm');
                        el.Show();
                    }
                    else
                    {
                        panelRelations.SendToBack();
                        panelGeneralization.Visible = true;
                        panelGeneralization.BringToFront();
                    }

                }
                else if (countClasses < 2)
                {
                    el = new ErrorList("To add relations, you need to add atleast two classes", 'm');
                    el.Show();
                }
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }
        private void btnGenralization_Click(object sender, EventArgs e)
        {
            try
            {
                panelGeneralization.SendToBack();
                panelGeneralization.Visible = false;
                panelRelations.BringToFront();
                panelRelations.Visible = true;


                string[] ParentDataAry = File.ReadAllLines("E:/BSE 6A/vp/VP PROJECT/Classes Generated from UML TO CODE/" + cmBxParnt.Text + ".cs", Encoding.UTF8);
                string[] childDataAry = File.ReadAllLines("E:/BSE 6A/vp/VP PROJECT/Classes Generated from UML TO CODE/" + cmbBxChild.Text + ".cs", Encoding.UTF8);
                string parentData = "";
                for (int i = 0; i < ParentDataAry.Length; i++)
                {

                    parentData += ParentDataAry[i] + "\n";
                }
                string childData = "";
                for (int i = 1; i < childDataAry.Length; i++)
                {
                    childData += (childDataAry[i] + "\n");
                }
                int n = 1;
                string AllData = parentData + "\n " + childDataAry[0] + " : " + cmBxParnt.Text + childData + "\n";
                System.IO.File.WriteAllText("E:/BSE 6A/vp/VP PROJECT/Classes Generated from UML TO CODE/" + cmBxParnt.Text + " " + cmbBxChild.Text + ".cs", AllData);
                el = new ErrorList("Generalized", 'm');
                el.Show();
                n++;

            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            try
            {
                panelRelations.Visible = true;
                panelRelations.BringToFront();
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }
        string parent = "";
        private void cmBxParnt_DropDown(object sender, EventArgs e)
        {
            try
            {
                cmBxParnt.DataSource = null;
                cmBxParnt.DataSource = null;

                cmbBxChild.BindingContext = new BindingContext();
                string[] ary = Utilities.getClassNames();
                /*  if (Utilities.RemoveDuplicates(ary) == true)
                  {
                      el = new ErrorList("Please Change Class name first", 'e');
                      el.Show();
                  }
                  //ary = Utilities.RemoveDuplicates(ary);
                  else
                  {*/
                cmBxParnt.DataSource = ary;
                parent = cmBxParnt.Text;
                //     cmbBxChild.DataSource = ary;
                //  }

            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }
        private void metroTileGen_Paint(object sender, PaintEventArgs e)
        {
            OnPaint(e);
            MessageBox.Show("Paint event occured");
        }
        private void cmbBxChild_DropDown(object sender, EventArgs e)
        {
            try
            {
                cmbBxChild.DataSource = null;
                cmbBxChild.BindingContext = new BindingContext();
                string[] childAry = Utilities.getClassNames();
                cmbBxChild.DataSource = childAry;

            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
            
        }
        private void cmbBxChild_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmBxParnt.Text = parent;
        }

        #endregion

       


    }
}
