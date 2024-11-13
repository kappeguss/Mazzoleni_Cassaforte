namespace Mazzoleni_Cassaforte
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(65, 152);
            button1.Name = "button1";
            button1.Size = new Size(125, 71);
            button1.TabIndex = 0;
            button1.Text = "Imposta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(65, 262);
            button2.Name = "button2";
            button2.Size = new Size(125, 65);
            button2.TabIndex = 1;
            button2.Text = "Apri";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(596, 152);
            button3.Name = "button3";
            button3.Size = new Size(134, 71);
            button3.TabIndex = 2;
            button3.Text = "Chiudi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(596, 262);
            button4.Name = "button4";
            button4.Size = new Size(134, 65);
            button4.TabIndex = 3;
            button4.Text = "Sblocca";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 21);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 4;
            label1.Text = "Codice Utente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 56);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 5;
            label2.Text = "\"da scrivere\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 195);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 6;
            label3.Text = "CASSAFORTE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 246);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "CHIUSA";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}