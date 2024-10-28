namespace kitapsqlornegi
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
            ulkeekle = new Button();
            telkodtextbox = new TextBox();
            ulketextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ulkeekle
            // 
            ulkeekle.Location = new Point(313, 17);
            ulkeekle.Name = "ulkeekle";
            ulkeekle.Size = new Size(94, 63);
            ulkeekle.TabIndex = 0;
            ulkeekle.Text = "Ekle";
            ulkeekle.UseVisualStyleBackColor = true;
            ulkeekle.Click += ulkeekle_Click;
            // 
            // telkodtextbox
            // 
            telkodtextbox.Location = new Point(118, 51);
            telkodtextbox.Name = "telkodtextbox";
            telkodtextbox.Size = new Size(189, 27);
            telkodtextbox.TabIndex = 1;
            // 
            // ulketextbox
            // 
            ulketextbox.Location = new Point(118, 17);
            ulketextbox.Name = "ulketextbox";
            ulketextbox.Size = new Size(189, 27);
            ulketextbox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 3;
            label1.Text = "Ülke:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 4;
            label2.Text = "Telefon Kodu:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(404, 359);
            dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 472);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ulketextbox);
            Controls.Add(telkodtextbox);
            Controls.Add(ulkeekle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ulkeekle;
        private TextBox telkodtextbox;
        private TextBox ulketextbox;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
    }
}
