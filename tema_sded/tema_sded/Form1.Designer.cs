namespace tema_sded
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automatNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereAutomatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.new_btn = new System.Windows.Forms.Button();
            this.trim_btn = new System.Windows.Forms.Button();
            this.coacc_btn = new System.Windows.Forms.Button();
            this.acc_btn = new System.Windows.Forms.Button();
            this.mod_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automatNouToolStripMenuItem,
            this.stergereAutomatToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // automatNouToolStripMenuItem
            // 
            this.automatNouToolStripMenuItem.Name = "automatNouToolStripMenuItem";
            this.automatNouToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.automatNouToolStripMenuItem.Text = "Automat nou";
            // 
            // stergereAutomatToolStripMenuItem
            // 
            this.stergereAutomatToolStripMenuItem.Name = "stergereAutomatToolStripMenuItem";
            this.stergereAutomatToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.stergereAutomatToolStripMenuItem.Text = "Stergere automat";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.new_btn);
            this.groupBox1.Controls.Add(this.trim_btn);
            this.groupBox1.Controls.Add(this.coacc_btn);
            this.groupBox1.Controls.Add(this.acc_btn);
            this.groupBox1.Controls.Add(this.mod_btn);
            this.groupBox1.Controls.Add(this.remove_btn);
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Location = new System.Drawing.Point(533, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 522);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modelare automat";
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(35, 37);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(103, 23);
            this.new_btn.TabIndex = 6;
            this.new_btn.Text = "Automat nou";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // trim_btn
            // 
            this.trim_btn.Location = new System.Drawing.Point(35, 350);
            this.trim_btn.Name = "trim_btn";
            this.trim_btn.Size = new System.Drawing.Size(103, 23);
            this.trim_btn.TabIndex = 5;
            this.trim_btn.Text = "Aplica alg Trim";
            this.trim_btn.UseVisualStyleBackColor = true;
            // 
            // coacc_btn
            // 
            this.coacc_btn.Location = new System.Drawing.Point(35, 304);
            this.coacc_btn.Name = "coacc_btn";
            this.coacc_btn.Size = new System.Drawing.Size(103, 23);
            this.coacc_btn.TabIndex = 4;
            this.coacc_btn.Text = "Aplica alg Co-Acc";
            this.coacc_btn.UseVisualStyleBackColor = true;
            // 
            // acc_btn
            // 
            this.acc_btn.Location = new System.Drawing.Point(35, 257);
            this.acc_btn.Name = "acc_btn";
            this.acc_btn.Size = new System.Drawing.Size(103, 23);
            this.acc_btn.TabIndex = 3;
            this.acc_btn.Text = "Aplica alg Acc";
            this.acc_btn.UseVisualStyleBackColor = true;
            // 
            // mod_btn
            // 
            this.mod_btn.Location = new System.Drawing.Point(35, 211);
            this.mod_btn.Name = "mod_btn";
            this.mod_btn.Size = new System.Drawing.Size(103, 23);
            this.mod_btn.TabIndex = 2;
            this.mod_btn.Text = "Modifica stare";
            this.mod_btn.UseVisualStyleBackColor = true;
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(35, 166);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(103, 23);
            this.remove_btn.TabIndex = 1;
            this.remove_btn.Text = "Elimina stare";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(35, 123);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(103, 23);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "Adauga stare";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 522);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SDED";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automatNouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereAutomatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button trim_btn;
        private System.Windows.Forms.Button coacc_btn;
        private System.Windows.Forms.Button acc_btn;
        private System.Windows.Forms.Button mod_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button new_btn;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

