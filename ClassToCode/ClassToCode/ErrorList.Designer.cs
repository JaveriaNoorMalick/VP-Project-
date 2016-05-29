namespace ClassToCode
{
    partial class ErrorList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorList));
            this.panelTextBoxes = new System.Windows.Forms.Panel();
            this.txtBoxMessage = new System.Windows.Forms.RichTextBox();
            this.txtBoxError = new System.Windows.Forms.RichTextBox();
            this.txtBoxAddNotes = new System.Windows.Forms.RichTextBox();
            this.toolStripErrLisForm = new System.Windows.Forms.ToolStrip();
            this.btnAddNotes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnError = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMessage = new System.Windows.Forms.ToolStripButton();
            this.btnDropDown = new System.Windows.Forms.ToolStripButton();
            this.panelTextBoxes.SuspendLayout();
            this.toolStripErrLisForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTextBoxes
            // 
            this.panelTextBoxes.Controls.Add(this.txtBoxMessage);
            this.panelTextBoxes.Controls.Add(this.txtBoxError);
            this.panelTextBoxes.Controls.Add(this.txtBoxAddNotes);
            this.panelTextBoxes.Location = new System.Drawing.Point(0, 28);
            this.panelTextBoxes.Name = "panelTextBoxes";
            this.panelTextBoxes.Size = new System.Drawing.Size(1365, 118);
            this.panelTextBoxes.TabIndex = 5;
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxMessage.Location = new System.Drawing.Point(0, 0);
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.Size = new System.Drawing.Size(1365, 118);
            this.txtBoxMessage.TabIndex = 2;
            this.txtBoxMessage.Text = "";
            this.txtBoxMessage.Visible = false;
            // 
            // txtBoxError
            // 
            this.txtBoxError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxError.Location = new System.Drawing.Point(0, 0);
            this.txtBoxError.Name = "txtBoxError";
            this.txtBoxError.Size = new System.Drawing.Size(1365, 118);
            this.txtBoxError.TabIndex = 1;
            this.txtBoxError.Text = "";
            this.txtBoxError.Visible = false;
            // 
            // txtBoxAddNotes
            // 
            this.txtBoxAddNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAddNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxAddNotes.Location = new System.Drawing.Point(0, 0);
            this.txtBoxAddNotes.Name = "txtBoxAddNotes";
            this.txtBoxAddNotes.Size = new System.Drawing.Size(1365, 118);
            this.txtBoxAddNotes.TabIndex = 0;
            this.txtBoxAddNotes.Text = "";
            this.txtBoxAddNotes.Visible = false;
            // 
            // toolStripErrLisForm
            // 
            this.toolStripErrLisForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNotes,
            this.toolStripSeparator1,
            this.btnError,
            this.toolStripSeparator2,
            this.btnMessage,
            this.btnDropDown});
            this.toolStripErrLisForm.Location = new System.Drawing.Point(0, 0);
            this.toolStripErrLisForm.Name = "toolStripErrLisForm";
            this.toolStripErrLisForm.Size = new System.Drawing.Size(1365, 25);
            this.toolStripErrLisForm.TabIndex = 4;
            this.toolStripErrLisForm.Text = "toolStripError";
            // 
            // btnAddNotes
            // 
            this.btnAddNotes.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNotes.Image")));
            this.btnAddNotes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNotes.Name = "btnAddNotes";
            this.btnAddNotes.Size = new System.Drawing.Size(83, 22);
            this.btnAddNotes.Text = "Add Notes";
            this.btnAddNotes.Click += new System.EventHandler(this.btnAddNotes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnError
            // 
            this.btnError.Image = ((System.Drawing.Image)(resources.GetObject("btnError.Image")));
            this.btnError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnError.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(52, 22);
            this.btnError.Text = "Error";
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMessage
            // 
            this.btnMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnMessage.Image")));
            this.btnMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(73, 22);
            this.btnMessage.Text = "Message";
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnDropDown
            // 
            this.btnDropDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDropDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDropDown.Image")));
            this.btnDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDropDown.Name = "btnDropDown";
            this.btnDropDown.Size = new System.Drawing.Size(23, 22);
            this.btnDropDown.Text = "toolStripButton4";
            this.btnDropDown.Click += new System.EventHandler(this.btnDropDown_Click);
            // 
            // ErrorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1365, 145);
            this.Controls.Add(this.panelTextBoxes);
            this.Controls.Add(this.toolStripErrLisForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 580);
            this.Name = "ErrorList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ErrorList";
            this.Load += new System.EventHandler(this.ErrorList_Load);
            this.panelTextBoxes.ResumeLayout(false);
            this.toolStripErrLisForm.ResumeLayout(false);
            this.toolStripErrLisForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTextBoxes;
        private System.Windows.Forms.RichTextBox txtBoxMessage;
        private System.Windows.Forms.RichTextBox txtBoxError;
        private System.Windows.Forms.RichTextBox txtBoxAddNotes;
        private System.Windows.Forms.ToolStrip toolStripErrLisForm;
        private System.Windows.Forms.ToolStripButton btnAddNotes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnError;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnMessage;
        private System.Windows.Forms.ToolStripButton btnDropDown;
    }
}