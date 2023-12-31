namespace Assignement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateControls_Click(object sender, EventArgs e)
        {
            int numberOfControls = int.Parse(txtNumberOfControls.Text);

            // Let's create a loop to create the correct number of buttons
            for (int i = 0; i < numberOfControls; i++)
            {
                if (comboBox1.Text == "Button")
                {
                    // Let's write code to create a single button dynamically
                    Button newButton = new Button();
                    newButton.Name = "DButton" + (i + 1);
                    newButton.Text = "Button" + (i + 1);
                    newButton.Size = new Size(120, 40);
                    newButton.Location = new Point(0, (i * 50));

                    pnlDynamicControls.Controls.Add(newButton);
                }
                else if (comboBox1.Text == "TextBox")
                {
                    TextBox newTextBox = new TextBox();
                    newTextBox.Name = "DTextBox" + (i + 1);
                    newTextBox.Text = "TextBox" + (i + 1);
                    newTextBox.Size = new Size(120, 40);
                    newTextBox.Location = new Point(0, (i * 50));

                    pnlDynamicControls.Controls.Add(newTextBox);
                }
                else if (comboBox1.Text == "Label")
                {
                    Label newLabel = new Label();
                    newLabel.Name = "DLabel" + (i + 1);
                    newLabel.Text = "Label" + (i + 1);
                    newLabel.Size = new Size(120, 40);
                    newLabel.Location = new Point(0, (i * 50));

                    pnlDynamicControls.Controls.Add(newLabel);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlDynamicControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}