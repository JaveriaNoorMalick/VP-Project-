using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassToCode
{
    public partial class ErrorList : Form
    {
        bool isErrorClicked = false;
        bool isMsgClicked = false;
        bool isClicked = false;

        string errMessage;
        char typeOfMsg;

        ErrorList el;

        public ErrorList(string message, char type)
        {
            InitializeComponent();
            errMessage = message;
            typeOfMsg = type;
        }

        private void ErrorList_Load(object sender, EventArgs e)
        {
            try
            {
                txtBoxError.ReadOnly = true;
                txtBoxMessage.ReadOnly = true;
                el = new ErrorList(" ",' ');
                this.Size = new Size(1365, 25);
                this.Location = new Point(0,710);

                if (typeOfMsg == 'e')
                {
                    btnError.BackColor = Color.Red;
                    btnError.ForeColor = Color.Yellow;
                }
                else if (typeOfMsg == 'm')
                {
                    btnMessage.BackColor = Color.Green;
                    btnMessage.ForeColor = Color.White;
                }
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        private void btnAddNotes_Click(object sender, EventArgs e)
        {
            try
            {
                txtBoxAddNotes.Visible = true;
                txtBoxAddNotes.BringToFront();
                this.Size = new Size(1365, 145);
                this.Location = new Point(0, 580);
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            try
            {
                    if (isErrorClicked == false)
                    {
                        isErrorClicked = true;
                        // txtBoxError.Text = null;
                        btnError.BackColor = Color.Transparent;
                        btnError.ForeColor = Color.Black;
                        txtBoxError.Visible = true;
                        txtBoxError.Text = errMessage;
                        txtBoxError.BringToFront();
                        this.Size = new Size(1365, 145);
                        this.Location = new Point(0, 580);
                    }
                    else if (isErrorClicked == true)
                    {
                        isErrorClicked = false;
                        txtBoxError.Visible = false;
                    }
                
            }
            catch (Exception err)
            {

                el = new ErrorList(err.Message, 'e');
                el.Show();

            }

        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (typeOfMsg == 'm')
                {
                    if (isMsgClicked == false)
                    {
                        isMsgClicked = true;
                        //txtBoxMessage.Text = null;
                        btnMessage.BackColor = Color.Transparent;
                        btnMessage.ForeColor = Color.Black;
                        txtBoxMessage.Visible = true;
                        txtBoxMessage.BringToFront();
                        txtBoxMessage.Text = errMessage;
                        this.Size = new Size(1365, 145);
                        this.Location = new Point(0, 580);
                    }
                    else if (isMsgClicked == true)
                    {
                        isMsgClicked = false;
                        txtBoxMessage.Visible = false;
                    }
                }

            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }
        }

        private void btnDropDown_Click(object sender, EventArgs e)
        {
            try
            {
                if (isClicked == true)
                {
                    isClicked = false;
                    btnDropDown.Image = Image.FromFile(@"E:\BSE 6A\vp\VP PROJECT\icons\arrow.png");
                    panelTextBoxes.Visible = false;
                   // toolStripErrLisForm.Location = new Point(0, 123);
                    this.Size = new Size(1365, 25);
                    this.Location = new Point(0,710);

                }
                else
                {
                    isClicked = true;
                    btnDropDown.Image = Image.FromFile(@"E:\BSE 6A\vp\VP PROJECT\icons\arrowDrop.png");
                   // toolStripErrLisForm.Location = new Point(0, 0);
                    this.Size = new Size(1365, 145);
                    this.Location = new Point(0, 580);
                    panelTextBoxes.Visible = true;
                }
            }
            catch (Exception err)
            {
                el = new ErrorList(err.Message, 'e');
                el.Show();
            }

        }
    }
}
