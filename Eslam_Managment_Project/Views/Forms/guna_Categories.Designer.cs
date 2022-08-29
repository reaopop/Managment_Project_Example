
namespace Eslam_Managment_Project.Views.Forms
{
    partial class guna_Categories
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CategoryName = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Close = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.pictureEdit1);
            this.guna2GradientPanel1.Controls.Add(this.gunaLabel2);
            this.guna2GradientPanel1.Controls.Add(this.txt_CategoryName);
            this.guna2GradientPanel1.Controls.Add(this.btn_Close);
            this.guna2GradientPanel1.Controls.Add(this.btn_Save);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(173)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(404, 199);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(24, 19);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(138, 21);
            this.gunaLabel2.TabIndex = 9;
            this.gunaLabel2.Text = "Category Name :";
            // 
            // txt_CategoryName
            // 
            this.txt_CategoryName.BackColor = System.Drawing.Color.Transparent;
            this.txt_CategoryName.BaseColor = System.Drawing.Color.White;
            this.txt_CategoryName.BorderColor = System.Drawing.Color.Silver;
            this.txt_CategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CategoryName.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_CategoryName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CategoryName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_CategoryName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CategoryName.Location = new System.Drawing.Point(13, 50);
            this.txt_CategoryName.Name = "txt_CategoryName";
            this.txt_CategoryName.PasswordChar = '\0';
            this.txt_CategoryName.Radius = 10;
            this.txt_CategoryName.SelectedText = "";
            this.txt_CategoryName.Size = new System.Drawing.Size(262, 45);
            this.txt_CategoryName.TabIndex = 6;
            // 
            // btn_Close
            // 
            this.btn_Close.BorderRadius = 15;
            this.btn_Close.CheckedState.Parent = this.btn_Close;
            this.btn_Close.CustomImages.Parent = this.btn_Close;
            this.btn_Close.FillColor = System.Drawing.Color.Crimson;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.HoverState.Parent = this.btn_Close;
            this.btn_Close.Location = new System.Drawing.Point(218, 139);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.ShadowDecoration.Parent = this.btn_Close;
            this.btn_Close.Size = new System.Drawing.Size(157, 45);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Close";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BorderRadius = 15;
            this.btn_Save.CheckedState.Parent = this.btn_Save;
            this.btn_Save.CustomImages.Parent = this.btn_Save;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.HoverState.Parent = this.btn_Save;
            this.btn_Save.Location = new System.Drawing.Point(25, 139);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.ShadowDecoration.Parent = this.btn_Save;
            this.btn_Save.Size = new System.Drawing.Size(157, 45);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(292, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 10;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.pictureEdit1;
            // 
            // guna_Categories
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 199);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "guna_Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "guna_AddBalance";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_Close;
        private Guna.UI2.WinForms.Guna2Button btn_Save;
        private Guna.UI.WinForms.GunaTextBox txt_CategoryName;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}