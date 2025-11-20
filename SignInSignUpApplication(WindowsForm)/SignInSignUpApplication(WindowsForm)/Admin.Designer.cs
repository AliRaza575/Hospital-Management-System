namespace SignInSignUpApplication_WindowsForm_
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.DocMenuExpand = new System.Windows.Forms.Timer(this.components);
            this.PatMenuExpand = new System.Windows.Forms.Timer(this.components);
            this.PatMenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPat = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnPatAdd = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnPatView = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnPatUpdate = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnPatDelete = new System.Windows.Forms.Button();
            this.DocMenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoc = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDocAdd = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnDocView = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnDocUpdate = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnDocDelete = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bill_Container = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.medicine_cont = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.Bill_Timer = new System.Windows.Forms.Timer(this.components);
            this.medicine_timer = new System.Windows.Forms.Timer(this.components);
            this.PatMenuContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.DocMenuContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.bill_Container.SuspendLayout();
            this.medicine_cont.SuspendLayout();
            this.SuspendLayout();
            // 
            // DocMenuExpand
            // 
            this.DocMenuExpand.Interval = 10;
            this.DocMenuExpand.Tick += new System.EventHandler(this.DocMenuExpand_Tick);
            // 
            // PatMenuExpand
            // 
            this.PatMenuExpand.Interval = 10;
            this.PatMenuExpand.Tick += new System.EventHandler(this.PatMenuExpand_Tick);
            // 
            // PatMenuContainer
            // 
            this.PatMenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(67)))), ((int)(((byte)(103)))));
            this.PatMenuContainer.Controls.Add(this.panel3);
            this.PatMenuContainer.Controls.Add(this.panel11);
            this.PatMenuContainer.Controls.Add(this.panel12);
            this.PatMenuContainer.Controls.Add(this.panel13);
            this.PatMenuContainer.Controls.Add(this.panel14);
            this.PatMenuContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PatMenuContainer.Location = new System.Drawing.Point(3, 3);
            this.PatMenuContainer.Name = "PatMenuContainer";
            this.PatMenuContainer.Size = new System.Drawing.Size(263, 73);
            this.PatMenuContainer.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPat);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 78);
            this.panel3.TabIndex = 13;
            // 
            // btnPat
            // 
            this.btnPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnPat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPat.ForeColor = System.Drawing.Color.White;
            this.btnPat.Image = ((System.Drawing.Image)(resources.GetObject("btnPat.Image")));
            this.btnPat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPat.Location = new System.Drawing.Point(-108, -39);
            this.btnPat.Name = "btnPat";
            this.btnPat.Size = new System.Drawing.Size(428, 136);
            this.btnPat.TabIndex = 5;
            this.btnPat.Text = "    Patient";
            this.btnPat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPat.UseVisualStyleBackColor = false;
            this.btnPat.Click += new System.EventHandler(this.btnPat_Click_1);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Gray;
            this.panel11.Controls.Add(this.btnPatAdd);
            this.panel11.Location = new System.Drawing.Point(263, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(263, 78);
            this.panel11.TabIndex = 14;
            // 
            // btnPatAdd
            // 
            this.btnPatAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(103)))));
            this.btnPatAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPatAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPatAdd.ForeColor = System.Drawing.Color.White;
            this.btnPatAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnPatAdd.Image")));
            this.btnPatAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatAdd.Location = new System.Drawing.Point(-93, -24);
            this.btnPatAdd.Name = "btnPatAdd";
            this.btnPatAdd.Size = new System.Drawing.Size(381, 106);
            this.btnPatAdd.TabIndex = 5;
            this.btnPatAdd.Text = "    Add";
            this.btnPatAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatAdd.UseVisualStyleBackColor = false;
            this.btnPatAdd.Click += new System.EventHandler(this.btnPatAdd_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Gray;
            this.panel12.Controls.Add(this.btnPatView);
            this.panel12.Location = new System.Drawing.Point(526, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(263, 78);
            this.panel12.TabIndex = 15;
            // 
            // btnPatView
            // 
            this.btnPatView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(103)))));
            this.btnPatView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPatView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPatView.ForeColor = System.Drawing.Color.White;
            this.btnPatView.Image = ((System.Drawing.Image)(resources.GetObject("btnPatView.Image")));
            this.btnPatView.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatView.Location = new System.Drawing.Point(-82, -24);
            this.btnPatView.Name = "btnPatView";
            this.btnPatView.Size = new System.Drawing.Size(370, 106);
            this.btnPatView.TabIndex = 5;
            this.btnPatView.Text = "    View";
            this.btnPatView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatView.UseVisualStyleBackColor = false;
            this.btnPatView.Click += new System.EventHandler(this.btnPatView_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Gray;
            this.panel13.Controls.Add(this.btnPatUpdate);
            this.panel13.Location = new System.Drawing.Point(789, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(263, 78);
            this.panel13.TabIndex = 16;
            // 
            // btnPatUpdate
            // 
            this.btnPatUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(103)))));
            this.btnPatUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPatUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPatUpdate.ForeColor = System.Drawing.Color.White;
            this.btnPatUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnPatUpdate.Image")));
            this.btnPatUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatUpdate.Location = new System.Drawing.Point(-111, -24);
            this.btnPatUpdate.Name = "btnPatUpdate";
            this.btnPatUpdate.Size = new System.Drawing.Size(450, 106);
            this.btnPatUpdate.TabIndex = 5;
            this.btnPatUpdate.Text = "    Update";
            this.btnPatUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatUpdate.UseVisualStyleBackColor = false;
            this.btnPatUpdate.Click += new System.EventHandler(this.btnPatUpdate_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Gray;
            this.panel14.Controls.Add(this.btnPatDelete);
            this.panel14.Location = new System.Drawing.Point(1052, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(263, 78);
            this.panel14.TabIndex = 17;
            // 
            // btnPatDelete
            // 
            this.btnPatDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(103)))));
            this.btnPatDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPatDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPatDelete.ForeColor = System.Drawing.Color.White;
            this.btnPatDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnPatDelete.Image")));
            this.btnPatDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatDelete.Location = new System.Drawing.Point(-68, -24);
            this.btnPatDelete.Name = "btnPatDelete";
            this.btnPatDelete.Size = new System.Drawing.Size(366, 106);
            this.btnPatDelete.TabIndex = 5;
            this.btnPatDelete.Text = "    Delete";
            this.btnPatDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatDelete.UseVisualStyleBackColor = false;
            this.btnPatDelete.Click += new System.EventHandler(this.btnPatDelete_Click);
            // 
            // DocMenuContainer
            // 
            this.DocMenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(67)))), ((int)(((byte)(103)))));
            this.DocMenuContainer.Controls.Add(this.panel1);
            this.DocMenuContainer.Controls.Add(this.panel4);
            this.DocMenuContainer.Controls.Add(this.panel8);
            this.DocMenuContainer.Controls.Add(this.panel9);
            this.DocMenuContainer.Controls.Add(this.panel10);
            this.DocMenuContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DocMenuContainer.Location = new System.Drawing.Point(3, 82);
            this.DocMenuContainer.Name = "DocMenuContainer";
            this.DocMenuContainer.Size = new System.Drawing.Size(263, 75);
            this.DocMenuContainer.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDoc);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 78);
            this.panel1.TabIndex = 13;
            // 
            // btnDoc
            // 
            this.btnDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoc.ForeColor = System.Drawing.Color.White;
            this.btnDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnDoc.Image")));
            this.btnDoc.Location = new System.Drawing.Point(-63, -46);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(533, 150);
            this.btnDoc.TabIndex = 5;
            this.btnDoc.Text = "    Doctor";
            this.btnDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoc.UseVisualStyleBackColor = false;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.btnDocAdd);
            this.panel4.Location = new System.Drawing.Point(263, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 78);
            this.panel4.TabIndex = 14;
            // 
            // btnDocAdd
            // 
            this.btnDocAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(103)))));
            this.btnDocAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDocAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDocAdd.ForeColor = System.Drawing.Color.White;
            this.btnDocAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnDocAdd.Image")));
            this.btnDocAdd.Location = new System.Drawing.Point(-27, -24);
            this.btnDocAdd.Name = "btnDocAdd";
            this.btnDocAdd.Size = new System.Drawing.Size(400, 106);
            this.btnDocAdd.TabIndex = 5;
            this.btnDocAdd.Text = "     Add";
            this.btnDocAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocAdd.UseVisualStyleBackColor = false;
            this.btnDocAdd.Click += new System.EventHandler(this.btnDocAdd_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Controls.Add(this.btnDocView);
            this.panel8.Location = new System.Drawing.Point(526, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(263, 78);
            this.panel8.TabIndex = 15;
            // 
            // btnDocView
            // 
            this.btnDocView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(103)))));
            this.btnDocView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDocView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDocView.ForeColor = System.Drawing.Color.White;
            this.btnDocView.Image = ((System.Drawing.Image)(resources.GetObject("btnDocView.Image")));
            this.btnDocView.Location = new System.Drawing.Point(-23, -24);
            this.btnDocView.Name = "btnDocView";
            this.btnDocView.Size = new System.Drawing.Size(396, 106);
            this.btnDocView.TabIndex = 5;
            this.btnDocView.Text = "    View";
            this.btnDocView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocView.UseVisualStyleBackColor = false;
            this.btnDocView.Click += new System.EventHandler(this.btnDocView_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Controls.Add(this.btnDocUpdate);
            this.panel9.Location = new System.Drawing.Point(789, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(263, 78);
            this.panel9.TabIndex = 16;
            // 
            // btnDocUpdate
            // 
            this.btnDocUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(103)))));
            this.btnDocUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDocUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDocUpdate.ForeColor = System.Drawing.Color.White;
            this.btnDocUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnDocUpdate.Image")));
            this.btnDocUpdate.Location = new System.Drawing.Point(-23, -24);
            this.btnDocUpdate.Name = "btnDocUpdate";
            this.btnDocUpdate.Size = new System.Drawing.Size(423, 106);
            this.btnDocUpdate.TabIndex = 5;
            this.btnDocUpdate.Text = "    Update";
            this.btnDocUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocUpdate.UseVisualStyleBackColor = false;
            this.btnDocUpdate.Click += new System.EventHandler(this.btnDocUpdate_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gray;
            this.panel10.Controls.Add(this.btnDocDelete);
            this.panel10.Location = new System.Drawing.Point(1052, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(263, 78);
            this.panel10.TabIndex = 17;
            // 
            // btnDocDelete
            // 
            this.btnDocDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(103)))));
            this.btnDocDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDocDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDocDelete.ForeColor = System.Drawing.Color.White;
            this.btnDocDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDocDelete.Image")));
            this.btnDocDelete.Location = new System.Drawing.Point(-28, -24);
            this.btnDocDelete.Name = "btnDocDelete";
            this.btnDocDelete.Size = new System.Drawing.Size(446, 106);
            this.btnDocDelete.TabIndex = 5;
            this.btnDocDelete.Text = "    Delete";
            this.btnDocDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocDelete.UseVisualStyleBackColor = false;
            this.btnDocDelete.Click += new System.EventHandler(this.btnDocDelete_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.flowLayoutPanel1.Controls.Add(this.PatMenuContainer);
            this.flowLayoutPanel1.Controls.Add(this.DocMenuContainer);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(269, 750);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // bill_Container
            // 
            this.bill_Container.Controls.Add(this.guna2Button1);
            this.bill_Container.Controls.Add(this.guna2Button2);
            this.bill_Container.Controls.Add(this.guna2Button3);
            this.bill_Container.Controls.Add(this.guna2Button4);
            this.bill_Container.Controls.Add(this.guna2Button5);
            this.bill_Container.Location = new System.Drawing.Point(327, 151);
            this.bill_Container.Name = "bill_Container";
            this.bill_Container.Size = new System.Drawing.Size(263, 73);
            this.bill_Container.TabIndex = 26;
            this.bill_Container.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::SignInSignUpApplication_WindowsForm_.Properties.Resources.pngegg__2_;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(25, -20);
            this.guna2Button1.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2Button1.Location = new System.Drawing.Point(0, 0);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(341, 110);
            this.guna2Button1.TabIndex = 27;
            this.guna2Button1.Text = "Bill";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextOffset = new System.Drawing.Point(40, -20);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::SignInSignUpApplication_WindowsForm_.Properties.Resources.pngegg;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(45, 0);
            this.guna2Button2.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2Button2.Location = new System.Drawing.Point(0, 110);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(341, 97);
            this.guna2Button2.TabIndex = 28;
            this.guna2Button2.Text = "Add";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.TextOffset = new System.Drawing.Point(60, 0);
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::SignInSignUpApplication_WindowsForm_.Properties.Resources.pngegg;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageOffset = new System.Drawing.Point(45, 0);
            this.guna2Button3.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2Button3.Location = new System.Drawing.Point(0, 207);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(341, 93);
            this.guna2Button3.TabIndex = 29;
            this.guna2Button3.Text = "View";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.TextOffset = new System.Drawing.Point(60, 0);
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = global::SignInSignUpApplication_WindowsForm_.Properties.Resources.pngegg;
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.ImageOffset = new System.Drawing.Point(45, 0);
            this.guna2Button4.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2Button4.Location = new System.Drawing.Point(0, 300);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(335, 97);
            this.guna2Button4.TabIndex = 30;
            this.guna2Button4.Text = "Delete";
            this.guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.TextOffset = new System.Drawing.Point(60, 0);
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = global::SignInSignUpApplication_WindowsForm_.Properties.Resources.pngegg;
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.ImageOffset = new System.Drawing.Point(45, 0);
            this.guna2Button5.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2Button5.Location = new System.Drawing.Point(0, 397);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(338, 94);
            this.guna2Button5.TabIndex = 27;
            this.guna2Button5.Text = "Generate";
            this.guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.TextOffset = new System.Drawing.Point(60, 0);
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // medicine_cont
            // 
            this.medicine_cont.Controls.Add(this.guna2Button9);
            this.medicine_cont.Controls.Add(this.guna2Button8);
            this.medicine_cont.Controls.Add(this.guna2Button7);
            this.medicine_cont.Controls.Add(this.guna2Button6);
            this.medicine_cont.Location = new System.Drawing.Point(327, 230);
            this.medicine_cont.Name = "medicine_cont";
            this.medicine_cont.Size = new System.Drawing.Size(263, 78);
            this.medicine_cont.TabIndex = 32;
            // 
            // guna2Button9
            // 
            this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button9.ForeColor = System.Drawing.Color.White;
            this.guna2Button9.Image = global::SignInSignUpApplication_WindowsForm_.Properties.Resources.pngegg__3_;
            this.guna2Button9.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button9.ImageOffset = new System.Drawing.Point(35, 0);
            this.guna2Button9.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button9.Location = new System.Drawing.Point(0, 0);
            this.guna2Button9.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.Size = new System.Drawing.Size(320, 78);
            this.guna2Button9.TabIndex = 31;
            this.guna2Button9.Text = "Medicine";
            this.guna2Button9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button9.TextOffset = new System.Drawing.Point(50, 0);
            this.guna2Button9.Click += new System.EventHandler(this.guna2Button9_Click);
            // 
            // guna2Button8
            // 
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button8.ForeColor = System.Drawing.Color.White;
            this.guna2Button8.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button8.Image")));
            this.guna2Button8.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button8.ImageOffset = new System.Drawing.Point(45, 0);
            this.guna2Button8.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2Button8.Location = new System.Drawing.Point(0, 78);
            this.guna2Button8.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(320, 89);
            this.guna2Button8.TabIndex = 30;
            this.guna2Button8.Text = "Add";
            this.guna2Button8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button8.TextOffset = new System.Drawing.Point(60, 0);
            this.guna2Button8.Click += new System.EventHandler(this.guna2Button8_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button7.Image")));
            this.guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.ImageOffset = new System.Drawing.Point(45, 0);
            this.guna2Button7.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2Button7.Location = new System.Drawing.Point(0, 167);
            this.guna2Button7.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(320, 88);
            this.guna2Button7.TabIndex = 29;
            this.guna2Button7.Text = "View";
            this.guna2Button7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.TextOffset = new System.Drawing.Point(60, 0);
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button6.Image")));
            this.guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button6.ImageOffset = new System.Drawing.Point(45, 0);
            this.guna2Button6.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2Button6.Location = new System.Drawing.Point(0, 255);
            this.guna2Button6.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(320, 86);
            this.guna2Button6.TabIndex = 28;
            this.guna2Button6.Text = "Delete";
            this.guna2Button6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button6.TextOffset = new System.Drawing.Point(60, 0);
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // Bill_Timer
            // 
            this.Bill_Timer.Tick += new System.EventHandler(this.Bill_Timer_Tick);
            // 
            // medicine_timer
            // 
            this.medicine_timer.Tick += new System.EventHandler(this.medicine_timer_Tick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 750);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bill_Container);
            this.Controls.Add(this.medicine_cont);
            this.Name = "Admin";
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.PatMenuContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.DocMenuContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.bill_Container.ResumeLayout(false);
            this.medicine_cont.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer DocMenuExpand;
        private System.Windows.Forms.Timer PatMenuExpand;
        private System.Windows.Forms.FlowLayoutPanel PatMenuContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPat;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnPatAdd;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnPatView;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnPatUpdate;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnPatDelete;
        private System.Windows.Forms.FlowLayoutPanel DocMenuContainer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnDocAdd;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnDocView;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnDocUpdate;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnDocDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel bill_Container;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.Timer Bill_Timer;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private System.Windows.Forms.FlowLayoutPanel medicine_cont;
        private System.Windows.Forms.Timer medicine_timer;
    }
}