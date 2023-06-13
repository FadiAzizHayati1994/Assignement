namespace Assignement
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
            btnCreateControls = new Button();
            comboBox1 = new ComboBox();
            txtNumberOfControls = new TextBox();
            pnlDynamicControls = new Panel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCreateControls
            // 
            btnCreateControls.Location = new Point(263, 105);
            btnCreateControls.Margin = new Padding(4);
            btnCreateControls.Name = "btnCreateControls";
            btnCreateControls.Size = new Size(187, 68);
            btnCreateControls.TabIndex = 0;
            btnCreateControls.Text = "Create Controls";
            btnCreateControls.UseVisualStyleBackColor = true;
            btnCreateControls.Click += btnCreateControls_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Button", "TextBox", "Label" });
            comboBox1.Location = new Point(217, 16);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(294, 33);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtNumberOfControls
            // 
            txtNumberOfControls.Location = new Point(217, 57);
            txtNumberOfControls.Margin = new Padding(4);
            txtNumberOfControls.Name = "txtNumberOfControls";
            txtNumberOfControls.Size = new Size(294, 31);
            txtNumberOfControls.TabIndex = 2;
            // 
            // pnlDynamicControls
            // 
            pnlDynamicControls.BackColor = Color.White;
            pnlDynamicControls.BorderStyle = BorderStyle.FixedSingle;
            pnlDynamicControls.Location = new Point(165, 181);
            pnlDynamicControls.Margin = new Padding(4);
            pnlDynamicControls.Name = "pnlDynamicControls";
            pnlDynamicControls.Size = new Size(382, 465);
            pnlDynamicControls.TabIndex = 3;
            pnlDynamicControls.Paint += pnlDynamicControls_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 4;
            label1.Text = "Control Type";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 57);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 5;
            label2.Text = "Number of controls";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(728, 669);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlDynamicControls);
            Controls.Add(txtNumberOfControls);
            Controls.Add(comboBox1);
            Controls.Add(btnCreateControls);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateControls;
        private ComboBox comboBox1;
        private TextBox txtNumberOfControls;
        private Panel pnlDynamicControls;
        private Label label1;
        private Label label2;
    }
}