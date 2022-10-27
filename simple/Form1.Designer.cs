namespace simple
{
    partial class Hi
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.Hello = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter your name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(112, 55);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(181, 23);
            this.tbName.TabIndex = 1;
            // 
            // Hello
            // 
            this.Hello.Location = new System.Drawing.Point(12, 109);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(281, 28);
            this.Hello.TabIndex = 2;
            this.Hello.Text = "Hello";
            this.Hello.UseVisualStyleBackColor = true;
            this.Hello.Click += new System.EventHandler(this.label1_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 143);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(281, 28);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Hi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 204);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Hello);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "Hi";
            this.Text = "Hi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbName;
        private Button Hello;
        private Button Exit;
    }
}