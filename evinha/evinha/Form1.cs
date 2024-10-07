namespace evinha
{
    public partial class Form1 : Form
    {
        string filename { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var result = ofd.ShowDialog(this);
            filename = ofd.FileName;
            if (result == DialogResult.OK)
            {
                string text = File.ReadAllText(filename);
                textBox1.Text = text;
                label1.Text = filename;
            }

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filename, textBox1.Text);
        }

        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {

        }
    }

}
