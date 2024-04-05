namespace ArrayTridimensional
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
            btnCreateMatrix = new Button();
            btnFillMatrix = new Button();
            btnShowMatrix = new Button();
            txtDim1 = new TextBox();
            txtDim2 = new TextBox();
            txtDim3 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCreateMatrix
            // 
            btnCreateMatrix.Location = new Point(655, 90);
            btnCreateMatrix.Name = "btnCreateMatrix";
            btnCreateMatrix.Size = new Size(170, 70);
            btnCreateMatrix.TabIndex = 0;
            btnCreateMatrix.Text = "Create";
            btnCreateMatrix.UseVisualStyleBackColor = true;
            btnCreateMatrix.Click += btnCreateMatrix_Click;
            // 
            // btnFillMatrix
            // 
            btnFillMatrix.Location = new Point(655, 218);
            btnFillMatrix.Name = "btnFillMatrix";
            btnFillMatrix.Size = new Size(170, 70);
            btnFillMatrix.TabIndex = 1;
            btnFillMatrix.Text = "Fill";
            btnFillMatrix.UseVisualStyleBackColor = true;
            btnFillMatrix.Click += btnFillMatrix_Click;
            // 
            // btnShowMatrix
            // 
            btnShowMatrix.Location = new Point(655, 351);
            btnShowMatrix.Name = "btnShowMatrix";
            btnShowMatrix.Size = new Size(170, 70);
            btnShowMatrix.TabIndex = 2;
            btnShowMatrix.Text = "Show";
            btnShowMatrix.UseVisualStyleBackColor = true;
            btnShowMatrix.Click += btnShowMatrix_Click;
            // 
            // txtDim1
            // 
            txtDim1.Location = new Point(191, 90);
            txtDim1.Name = "txtDim1";
            txtDim1.Size = new Size(219, 27);
            txtDim1.TabIndex = 3;
            // 
            // txtDim2
            // 
            txtDim2.Location = new Point(191, 240);
            txtDim2.Name = "txtDim2";
            txtDim2.Size = new Size(219, 27);
            txtDim2.TabIndex = 4;
            // 
            // txtDim3
            // 
            txtDim3.Location = new Point(191, 394);
            txtDim3.Name = "txtDim3";
            txtDim3.Size = new Size(219, 27);
            txtDim3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 21);
            label1.Name = "label1";
            label1.Size = new Size(349, 28);
            label1.TabIndex = 6;
            label1.Text = "Creation of three-dimensional matrix";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(981, 586);
            Controls.Add(label1);
            Controls.Add(txtDim3);
            Controls.Add(txtDim2);
            Controls.Add(txtDim1);
            Controls.Add(btnShowMatrix);
            Controls.Add(btnFillMatrix);
            Controls.Add(btnCreateMatrix);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateMatrix;
        private Button btnFillMatrix;
        private Button btnShowMatrix;
        private TextBox txtDim1;
        private TextBox txtDim2;
        private TextBox txtDim3;
        private Label label1;
    }
}
