namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
 
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            this.Hide();
            test.Show();
            test.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
            Show();
            };
           
        }
    }
}
