namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.Location = new Point(Random.Shared.Next(0, 700), Random.Shared.Next(0, 350));
        }
        private void label1_MouseHover(object sender, EventArgs e)
        {
            panel1.Location = new Point(Random.Shared.Next(0, 700), Random.Shared.Next(0, 350));
        }
    }
}