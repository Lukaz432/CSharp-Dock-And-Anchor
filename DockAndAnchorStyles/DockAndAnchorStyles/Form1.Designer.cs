namespace DockAndAnchorStyles
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DockTopBtn = new System.Windows.Forms.Button();
            this.DockBottomBtn = new System.Windows.Forms.Button();
            this.DockRightBtn = new System.Windows.Forms.Button();
            this.DockLeftBtn = new System.Windows.Forms.Button();
            this.AnchorTopRightBtn = new System.Windows.Forms.Button();
            this.AnchorTopLeftBtn = new System.Windows.Forms.Button();
            this.AnchorBottomRightBtn = new System.Windows.Forms.Button();
            this.AnchorBottomLeftBtn = new System.Windows.Forms.Button();
            this.DockFillBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 209);
            this.textBox1.TabIndex = 0;
            // 
            // DockTopBtn
            // 
            this.DockTopBtn.Location = new System.Drawing.Point(147, 317);
            this.DockTopBtn.Name = "DockTopBtn";
            this.DockTopBtn.Size = new System.Drawing.Size(103, 23);
            this.DockTopBtn.TabIndex = 1;
            this.DockTopBtn.Text = "Dock Top";
            this.DockTopBtn.UseVisualStyleBackColor = true;
            this.DockTopBtn.Click += new System.EventHandler(this.DockTopBtn_Click);
            // 
            // DockBottomBtn
            // 
            this.DockBottomBtn.Location = new System.Drawing.Point(256, 317);
            this.DockBottomBtn.Name = "DockBottomBtn";
            this.DockBottomBtn.Size = new System.Drawing.Size(103, 23);
            this.DockBottomBtn.TabIndex = 2;
            this.DockBottomBtn.Text = "Dock Bottom";
            this.DockBottomBtn.UseVisualStyleBackColor = true;
            this.DockBottomBtn.Click += new System.EventHandler(this.DockBottomBtn_Click);
            // 
            // DockRightBtn
            // 
            this.DockRightBtn.Location = new System.Drawing.Point(365, 317);
            this.DockRightBtn.Name = "DockRightBtn";
            this.DockRightBtn.Size = new System.Drawing.Size(103, 23);
            this.DockRightBtn.TabIndex = 3;
            this.DockRightBtn.Text = "Dock Right";
            this.DockRightBtn.UseVisualStyleBackColor = true;
            this.DockRightBtn.Click += new System.EventHandler(this.DockRightBtn_Click);
            // 
            // DockLeftBtn
            // 
            this.DockLeftBtn.Location = new System.Drawing.Point(474, 317);
            this.DockLeftBtn.Name = "DockLeftBtn";
            this.DockLeftBtn.Size = new System.Drawing.Size(103, 23);
            this.DockLeftBtn.TabIndex = 4;
            this.DockLeftBtn.Text = "Dock Left";
            this.DockLeftBtn.UseVisualStyleBackColor = true;
            this.DockLeftBtn.Click += new System.EventHandler(this.DockLeftBtn_Click);
            // 
            // AnchorTopRightBtn
            // 
            this.AnchorTopRightBtn.Location = new System.Drawing.Point(166, 383);
            this.AnchorTopRightBtn.Name = "AnchorTopRightBtn";
            this.AnchorTopRightBtn.Size = new System.Drawing.Size(119, 23);
            this.AnchorTopRightBtn.TabIndex = 5;
            this.AnchorTopRightBtn.Text = "Anchor Top Right";
            this.AnchorTopRightBtn.UseVisualStyleBackColor = true;
            this.AnchorTopRightBtn.Click += new System.EventHandler(this.AnchorTopRightBtn_Click);
            // 
            // AnchorTopLeftBtn
            // 
            this.AnchorTopLeftBtn.Location = new System.Drawing.Point(291, 383);
            this.AnchorTopLeftBtn.Name = "AnchorTopLeftBtn";
            this.AnchorTopLeftBtn.Size = new System.Drawing.Size(119, 23);
            this.AnchorTopLeftBtn.TabIndex = 6;
            this.AnchorTopLeftBtn.Text = "Anchor Top Left";
            this.AnchorTopLeftBtn.UseVisualStyleBackColor = true;
            this.AnchorTopLeftBtn.Click += new System.EventHandler(this.AnchorTopLeftBtn_Click);
            // 
            // AnchorBottomRightBtn
            // 
            this.AnchorBottomRightBtn.Location = new System.Drawing.Point(416, 383);
            this.AnchorBottomRightBtn.Name = "AnchorBottomRightBtn";
            this.AnchorBottomRightBtn.Size = new System.Drawing.Size(119, 23);
            this.AnchorBottomRightBtn.TabIndex = 7;
            this.AnchorBottomRightBtn.Text = "Anchor Bottom Right";
            this.AnchorBottomRightBtn.UseVisualStyleBackColor = true;
            this.AnchorBottomRightBtn.Click += new System.EventHandler(this.AnchorBottomRightBtn_Click);
            // 
            // AnchorBottomLeftBtn
            // 
            this.AnchorBottomLeftBtn.Location = new System.Drawing.Point(541, 383);
            this.AnchorBottomLeftBtn.Name = "AnchorBottomLeftBtn";
            this.AnchorBottomLeftBtn.Size = new System.Drawing.Size(119, 23);
            this.AnchorBottomLeftBtn.TabIndex = 8;
            this.AnchorBottomLeftBtn.Text = "Anchor Bottom Left";
            this.AnchorBottomLeftBtn.UseVisualStyleBackColor = true;
            this.AnchorBottomLeftBtn.Click += new System.EventHandler(this.AnchorBottomLeftBtn_Click);
            // 
            // DockFillBtn
            // 
            this.DockFillBtn.Location = new System.Drawing.Point(583, 317);
            this.DockFillBtn.Name = "DockFillBtn";
            this.DockFillBtn.Size = new System.Drawing.Size(89, 23);
            this.DockFillBtn.TabIndex = 9;
            this.DockFillBtn.Text = "Dock Fill";
            this.DockFillBtn.UseVisualStyleBackColor = true;
            this.DockFillBtn.Click += new System.EventHandler(this.DockFillBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DockFillBtn);
            this.Controls.Add(this.AnchorBottomLeftBtn);
            this.Controls.Add(this.AnchorBottomRightBtn);
            this.Controls.Add(this.AnchorTopLeftBtn);
            this.Controls.Add(this.AnchorTopRightBtn);
            this.Controls.Add(this.DockLeftBtn);
            this.Controls.Add(this.DockRightBtn);
            this.Controls.Add(this.DockBottomBtn);
            this.Controls.Add(this.DockTopBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DockTopBtn;
        private System.Windows.Forms.Button DockBottomBtn;
        private System.Windows.Forms.Button DockRightBtn;
        private System.Windows.Forms.Button DockLeftBtn;
        private System.Windows.Forms.Button AnchorTopRightBtn;
        private System.Windows.Forms.Button AnchorTopLeftBtn;
        private System.Windows.Forms.Button AnchorBottomRightBtn;
        private System.Windows.Forms.Button AnchorBottomLeftBtn;
        private System.Windows.Forms.Button DockFillBtn;
    }
}

