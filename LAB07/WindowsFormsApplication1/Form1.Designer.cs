namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblModel = new System.Windows.Forms.Label();
            this.lblAral = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZagvar = new System.Windows.Forms.TextBox();
            this.txtAralDugaar = new System.Windows.Forms.TextBox();
            this.txtUngu = new System.Windows.Forms.TextBox();
            this.maskOn = new System.Windows.Forms.MaskedTextBox();
            this.maskUlsDugaar = new System.Windows.Forms.MaskedTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbAngilal = new System.Windows.Forms.ComboBox();
            this.gvCar = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.тайланToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.машиныБүртгэлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvCar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(63, 46);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 13);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Модел: ";
            // 
            // lblAral
            // 
            this.lblAral.AutoSize = true;
            this.lblAral.Location = new System.Drawing.Point(63, 70);
            this.lblAral.Name = "lblAral";
            this.lblAral.Size = new System.Drawing.Size(83, 13);
            this.lblAral.TabIndex = 1;
            this.lblAral.Text = "Арлын дугаар: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Өнгө: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Үйлдвэрлэсэн он: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ангилал: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Улсын дугаар: ";
            // 
            // txtZagvar
            // 
            this.txtZagvar.Location = new System.Drawing.Point(165, 46);
            this.txtZagvar.Name = "txtZagvar";
            this.txtZagvar.Size = new System.Drawing.Size(150, 20);
            this.txtZagvar.TabIndex = 6;
            // 
            // txtAralDugaar
            // 
            this.txtAralDugaar.Location = new System.Drawing.Point(165, 70);
            this.txtAralDugaar.Name = "txtAralDugaar";
            this.txtAralDugaar.Size = new System.Drawing.Size(150, 20);
            this.txtAralDugaar.TabIndex = 7;
            // 
            // txtUngu
            // 
            this.txtUngu.Location = new System.Drawing.Point(165, 96);
            this.txtUngu.Name = "txtUngu";
            this.txtUngu.Size = new System.Drawing.Size(150, 20);
            this.txtUngu.TabIndex = 8;
            // 
            // maskOn
            // 
            this.maskOn.Location = new System.Drawing.Point(165, 123);
            this.maskOn.Mask = "0000";
            this.maskOn.Name = "maskOn";
            this.maskOn.Size = new System.Drawing.Size(150, 20);
            this.maskOn.TabIndex = 12;
            // 
            // maskUlsDugaar
            // 
            this.maskUlsDugaar.Location = new System.Drawing.Point(165, 176);
            this.maskUlsDugaar.Mask = "0000-LLL";
            this.maskUlsDugaar.Name = "maskUlsDugaar";
            this.maskUlsDugaar.Size = new System.Drawing.Size(150, 20);
            this.maskUlsDugaar.TabIndex = 14;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(66, 215);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(89, 38);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Бүртгэх";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbAngilal
            // 
            this.cmbAngilal.FormattingEnabled = true;
            this.cmbAngilal.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "M"});
            this.cmbAngilal.Location = new System.Drawing.Point(165, 150);
            this.cmbAngilal.Name = "cmbAngilal";
            this.cmbAngilal.Size = new System.Drawing.Size(150, 21);
            this.cmbAngilal.TabIndex = 17;
            // 
            // gvCar
            // 
            this.gvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCar.Location = new System.Drawing.Point(341, 46);
            this.gvCar.Name = "gvCar";
            this.gvCar.Size = new System.Drawing.Size(542, 207);
            this.gvCar.TabIndex = 19;
            this.gvCar.SelectionChanged += new System.EventHandler(this.gvCar_SelectionChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(165, 215);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 38);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Засварлах";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(249, 215);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 38);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Устгах";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(66, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 36);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Шинэ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тайланToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // тайланToolStripMenuItem
            // 
            this.тайланToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.машиныБүртгэлToolStripMenuItem});
            this.тайланToolStripMenuItem.Name = "тайланToolStripMenuItem";
            this.тайланToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.тайланToolStripMenuItem.Text = "Тайлан";
            // 
            // машиныБүртгэлToolStripMenuItem
            // 
            this.машиныБүртгэлToolStripMenuItem.Name = "машиныБүртгэлToolStripMenuItem";
            this.машиныБүртгэлToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.машиныБүртгэлToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.машиныБүртгэлToolStripMenuItem.Text = "Машины бүртгэл";
            this.машиныБүртгэлToolStripMenuItem.Click += new System.EventHandler(this.машиныБүртгэлToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 445);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gvCar);
            this.Controls.Add(this.cmbAngilal);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.maskUlsDugaar);
            this.Controls.Add(this.maskOn);
            this.Controls.Add(this.txtUngu);
            this.Controls.Add(this.txtAralDugaar);
            this.Controls.Add(this.txtZagvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAral);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Машины бүртгэл";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblAral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZagvar;
        private System.Windows.Forms.TextBox txtAralDugaar;
        private System.Windows.Forms.TextBox txtUngu;
        private System.Windows.Forms.MaskedTextBox maskOn;
        private System.Windows.Forms.MaskedTextBox maskUlsDugaar;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbAngilal;
        private System.Windows.Forms.DataGridView gvCar;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem тайланToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem машиныБүртгэлToolStripMenuItem;
    }
}

