using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_PROJECT;

namespace ClassToCode
{
    public partial class ClassName : Form
    {
        #region[Members]

        bool isAttributePanelActive = false;
        bool isMethodPanelActive = false;
        bool isMembersActive = true;
        
        string[] attribArray = new String[100];
        int attributesPosition = 0;
        string[] methodArray = new string[100];
        int methodsPosition = 0;
        string[] objArray = new string[100];
        int objPos = 0;
        string objParam;
        string modifier;
        string name;
        public static string chkTile;
        string[] enumMembersAry = new string[100];
        int pos = 0;
        // string[] enumTyp;
        string enumMembers;
        string[] cmBxRetrnTypData = { "void", "int", "bool", "string", "char", "byte", "DateTime", "double", "float", "Int16", "Int32", "Int64", "sbyte", "long", "uint", "UInt16", "UInt32", "decimal" };

        ErrorList el;
        ClassName cn;

        /*  private bool _dragging = false;
          private Point _offset;
          private Point _start_point = new Point(0, 0);*/

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        #endregion
        public ClassName()
        {
            InitializeComponent();
        }

        private void ClassName_Load(object sender, EventArgs e)
        {
            try
            {
                cn = new ClassName();
                if (Utilities.getNotation == "enum")
                {
                    panelOpertns.Visible = false;
                    toolStripOperations.Visible = false;
                    txtBoxMethods.Visible = false;
                    this.Size = new Size(241, 244);
                    filingButton.Location = new Point(0, 183);
                }
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        


        #region [Generate Code]
        private void filingButton_Click(object sender, EventArgs e)
        {
            try
            {

                string className = txtClassName.Text + ".cs";
                string classText = getCurrentModifier(lbModifiersClass) + " " + Utilities.ReturnNotation() + " " + txtClassName.Text + " \n{\n";
                string attrib = "";
                string method = "";
                if (Utilities.getNotation == "enum")
                {
                    for (int i = 0; i < enumMembersAry.Length; i++)
                    {
                        if (enumMembersAry[i] != null)
                        {
                            enumMembers += enumMembersAry[i] + "\n";
                        }
                    }
                    string body = "{\n" + enumMembers + "\n}";
                    string allDataOfEnum = " enum " + txtClassName.Text + " : " + cmbDataType.Text + "\n" + body;
                    System.IO.File.WriteAllText("E:/BSE 6A/vp/VP PROJECT/Classes Generated from UML TO CODE/" + className, allDataOfEnum);
                    el = new ErrorList("Enum has been Generated", 'm');
                    el.Show();

                }
                else
                {
                    for (int i = 0; i < attribArray.Length; i++)
                    {
                        if (attribArray[i] != null)
                        {
                            attrib += attribArray[i] + "\n";
                        }
                    }
                    for (int i = 0; i < methodArray.Length; i++)
                    {
                        if (methodArray[i] != null)
                        {
                            method += "\n" + getCurrentModifier(lbModOpertns) + " " + methodArray[i] + "\n" + "{\n\n}";
                        }
                    }

                   
                    string classEnd = "\n}";
                    string AllData = classText + attrib + method + classEnd;
                    System.IO.File.WriteAllText("E:/BSE 6A/vp/VP PROJECT/Classes Generated from UML TO CODE/" + className, AllData);
                    el = new ErrorList("Class Code has been Generated", 'm');
                    el.Show();
                    //MessageBox.Show("Class Code is Generated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        #endregion

        #region [Graphical Method Appearance]

        public void HideAttributesPanel(Panel pnl)
        {
            try
            {
                pnl.Visible = false;
                isAttributePanelActive = false;
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }

        }

        //code for drag n drop
        protected override void WndProc(ref Message m)
        {
            try
            {
                base.WndProc(ref m);
                if (m.Msg == WM_NCHITTEST)
                    m.Result = (IntPtr)(HT_CAPTION);
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }

        }

        #endregion
        #region [Graphical Method Appearance]
        private void btnShrinkClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (isMembersActive == true)
                {
                    txtBoxAttributes.Visible = false;
                    pnlDataMembers.Visible = false;
                    isMembersActive = false;
                    txtBoxMethods.Location = new Point(0, 24);
                    txtBoxMethods.Location = new Point(0, 43);
                    filingButton.Location = new Point(0, 183);
                    this.Size = new Size(241, 203);
                    isMembersActive = false;
                    btnShrinkClass.Image = Image.FromFile(@"E:\BSE 6A\vp\icons\show4.png");

                }
                else
                    if (isMembersActive == false)
                    {
                        txtBoxAttributes.Visible = true;
                        isMembersActive = true;
                        txtBoxMethods.Location = new Point(0, 181);
                        txtBoxMethods.Location = new Point(0, 204);
                        filingButton.Location = new Point(0, 362);
                        this.Size = new Size(241, 418);
                        isMembersActive = true;
                        btnShrinkClass.Image = Image.FromFile(@"E:\BSE 6A\vp\icons\show3.png");
                    }

            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        private void btnShowDataMemPnl_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAttributePanelActive == false)
                {
                    pnlDataMembers.Visible = true;
                    isAttributePanelActive = true;
                    btnShowDataMemPnl.Image = Image.FromFile(@"E:\BSE 6A\vp\icons\arrowDrop.png");


                }
                else
                    if (isAttributePanelActive == true)
                    {
                        pnlDataMembers.Visible = false;
                        isAttributePanelActive = false;
                        btnShowDataMemPnl.Image = Image.FromFile(@"E:\BSE 6A\vp\icons\arrow.png");
                    }
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        private void btnShowOperationPanl_Click(object sender, EventArgs e)
        {
            try
            {
                if (isMethodPanelActive == false)
                {
                    panelOpertns.Visible = true;
                    isMethodPanelActive = true;
                    btnShowOperationPanl.Image = Image.FromFile(@"E:\BSE 6A\vp\icons\arrowDrop.png");

                }
                else
                    if (isMethodPanelActive == true)
                    {
                        panelOpertns.Visible = false;
                        isMethodPanelActive = false;
                        btnShowOperationPanl.Image = Image.FromFile(@"E:\BSE 6A\vp\icons\arrow.png");

                    }
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        private void txtBoxMethods_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // HideAttributesPanel(pnlDataMembers);
                HideAttributesPanel(panelOpertns);
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        private void txtBoxAttributes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // HideAttributesPanel(pnlDataMembers);
                HideAttributesPanel(pnlDataMembers);
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }
        #endregion

        #region[setup class members]
        public void settingModifiers(Label lb)
        {
            try
            {
                if (lb.Text == "+")
                {
                    lb.Text = "-";
                }
                else if (lb.Text == "-")
                {
                    lb.Text = "#";
                }
                else
                {
                    lb.Text = "+";
                }
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }

        }

        //getting current modifier of class,atrrib and operations.

        public String getCurrentModifier(Label lb)
        {
            try
            {
                if (lb.Text == "#")
                {
                    modifier = "protected";
                }
                else if (lb.Text == "-")
                {
                    modifier = "private";
                }
                else
                {
                    modifier = "public";
                }
                return modifier;
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
                return err.Message;
            }

        }

        private void lbModDm_Click(object sender, EventArgs e)
        {
            try
            {
                settingModifiers(lbModDm);

            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }
        
        private void lbModifiersClass_Click(object sender, EventArgs e)
        {
            try
            {

                settingModifiers(lbModifiersClass);
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        private void lbModOpertns_Click(object sender, EventArgs e)
        {
            try
            {
                settingModifiers(lbModOpertns);

            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        private void btnDoneDm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDataMemberName.Text == "")
                {
                    // MessageBox.Show("Please provide variable name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    el = new ErrorList("Please Provide Variable Name", 'e');
                    el.Show();

                }
                else
                    if (cmbDataType.Text == "")
                    {

                        el = new ErrorList("Please Provide Return Type", 'e');
                        el.Show();
                    }
                    else
                    {
                        if (txtBoxAttributes.Text != "")
                        {
                            txtBoxAttributes.AppendText("\n");
                        }
                        ////modification for enum
                        if (Utilities.getNotation == "enum")
                        {
                            txtBoxAttributes.AppendText(txtDataMemberName.Text + "\n");
                            enumMembersAry[pos] = txtDataMemberName.Text + ";";
                            pos++;
                            txtDataMemberName.Text = "";

                        }
                        
                        else
                        {

                            txtBoxAttributes.AppendText(txtDataMemberName.Text + ":" + cmbDataType.Text);
                            attribArray[attributesPosition] = cmbDataType.Text + " " + txtDataMemberName.Text + ";";
                            attributesPosition++;
                            //clear textbox 
                        }
                        if(Utilities.getAssociation()==true)
                        {
                            objParam += cmbDataType.Text +" " +txtDataMemberName.Text;
                            objPos++;

                            txtDataMemberName.Text = "";
                            
                        }     
                    }
              // Utilities.setAssociation(false);

            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
            
        }

        private void btnDoneOprtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOprtnNam.Text == "")
                {
                    //MessageBox.Show("Please provide method name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    el = new ErrorList("Please Provide Operation Name", 'e');
                    el.Show();
                }
                else
                    if (cmbOprtnTyp.Text == "")
                    {
                        el = new ErrorList("Please Provide Return Type", 'e');

                        el.Show();
                        // MessageBox.Show("Please provide return type for method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtBoxMethods.Text != "")
                        {
                            txtBoxMethods.AppendText("\n");
                        }
                        if (Utilities.getAssociation() == true)
                        {
                            txtBoxMethods.AppendText(txtOprtnNam.Text + "(" + objParam+")" + ":" + cmbOprtnTyp.Text);
                            methodArray[methodsPosition] = cmbOprtnTyp.Text + " " + txtOprtnNam.Text + " (" + objParam + " )";
                            methodsPosition++;
                        }
                        else
                        {
                            txtBoxMethods.AppendText(txtOprtnNam.Text + ":" + cmbOprtnTyp.Text);
                            methodArray[methodsPosition] = cmbOprtnTyp.Text + " " + txtOprtnNam.Text + "()";
                            methodsPosition++;
                        }


                        txtOprtnNam.Text = " ";
                       // Utilities.setAssociation(false);

                    }

            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        private void cmbDataType_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (Utilities.getAssociation() == true)
                {
                    cmbDataType.DataSource = Utilities.getClassNames();
                    
                }
                else
                {
                    cmbDataType.DataSource = cmBxRetrnTypData;
                }

            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }
        #endregion

        #region [About Class Name]
        private void txtClassName_Leave(object sender, EventArgs e)
        {
            try
            {
                string[] names = Utilities.ChangeClassName(name, oldName);
                bool check = false;

                for (int j = 0; j < names.Length; j++)
                {
                    // for cattering duplication of names
                    if (names[j] == name)
                    {
                        check = true;
                    }
                }

                if (check == true)
                {
                    // name = null;
                    el = new ErrorList("Edit Class Name ", 'e');
                    el.Show();
                    //name = null;
                }
                else
                {
                    Utilities.AddClassName(name);
                }

            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }
        string oldName = "";
        private void txtClassName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox tb = new TextBox();
                tb.Width = tb.Text.Length;
                //name = txtClassName.Text;

            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        private void txtClassName_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                txtClassName.ReadOnly = true;
                name = txtClassName.Text;
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        private void txtClassName_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtClassName.ReadOnly = false;
                oldName = txtClassName.Text;
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        private void ClassName_Leave(object sender, EventArgs e)
        {
            Point location = new Point();
            location = cn.Location;
            Utilities.setLocationOfChildForm(location);
        }
        #endregion

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbOprtnTyp_DropDown(object sender, EventArgs e)
        {
            
                cmbDataType.DataSource = cmBxRetrnTypData;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void cmbMethodsList_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void cmbOprtnTyp_DropDown_1(object sender, EventArgs e)
        {
            try
            {
                    cmbDataType.DataSource = cmBxRetrnTypData;
                
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }





    }
}
