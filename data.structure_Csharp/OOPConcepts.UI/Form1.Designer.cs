namespace OOPConcepts.UI
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
            lblyear = new Label();
            lblmont = new Label();
            lblday = new Label();
            btnvalidate = new Button();
            txtyear = new TextBox();
            txtmont = new TextBox();
            txtday = new TextBox();
            SuspendLayout();
            // 
            // lblyear
            // 
            lblyear.AutoSize = true;
            lblyear.Location = new Point(140, 61);
            lblyear.Name = "lblyear";
            lblyear.Size = new Size(44, 20);
            lblyear.TabIndex = 0;
            lblyear.Text = "Year: ";
            // 
            // lblmont
            // 
            lblmont.AutoSize = true;
            lblmont.Location = new Point(140, 109);
            lblmont.Name = "lblmont";
            lblmont.Size = new Size(51, 20);
            lblmont.TabIndex = 1;
            lblmont.Text = "Mont: ";
            // 
            // lblday
            // 
            lblday.AutoSize = true;
            lblday.Location = new Point(140, 165);
            lblday.Name = "lblday";
            lblday.Size = new Size(42, 20);
            lblday.TabIndex = 2;
            lblday.Text = "Day: ";
            // 
            // btnvalidate
            // 
            btnvalidate.Location = new Point(149, 249);
            btnvalidate.Name = "btnvalidate";
            btnvalidate.Size = new Size(220, 42);
            btnvalidate.TabIndex = 3;
            btnvalidate.Text = "VALIDATE";
            btnvalidate.UseVisualStyleBackColor = true;
            btnvalidate.Click += btnvalidate_Click;
            // 
            // txtyear
            // 
            txtyear.Location = new Point(244, 59);
            txtyear.Name = "txtyear";
            txtyear.PlaceholderText = "Ingrese un año...";
            txtyear.Size = new Size(125, 27);
            txtyear.TabIndex = 4;
            // 
            // txtmont
            // 
            txtmont.Location = new Point(244, 109);
            txtmont.Name = "txtmont";
            txtmont.PlaceholderText = "Ingrese un mes...";
            txtmont.Size = new Size(125, 27);
            txtmont.TabIndex = 5;
            // 
            // txtday
            // 
            txtday.Location = new Point(244, 165);
            txtday.Name = "txtday";
            txtday.PlaceholderText = "Ingrese un dia...";
            txtday.Size = new Size(125, 27);
            txtday.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 421);
            Controls.Add(txtday);
            Controls.Add(txtmont);
            Controls.Add(txtyear);
            Controls.Add(btnvalidate);
            Controls.Add(lblday);
            Controls.Add(lblmont);
            Controls.Add(lblyear);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblyear;
        private Label lblmont;
        private Label lblday;
        private Button btnvalidate;
        private TextBox txtyear;
        private TextBox txtmont;
        private TextBox txtday;
    }
}
