
namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closebtn = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userimg = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.passimg = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.Warnlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userimg)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passimg)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closebtn.ForeColor = System.Drawing.Color.Black;
            this.closebtn.Location = new System.Drawing.Point(688, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(59, 48);
            this.closebtn.TabIndex = 3;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.DarkSlateGray;
            this.min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min.FlatAppearance.BorderSize = 0;
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.min.ForeColor = System.Drawing.Color.Black;
            this.min.Location = new System.Drawing.Point(623, 0);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(59, 48);
            this.min.TabIndex = 4;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.userimg);
            this.panel1.Location = new System.Drawing.Point(45, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 47);
            this.panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(42, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Username/Email";
            this.textBox1.Size = new System.Drawing.Size(241, 30);
            this.textBox1.TabIndex = 1;
            // 
            // userimg
            // 
            this.userimg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userimg.BackgroundImage")));
            this.userimg.Location = new System.Drawing.Point(8, 9);
            this.userimg.Name = "userimg";
            this.userimg.Size = new System.Drawing.Size(28, 28);
            this.userimg.TabIndex = 0;
            this.userimg.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.passimg);
            this.panel2.Location = new System.Drawing.Point(45, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 47);
            this.panel2.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(42, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Password";
            this.textBox2.Size = new System.Drawing.Size(241, 30);
            this.textBox2.TabIndex = 8;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // passimg
            // 
            this.passimg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passimg.BackgroundImage")));
            this.passimg.Location = new System.Drawing.Point(8, 9);
            this.passimg.Name = "passimg";
            this.passimg.Size = new System.Drawing.Size(28, 28);
            this.passimg.TabIndex = 7;
            this.passimg.TabStop = false;
            this.passimg.Click += new System.EventHandler(this.passimg_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogin.Location = new System.Drawing.Point(138, 264);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 34);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            // 
            // Warnlabel
            // 
            this.Warnlabel.AutoSize = true;
            this.Warnlabel.BackColor = System.Drawing.Color.Transparent;
            this.Warnlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Warnlabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Warnlabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Warnlabel.Location = new System.Drawing.Point(53, 316);
            this.Warnlabel.Name = "Warnlabel";
            this.Warnlabel.Size = new System.Drawing.Size(295, 20);
            this.Warnlabel.TabIndex = 9;
            this.Warnlabel.Text = "Wrong Username or Password";
            this.Warnlabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(747, 489);
            this.Controls.Add(this.Warnlabel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.min);
            this.Controls.Add(this.closebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userimg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox userimg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox passimg;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label Warnlabel;
    }
}

