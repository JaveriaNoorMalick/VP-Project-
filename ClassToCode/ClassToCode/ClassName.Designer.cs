namespace ClassToCode
{
    partial class ClassName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassName));
            this.panelOfOperationsandProperties = new System.Windows.Forms.Panel();
            this.panelOpertns = new System.Windows.Forms.Panel();
            this.cmbOprtnTyp = new MetroFramework.Controls.MetroComboBox();
            this.lbModOpertns = new System.Windows.Forms.Label();
            this.btnDoneOprtn = new MetroFramework.Controls.MetroButton();
            this.txtOprtnNam = new MetroFramework.Controls.MetroTextBox();
            this.lbRtrnTypOprtn = new System.Windows.Forms.Label();
            this.lbNamOpertn = new System.Windows.Forms.Label();
            this.txtBoxMethods = new System.Windows.Forms.RichTextBox();
            this.filingButton = new MetroFramework.Controls.MetroButton();
            this.pnlDataMembers = new System.Windows.Forms.Panel();
            this.lbModDm = new System.Windows.Forms.Label();
            this.btnDoneDm = new MetroFramework.Controls.MetroButton();
            this.txtDataMemberName = new MetroFramework.Controls.MetroTextBox();
            this.lbDataTypeProperties = new System.Windows.Forms.Label();
            this.lbNamDataTyp = new System.Windows.Forms.Label();
            this.cmbDataType = new MetroFramework.Controls.MetroComboBox();
            this.toolStripOperations = new System.Windows.Forms.ToolStrip();
            this.btnDropDownMethdPannel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnShowOperationPanl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddParam = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnShrinkClass = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnShowDataMemPnl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddObj = new System.Windows.Forms.ToolStripButton();
            this.txtBoxAttributes = new System.Windows.Forms.RichTextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lbModifiersClass = new System.Windows.Forms.Label();
            this.panelOfOperationsandProperties.SuspendLayout();
            this.panelOpertns.SuspendLayout();
            this.pnlDataMembers.SuspendLayout();
            this.toolStripOperations.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOfOperationsandProperties
            // 
            this.panelOfOperationsandProperties.Controls.Add(this.panelOpertns);
            this.panelOfOperationsandProperties.Controls.Add(this.txtBoxMethods);
            this.panelOfOperationsandProperties.Controls.Add(this.filingButton);
            this.panelOfOperationsandProperties.Controls.Add(this.pnlDataMembers);
            this.panelOfOperationsandProperties.Controls.Add(this.toolStripOperations);
            this.panelOfOperationsandProperties.Controls.Add(this.toolStrip1);
            this.panelOfOperationsandProperties.Controls.Add(this.txtBoxAttributes);
            this.panelOfOperationsandProperties.Location = new System.Drawing.Point(0, 37);
            this.panelOfOperationsandProperties.Name = "panelOfOperationsandProperties";
            this.panelOfOperationsandProperties.Size = new System.Drawing.Size(243, 388);
            this.panelOfOperationsandProperties.TabIndex = 5;
            // 
            // panelOpertns
            // 
            this.panelOpertns.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelOpertns.Controls.Add(this.cmbOprtnTyp);
            this.panelOpertns.Controls.Add(this.lbModOpertns);
            this.panelOpertns.Controls.Add(this.btnDoneOprtn);
            this.panelOpertns.Controls.Add(this.txtOprtnNam);
            this.panelOpertns.Controls.Add(this.lbRtrnTypOprtn);
            this.panelOpertns.Controls.Add(this.lbNamOpertn);
            this.panelOpertns.Location = new System.Drawing.Point(108, 208);
            this.panelOpertns.Name = "panelOpertns";
            this.panelOpertns.Size = new System.Drawing.Size(133, 158);
            this.panelOpertns.TabIndex = 9;
            this.panelOpertns.Visible = false;
            // 
            // cmbOprtnTyp
            // 
            this.cmbOprtnTyp.FormattingEnabled = true;
            this.cmbOprtnTyp.ItemHeight = 23;
            this.cmbOprtnTyp.Items.AddRange(new object[] {
            "string",
            "int",
            "bool",
            "void",
            "char"});
            this.cmbOprtnTyp.Location = new System.Drawing.Point(3, 83);
            this.cmbOprtnTyp.Name = "cmbOprtnTyp";
            this.cmbOprtnTyp.Size = new System.Drawing.Size(127, 29);
            this.cmbOprtnTyp.TabIndex = 8;
            this.cmbOprtnTyp.UseSelectable = true;
            this.cmbOprtnTyp.DropDown += new System.EventHandler(this.cmbOprtnTyp_DropDown_1);
            // 
            // lbModOpertns
            // 
            this.lbModOpertns.AutoSize = true;
            this.lbModOpertns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbModOpertns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModOpertns.ForeColor = System.Drawing.Color.Black;
            this.lbModOpertns.Location = new System.Drawing.Point(110, 8);
            this.lbModOpertns.Name = "lbModOpertns";
            this.lbModOpertns.Size = new System.Drawing.Size(19, 20);
            this.lbModOpertns.TabIndex = 7;
            this.lbModOpertns.Text = "+";
            this.lbModOpertns.Click += new System.EventHandler(this.lbModOpertns_Click);
            // 
            // btnDoneOprtn
            // 
            this.btnDoneOprtn.Location = new System.Drawing.Point(23, 127);
            this.btnDoneOprtn.Name = "btnDoneOprtn";
            this.btnDoneOprtn.Size = new System.Drawing.Size(88, 23);
            this.btnDoneOprtn.TabIndex = 5;
            this.btnDoneOprtn.Text = "Add to Class";
            this.btnDoneOprtn.UseSelectable = true;
            this.btnDoneOprtn.Click += new System.EventHandler(this.btnDoneOprtn_Click);
            // 
            // txtOprtnNam
            // 
            this.txtOprtnNam.Lines = new string[0];
            this.txtOprtnNam.Location = new System.Drawing.Point(3, 32);
            this.txtOprtnNam.MaxLength = 32767;
            this.txtOprtnNam.Name = "txtOprtnNam";
            this.txtOprtnNam.PasswordChar = '\0';
            this.txtOprtnNam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOprtnNam.SelectedText = "";
            this.txtOprtnNam.Size = new System.Drawing.Size(126, 23);
            this.txtOprtnNam.TabIndex = 4;
            this.txtOprtnNam.UseSelectable = true;
            // 
            // lbRtrnTypOprtn
            // 
            this.lbRtrnTypOprtn.AutoSize = true;
            this.lbRtrnTypOprtn.ForeColor = System.Drawing.Color.Black;
            this.lbRtrnTypOprtn.Location = new System.Drawing.Point(3, 66);
            this.lbRtrnTypOprtn.Name = "lbRtrnTypOprtn";
            this.lbRtrnTypOprtn.Size = new System.Drawing.Size(69, 13);
            this.lbRtrnTypOprtn.TabIndex = 3;
            this.lbRtrnTypOprtn.Text = "Return Type:";
            // 
            // lbNamOpertn
            // 
            this.lbNamOpertn.AutoSize = true;
            this.lbNamOpertn.ForeColor = System.Drawing.Color.Black;
            this.lbNamOpertn.Location = new System.Drawing.Point(4, 16);
            this.lbNamOpertn.Name = "lbNamOpertn";
            this.lbNamOpertn.Size = new System.Drawing.Size(38, 13);
            this.lbNamOpertn.TabIndex = 3;
            this.lbNamOpertn.Text = "Name:";
            // 
            // txtBoxMethods
            // 
            this.txtBoxMethods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMethods.Location = new System.Drawing.Point(0, 208);
            this.txtBoxMethods.Name = "txtBoxMethods";
            this.txtBoxMethods.Size = new System.Drawing.Size(241, 158);
            this.txtBoxMethods.TabIndex = 2;
            this.txtBoxMethods.Text = "";
            this.txtBoxMethods.TextChanged += new System.EventHandler(this.txtBoxMethods_TextChanged);
            // 
            // filingButton
            // 
            this.filingButton.Location = new System.Drawing.Point(0, 367);
            this.filingButton.Name = "filingButton";
            this.filingButton.Size = new System.Drawing.Size(241, 20);
            this.filingButton.TabIndex = 5;
            this.filingButton.Text = "Generate Code";
            this.filingButton.UseSelectable = true;
            this.filingButton.Click += new System.EventHandler(this.filingButton_Click);
            // 
            // pnlDataMembers
            // 
            this.pnlDataMembers.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlDataMembers.Controls.Add(this.lbModDm);
            this.pnlDataMembers.Controls.Add(this.btnDoneDm);
            this.pnlDataMembers.Controls.Add(this.txtDataMemberName);
            this.pnlDataMembers.Controls.Add(this.lbDataTypeProperties);
            this.pnlDataMembers.Controls.Add(this.lbNamDataTyp);
            this.pnlDataMembers.Controls.Add(this.cmbDataType);
            this.pnlDataMembers.Location = new System.Drawing.Point(108, 25);
            this.pnlDataMembers.Name = "pnlDataMembers";
            this.pnlDataMembers.Size = new System.Drawing.Size(133, 158);
            this.pnlDataMembers.TabIndex = 8;
            this.pnlDataMembers.Visible = false;
            // 
            // lbModDm
            // 
            this.lbModDm.AutoSize = true;
            this.lbModDm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbModDm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModDm.ForeColor = System.Drawing.Color.Black;
            this.lbModDm.Location = new System.Drawing.Point(110, 7);
            this.lbModDm.Name = "lbModDm";
            this.lbModDm.Size = new System.Drawing.Size(19, 20);
            this.lbModDm.TabIndex = 7;
            this.lbModDm.Text = "+";
            this.lbModDm.Click += new System.EventHandler(this.lbModDm_Click);
            // 
            // btnDoneDm
            // 
            this.btnDoneDm.Location = new System.Drawing.Point(23, 125);
            this.btnDoneDm.Name = "btnDoneDm";
            this.btnDoneDm.Size = new System.Drawing.Size(88, 23);
            this.btnDoneDm.TabIndex = 5;
            this.btnDoneDm.Text = "Add to Class";
            this.btnDoneDm.UseSelectable = true;
            this.btnDoneDm.Click += new System.EventHandler(this.btnDoneDm_Click);
            // 
            // txtDataMemberName
            // 
            this.txtDataMemberName.Lines = new string[0];
            this.txtDataMemberName.Location = new System.Drawing.Point(2, 31);
            this.txtDataMemberName.MaxLength = 32767;
            this.txtDataMemberName.Name = "txtDataMemberName";
            this.txtDataMemberName.PasswordChar = '\0';
            this.txtDataMemberName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDataMemberName.SelectedText = "";
            this.txtDataMemberName.Size = new System.Drawing.Size(126, 23);
            this.txtDataMemberName.TabIndex = 4;
            this.txtDataMemberName.UseSelectable = true;
            // 
            // lbDataTypeProperties
            // 
            this.lbDataTypeProperties.AutoSize = true;
            this.lbDataTypeProperties.ForeColor = System.Drawing.Color.Black;
            this.lbDataTypeProperties.Location = new System.Drawing.Point(4, 67);
            this.lbDataTypeProperties.Name = "lbDataTypeProperties";
            this.lbDataTypeProperties.Size = new System.Drawing.Size(69, 13);
            this.lbDataTypeProperties.TabIndex = 3;
            this.lbDataTypeProperties.Text = "Return Type:";
            // 
            // lbNamDataTyp
            // 
            this.lbNamDataTyp.AutoSize = true;
            this.lbNamDataTyp.ForeColor = System.Drawing.Color.Black;
            this.lbNamDataTyp.Location = new System.Drawing.Point(4, 15);
            this.lbNamDataTyp.Name = "lbNamDataTyp";
            this.lbNamDataTyp.Size = new System.Drawing.Size(38, 13);
            this.lbNamDataTyp.TabIndex = 3;
            this.lbNamDataTyp.Text = "Name:";
            // 
            // cmbDataType
            // 
            this.cmbDataType.FormattingEnabled = true;
            this.cmbDataType.ItemHeight = 23;
            this.cmbDataType.Items.AddRange(new object[] {
            "int",
            "bool",
            "float",
            "decimal",
            "double",
            "char",
            "string",
            "byte",
            "DateTime"});
            this.cmbDataType.Location = new System.Drawing.Point(3, 82);
            this.cmbDataType.Name = "cmbDataType";
            this.cmbDataType.Size = new System.Drawing.Size(126, 29);
            this.cmbDataType.TabIndex = 1;
            this.cmbDataType.UseSelectable = true;
            this.cmbDataType.DropDown += new System.EventHandler(this.cmbDataType_DropDown);
            // 
            // toolStripOperations
            // 
            this.toolStripOperations.AutoSize = false;
            this.toolStripOperations.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripOperations.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDropDownMethdPannel,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.btnShowOperationPanl,
            this.toolStripSeparator1,
            this.btnAddParam});
            this.toolStripOperations.Location = new System.Drawing.Point(0, 183);
            this.toolStripOperations.Name = "toolStripOperations";
            this.toolStripOperations.Size = new System.Drawing.Size(243, 25);
            this.toolStripOperations.TabIndex = 7;
            this.toolStripOperations.Text = "toolStrip2";
            // 
            // btnDropDownMethdPannel
            // 
            this.btnDropDownMethdPannel.AutoSize = false;
            this.btnDropDownMethdPannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDropDownMethdPannel.Image = ((System.Drawing.Image)(resources.GetObject("btnDropDownMethdPannel.Image")));
            this.btnDropDownMethdPannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDropDownMethdPannel.Name = "btnDropDownMethdPannel";
            this.btnDropDownMethdPannel.Size = new System.Drawing.Size(17, 12);
            this.btnDropDownMethdPannel.Text = "toolStripButton2";
            this.btnDropDownMethdPannel.ToolTipText = "Hide Operation Pannel";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabel2.Text = "Methods";
            // 
            // btnShowOperationPanl
            // 
            this.btnShowOperationPanl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnShowOperationPanl.AutoSize = false;
            this.btnShowOperationPanl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowOperationPanl.Image = ((System.Drawing.Image)(resources.GetObject("btnShowOperationPanl.Image")));
            this.btnShowOperationPanl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowOperationPanl.Name = "btnShowOperationPanl";
            this.btnShowOperationPanl.Size = new System.Drawing.Size(18, 19);
            this.btnShowOperationPanl.Text = "toolStripButton2";
            this.btnShowOperationPanl.ToolTipText = "Click to get Operation Pannel";
            this.btnShowOperationPanl.Click += new System.EventHandler(this.btnShowOperationPanl_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddParam
            // 
            this.btnAddParam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddParam.Image = ((System.Drawing.Image)(resources.GetObject("btnAddParam.Image")));
            this.btnAddParam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddParam.Name = "btnAddParam";
            this.btnAddParam.Size = new System.Drawing.Size(90, 22);
            this.btnAddParam.Text = "Add Parameter";
            this.btnAddParam.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShrinkClass,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.btnShowDataMemPnl,
            this.toolStripSeparator4,
            this.btnAddObj});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(243, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnShrinkClass
            // 
            this.btnShrinkClass.AutoSize = false;
            this.btnShrinkClass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShrinkClass.Image = ((System.Drawing.Image)(resources.GetObject("btnShrinkClass.Image")));
            this.btnShrinkClass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShrinkClass.Name = "btnShrinkClass";
            this.btnShrinkClass.Size = new System.Drawing.Size(17, 12);
            this.btnShrinkClass.Text = "toolStripButton1";
            this.btnShrinkClass.ToolTipText = "Hide data members pannel";
            this.btnShrinkClass.Click += new System.EventHandler(this.btnShrinkClass_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "Data Members";
            // 
            // btnShowDataMemPnl
            // 
            this.btnShowDataMemPnl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnShowDataMemPnl.AutoSize = false;
            this.btnShowDataMemPnl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowDataMemPnl.Image = ((System.Drawing.Image)(resources.GetObject("btnShowDataMemPnl.Image")));
            this.btnShowDataMemPnl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowDataMemPnl.Name = "btnShowDataMemPnl";
            this.btnShowDataMemPnl.Size = new System.Drawing.Size(18, 19);
            this.btnShowDataMemPnl.Text = "toolStripButton1";
            this.btnShowDataMemPnl.ToolTipText = "Click to get Data Members Pannel for entring data";
            this.btnShowDataMemPnl.Click += new System.EventHandler(this.btnShowDataMemPnl_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddObj
            // 
            this.btnAddObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddObj.Image = ((System.Drawing.Image)(resources.GetObject("btnAddObj.Image")));
            this.btnAddObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddObj.Name = "btnAddObj";
            this.btnAddObj.Size = new System.Drawing.Size(71, 22);
            this.btnAddObj.Text = "Add Object";
            this.btnAddObj.Visible = false;
            // 
            // txtBoxAttributes
            // 
            this.txtBoxAttributes.BackColor = System.Drawing.Color.White;
            this.txtBoxAttributes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAttributes.Location = new System.Drawing.Point(0, 24);
            this.txtBoxAttributes.Name = "txtBoxAttributes";
            this.txtBoxAttributes.ReadOnly = true;
            this.txtBoxAttributes.Size = new System.Drawing.Size(241, 158);
            this.txtBoxAttributes.TabIndex = 0;
            this.txtBoxAttributes.Text = "";
            this.txtBoxAttributes.TextChanged += new System.EventHandler(this.txtBoxAttributes_TextChanged);
            // 
            // txtClassName
            // 
            this.txtClassName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtClassName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClassName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.ForeColor = System.Drawing.Color.Black;
            this.txtClassName.Location = new System.Drawing.Point(0, 12);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = true;
            this.txtClassName.Size = new System.Drawing.Size(243, 19);
            this.txtClassName.TabIndex = 6;
            this.txtClassName.Text = "Name";
            this.txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClassName.TextChanged += new System.EventHandler(this.txtClassName_TextChanged);
            this.txtClassName.DoubleClick += new System.EventHandler(this.txtClassName_DoubleClick);
            this.txtClassName.Leave += new System.EventHandler(this.txtClassName_Leave);
            this.txtClassName.MouseLeave += new System.EventHandler(this.txtClassName_MouseLeave);
            // 
            // lbModifiersClass
            // 
            this.lbModifiersClass.AutoSize = true;
            this.lbModifiersClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbModifiersClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbModifiersClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModifiersClass.ForeColor = System.Drawing.Color.Black;
            this.lbModifiersClass.Location = new System.Drawing.Point(223, 12);
            this.lbModifiersClass.Name = "lbModifiersClass";
            this.lbModifiersClass.Size = new System.Drawing.Size(19, 20);
            this.lbModifiersClass.TabIndex = 7;
            this.lbModifiersClass.Text = "+";
            this.lbModifiersClass.Click += new System.EventHandler(this.lbModifiersClass_Click);
            // 
            // ClassName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(242, 425);
            this.Controls.Add(this.lbModifiersClass);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.panelOfOperationsandProperties);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassName";
            this.Load += new System.EventHandler(this.ClassName_Load);
            this.Leave += new System.EventHandler(this.ClassName_Leave);
            this.panelOfOperationsandProperties.ResumeLayout(false);
            this.panelOfOperationsandProperties.PerformLayout();
            this.panelOpertns.ResumeLayout(false);
            this.panelOpertns.PerformLayout();
            this.pnlDataMembers.ResumeLayout(false);
            this.pnlDataMembers.PerformLayout();
            this.toolStripOperations.ResumeLayout(false);
            this.toolStripOperations.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOfOperationsandProperties;
        private System.Windows.Forms.Panel panelOpertns;
        private System.Windows.Forms.Label lbModOpertns;
        private MetroFramework.Controls.MetroButton btnDoneOprtn;
        private MetroFramework.Controls.MetroTextBox txtOprtnNam;
        private System.Windows.Forms.Label lbRtrnTypOprtn;
        private System.Windows.Forms.Label lbNamOpertn;
        private MetroFramework.Controls.MetroButton filingButton;
        private System.Windows.Forms.Panel pnlDataMembers;
        private System.Windows.Forms.Label lbModDm;
        private MetroFramework.Controls.MetroButton btnDoneDm;
        private MetroFramework.Controls.MetroTextBox txtDataMemberName;
        private System.Windows.Forms.Label lbDataTypeProperties;
        private System.Windows.Forms.Label lbNamDataTyp;
        private MetroFramework.Controls.MetroComboBox cmbDataType;
        private System.Windows.Forms.ToolStrip toolStripOperations;
        private System.Windows.Forms.ToolStripButton btnDropDownMethdPannel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnShowOperationPanl;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnShrinkClass;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnShowDataMemPnl;
        private System.Windows.Forms.RichTextBox txtBoxMethods;
        private System.Windows.Forms.RichTextBox txtBoxAttributes;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lbModifiersClass;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAddParam;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnAddObj;
        private MetroFramework.Controls.MetroComboBox cmbOprtnTyp;
    }
}