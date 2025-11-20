namespace SignInSignUpApplication_WindowsForm_
{
    partial class AddPatDetails
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
            this.btnAdd = new Guna.UI2.WinForms.Guna2TileButton();
            this.txtBoxAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxGender = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxHeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxWeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 30;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(767, 617);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 63);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.AutoRoundedCorners = true;
            this.txtBoxAge.BorderRadius = 24;
            this.txtBoxAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxAge.DefaultText = "";
            this.txtBoxAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAge.Location = new System.Drawing.Point(702, 223);
            this.txtBoxAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.PlaceholderText = "Age";
            this.txtBoxAge.SelectedText = "";
            this.txtBoxAge.Size = new System.Drawing.Size(242, 50);
            this.txtBoxAge.TabIndex = 39;
            // 
            // txtBoxGender
            // 
            this.txtBoxGender.AutoRoundedCorners = true;
            this.txtBoxGender.BorderRadius = 24;
            this.txtBoxGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxGender.DefaultText = "";
            this.txtBoxGender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxGender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxGender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxGender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxGender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxGender.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxGender.Location = new System.Drawing.Point(702, 301);
            this.txtBoxGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxGender.Name = "txtBoxGender";
            this.txtBoxGender.PlaceholderText = "Gender";
            this.txtBoxGender.SelectedText = "";
            this.txtBoxGender.Size = new System.Drawing.Size(242, 50);
            this.txtBoxGender.TabIndex = 38;
            this.txtBoxGender.TextChanged += new System.EventHandler(this.txtBoxSpecialization_TextChanged);
            // 
            // txtBoxHeight
            // 
            this.txtBoxHeight.AutoRoundedCorners = true;
            this.txtBoxHeight.BorderRadius = 24;
            this.txtBoxHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxHeight.DefaultText = "";
            this.txtBoxHeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxHeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxHeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxHeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxHeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxHeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxHeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxHeight.Location = new System.Drawing.Point(702, 381);
            this.txtBoxHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxHeight.Name = "txtBoxHeight";
            this.txtBoxHeight.PlaceholderText = "Height";
            this.txtBoxHeight.SelectedText = "";
            this.txtBoxHeight.Size = new System.Drawing.Size(242, 50);
            this.txtBoxHeight.TabIndex = 37;
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.AutoRoundedCorners = true;
            this.txtBoxWeight.BorderRadius = 24;
            this.txtBoxWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxWeight.DefaultText = "";
            this.txtBoxWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxWeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxWeight.Location = new System.Drawing.Point(702, 464);
            this.txtBoxWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.PlaceholderText = "Weight";
            this.txtBoxWeight.SelectedText = "";
            this.txtBoxWeight.Size = new System.Drawing.Size(242, 50);
            this.txtBoxWeight.TabIndex = 36;
            // 
            // txtBoxName
            // 
            this.txtBoxName.AutoRoundedCorners = true;
            this.txtBoxName.BorderRadius = 24;
            this.txtBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxName.DefaultText = "";
            this.txtBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxName.Location = new System.Drawing.Point(702, 152);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.PlaceholderText = "Name";
            this.txtBoxName.SelectedText = "";
            this.txtBoxName.Size = new System.Drawing.Size(242, 50);
            this.txtBoxName.TabIndex = 34;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(1650, 132);
            this.guna2HtmlLabel1.TabIndex = 44;
            this.guna2HtmlLabel1.Text = "Add Patient Details";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddPatDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 900);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.txtBoxGender);
            this.Controls.Add(this.txtBoxHeight);
            this.Controls.Add(this.txtBoxWeight);
            this.Controls.Add(this.txtBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPatDetails";
            this.Text = "AddPatDetails";
            this.Load += new System.EventHandler(this.AddPatDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxAge;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxGender;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxHeight;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxWeight;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}