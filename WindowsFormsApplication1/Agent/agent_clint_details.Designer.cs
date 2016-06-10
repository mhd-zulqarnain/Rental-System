namespace WindowsFormsApplication1.Agent
{
    partial class agent_clint_details
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agent_clint_details));
            this.label2 = new System.Windows.Forms.Label();
            this.pHome = new System.Windows.Forms.PictureBox();
            this.pAvailable = new System.Windows.Forms.PictureBox();
            this.pAgent = new System.Windows.Forms.PictureBox();
            this.pAddHouse = new System.Windows.Forms.PictureBox();
            this.pReser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.btnchkDetail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboclint = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pClint = new System.Windows.Forms.PictureBox();
            this.pRent = new System.Windows.Forms.PictureBox();
            this.pExit = new System.Windows.Forms.PictureBox();
            this.pReturn = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.luname = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAddHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pClint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReturn)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "LOGOUT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pHome
            // 
            this.pHome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pHome.Image = ((System.Drawing.Image)(resources.GetObject("pHome.Image")));
            this.pHome.Location = new System.Drawing.Point(78, 31);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(69, 60);
            this.pHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pHome.TabIndex = 0;
            this.pHome.TabStop = false;
            this.toolTip1.SetToolTip(this.pHome, "Home");
            this.pHome.Click += new System.EventHandler(this.pHome_Click);
            // 
            // pAvailable
            // 
            this.pAvailable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pAvailable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAvailable.Image = ((System.Drawing.Image)(resources.GetObject("pAvailable.Image")));
            this.pAvailable.Location = new System.Drawing.Point(153, 31);
            this.pAvailable.Name = "pAvailable";
            this.pAvailable.Size = new System.Drawing.Size(69, 60);
            this.pAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAvailable.TabIndex = 1;
            this.pAvailable.TabStop = false;
            this.toolTip1.SetToolTip(this.pAvailable, "Avaliable\r\n  Houses");
            this.pAvailable.Click += new System.EventHandler(this.pAvailable_Click);
            // 
            // pAgent
            // 
            this.pAgent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pAgent.Cursor = System.Windows.Forms.Cursors.No;
            this.pAgent.Image = ((System.Drawing.Image)(resources.GetObject("pAgent.Image")));
            this.pAgent.Location = new System.Drawing.Point(228, 31);
            this.pAgent.Name = "pAgent";
            this.pAgent.Size = new System.Drawing.Size(69, 62);
            this.pAgent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAgent.TabIndex = 2;
            this.pAgent.TabStop = false;
            this.toolTip1.SetToolTip(this.pAgent, "Disable Only admin");
            // 
            // pAddHouse
            // 
            this.pAddHouse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pAddHouse.Cursor = System.Windows.Forms.Cursors.No;
            this.pAddHouse.Image = ((System.Drawing.Image)(resources.GetObject("pAddHouse.Image")));
            this.pAddHouse.Location = new System.Drawing.Point(303, 31);
            this.pAddHouse.Name = "pAddHouse";
            this.pAddHouse.Size = new System.Drawing.Size(69, 62);
            this.pAddHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAddHouse.TabIndex = 3;
            this.pAddHouse.TabStop = false;
            this.toolTip1.SetToolTip(this.pAddHouse, "Disable Only admin");
            // 
            // pReser
            // 
            this.pReser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pReser.Cursor = System.Windows.Forms.Cursors.No;
            this.pReser.Image = ((System.Drawing.Image)(resources.GetObject("pReser.Image")));
            this.pReser.Location = new System.Drawing.Point(378, 31);
            this.pReser.Name = "pReser";
            this.pReser.Size = new System.Drawing.Size(69, 62);
            this.pReser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pReser.TabIndex = 4;
            this.pReser.TabStop = false;
            this.toolTip1.SetToolTip(this.pReser, "Disable Only admin");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.l1);
            this.panel1.Controls.Add(this.btnchkDetail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboclint);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(31, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 302);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(29, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(719, 162);
            this.listView1.TabIndex = 57;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "House Number";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ADDRESS";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 452;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 120;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(558, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 32);
            this.button1.TabIndex = 56;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.Color.Snow;
            this.l1.Location = new System.Drawing.Point(45, 63);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(174, 32);
            this.l1.TabIndex = 54;
            this.l1.Text = "Clints Details";
            // 
            // btnchkDetail
            // 
            this.btnchkDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchkDetail.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnchkDetail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnchkDetail.Location = new System.Drawing.Point(576, 62);
            this.btnchkDetail.Name = "btnchkDetail";
            this.btnchkDetail.Size = new System.Drawing.Size(154, 33);
            this.btnchkDetail.TabIndex = 46;
            this.btnchkDetail.Text = "Check Details";
            this.btnchkDetail.UseVisualStyleBackColor = true;
            this.btnchkDetail.Click += new System.EventHandler(this.btnchkDetail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(333, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Clint Name";
            // 
            // comboclint
            // 
            this.comboclint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboclint.Font = new System.Drawing.Font("Verdana", 12F);
            this.comboclint.FormattingEnabled = true;
            this.comboclint.Location = new System.Drawing.Point(438, 64);
            this.comboclint.Name = "comboclint";
            this.comboclint.Size = new System.Drawing.Size(121, 26);
            this.comboclint.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Hebrew", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(133, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(510, 42);
            this.label3.TabIndex = 55;
            this.label3.Text = "Select Clint Name to Know Details";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 10;
            this.toolTip1.AutoPopDelay = 0;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 2;
            // 
            // pClint
            // 
            this.pClint.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pClint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pClint.Image = ((System.Drawing.Image)(resources.GetObject("pClint.Image")));
            this.pClint.Location = new System.Drawing.Point(453, 31);
            this.pClint.Name = "pClint";
            this.pClint.Size = new System.Drawing.Size(69, 60);
            this.pClint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pClint.TabIndex = 5;
            this.pClint.TabStop = false;
            this.toolTip1.SetToolTip(this.pClint, "Clints\r\nDetails");
            this.pClint.Click += new System.EventHandler(this.pClint_Click);
            // 
            // pRent
            // 
            this.pRent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pRent.Image = ((System.Drawing.Image)(resources.GetObject("pRent.Image")));
            this.pRent.Location = new System.Drawing.Point(528, 31);
            this.pRent.Name = "pRent";
            this.pRent.Size = new System.Drawing.Size(69, 60);
            this.pRent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pRent.TabIndex = 6;
            this.pRent.TabStop = false;
            this.toolTip1.SetToolTip(this.pRent, "Rent the house");
            this.pRent.Click += new System.EventHandler(this.pRent_Click);
            // 
            // pExit
            // 
            this.pExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pExit.Image = ((System.Drawing.Image)(resources.GetObject("pExit.Image")));
            this.pExit.Location = new System.Drawing.Point(678, 31);
            this.pExit.Name = "pExit";
            this.pExit.Size = new System.Drawing.Size(69, 62);
            this.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pExit.TabIndex = 8;
            this.pExit.TabStop = false;
            this.toolTip1.SetToolTip(this.pExit, "Exit");
            this.pExit.Click += new System.EventHandler(this.pExit_Click);
            // 
            // pReturn
            // 
            this.pReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pReturn.Image = ((System.Drawing.Image)(resources.GetObject("pReturn.Image")));
            this.pReturn.Location = new System.Drawing.Point(603, 31);
            this.pReturn.Name = "pReturn";
            this.pReturn.Size = new System.Drawing.Size(69, 60);
            this.pReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pReturn.TabIndex = 7;
            this.pReturn.TabStop = false;
            this.toolTip1.SetToolTip(this.pReturn, "RETURN");
            this.pReturn.Click += new System.EventHandler(this.pReturn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 11;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pHome, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.pAvailable, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.pAgent, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.pAddHouse, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.pReser, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.pClint, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this.pRent, 7, 1);
            this.tableLayoutPanel3.Controls.Add(this.pReturn, 8, 1);
            this.tableLayoutPanel3.Controls.Add(this.pExit, 9, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 62);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.85075F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.14925F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(836, 96);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(3, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(45, 41);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.luname, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(147, 47);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // luname
            // 
            this.luname.AutoSize = true;
            this.luname.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luname.ForeColor = System.Drawing.Color.Coral;
            this.luname.Location = new System.Drawing.Point(54, 0);
            this.luname.Name = "luname";
            this.luname.Size = new System.Drawing.Size(88, 46);
            this.luname.TabIndex = 0;
            this.luname.Text = "\r\nUsername";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.06897F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.93103F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(842, 161);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // agent_clint_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(844, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "agent_clint_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clint Details";
            this.Load += new System.EventHandler(this.agent_clint_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAddHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pClint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReturn)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pHome;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pAvailable;
        private System.Windows.Forms.PictureBox pAgent;
        private System.Windows.Forms.PictureBox pAddHouse;
        private System.Windows.Forms.PictureBox pReser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pClint;
        private System.Windows.Forms.PictureBox pRent;
        private System.Windows.Forms.PictureBox pExit;
        private System.Windows.Forms.PictureBox pReturn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label luname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnchkDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboclint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
    }
}