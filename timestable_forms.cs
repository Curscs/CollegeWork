namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            if (int.TryParse(textBox.Text, out int value))
            {
                if (value < 10 && value > 0)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        listBox.Items.Add($"{value} * {i + 1} = {value * (i + 1)}");
                    }
                }
            }
            else
            {

            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
