
namespace Eslam_Managment_Project.Views.Forms
{
    partial class guna_AddBalance
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tog_IsCredit = new DevExpress.XtraEditors.ToggleSwitch();
            this.txt_notes = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Close = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.sp_Balance = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tog_IsCredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Balance)).BeginInit();
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
            this.guna2GradientPanel1.Controls.Add(this.gunaLabel2);
            this.guna2GradientPanel1.Controls.Add(this.gunaLabel1);
            this.guna2GradientPanel1.Controls.Add(this.tog_IsCredit);
            this.guna2GradientPanel1.Controls.Add(this.txt_notes);
            this.guna2GradientPanel1.Controls.Add(this.btn_Close);
            this.guna2GradientPanel1.Controls.Add(this.btn_Save);
            this.guna2GradientPanel1.Controls.Add(this.sp_Balance);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(173)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(404, 259);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(24, 99);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(44, 17);
            this.gunaLabel2.TabIndex = 9;
            this.gunaLabel2.Text = "Notes";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(24, 21);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(117, 17);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "Balance Amount :";
            // 
            // tog_IsCredit
            // 
            this.tog_IsCredit.Location = new System.Drawing.Point(246, 54);
            this.tog_IsCredit.Name = "tog_IsCredit";
            this.tog_IsCredit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tog_IsCredit.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.tog_IsCredit.Properties.Appearance.Options.UseFont = true;
            this.tog_IsCredit.Properties.Appearance.Options.UseForeColor = true;
            this.tog_IsCredit.Properties.OffText = "Revnue";
            this.tog_IsCredit.Properties.OnText = "Expenses";
            this.tog_IsCredit.Size = new System.Drawing.Size(146, 20);
            this.tog_IsCredit.TabIndex = 7;
            // 
            // txt_notes
            // 
            this.txt_notes.BackColor = System.Drawing.Color.Transparent;
            this.txt_notes.BaseColor = System.Drawing.Color.White;
            this.txt_notes.BorderColor = System.Drawing.Color.Silver;
            this.txt_notes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_notes.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_notes.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_notes.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_notes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_notes.Location = new System.Drawing.Point(13, 119);
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.PasswordChar = '\0';
            this.txt_notes.Radius = 10;
            this.txt_notes.SelectedText = "";
            this.txt_notes.Size = new System.Drawing.Size(379, 68);
            this.txt_notes.TabIndex = 6;
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
            this.btn_Close.Location = new System.Drawing.Point(220, 202);
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
            this.btn_Save.Location = new System.Drawing.Point(27, 202);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.ShadowDecoration.Parent = this.btn_Save;
            this.btn_Save.Size = new System.Drawing.Size(157, 45);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // sp_Balance
            // 
            this.sp_Balance.BackColor = System.Drawing.Color.Transparent;
            this.sp_Balance.BorderRadius = 12;
            this.sp_Balance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sp_Balance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sp_Balance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sp_Balance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sp_Balance.DisabledState.Parent = this.sp_Balance;
            this.sp_Balance.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.sp_Balance.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.sp_Balance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sp_Balance.FocusedState.Parent = this.sp_Balance;
            this.sp_Balance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp_Balance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sp_Balance.Location = new System.Drawing.Point(13, 43);
            this.sp_Balance.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.sp_Balance.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.sp_Balance.Name = "sp_Balance";
            this.sp_Balance.ShadowDecoration.Parent = this.sp_Balance;
            this.sp_Balance.Size = new System.Drawing.Size(224, 43);
            this.sp_Balance.TabIndex = 3;
            // 
            // guna_AddBalance
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 259);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "guna_AddBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "guna_AddBalance";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tog_IsCredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Balance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_Close;
        private Guna.UI2.WinForms.Guna2Button btn_Save;
        private Guna.UI2.WinForms.Guna2NumericUpDown sp_Balance;
        private Guna.UI.WinForms.GunaTextBox txt_notes;
        private DevExpress.XtraEditors.ToggleSwitch tog_IsCredit;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}