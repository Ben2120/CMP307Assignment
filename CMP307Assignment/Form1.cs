namespace CMP307Assignment
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Employee employeeform = new Employee();
            employeeform.ShowDialog();
        }

        private void addasset_Click(object sender, EventArgs e)
        {
            AddingAsset assetsform = new AddingAsset();
            assetsform.ShowDialog();
        }

        private void SystemInfo_Click(object sender, EventArgs e)
        {
            View_Asset view_assetform = new View_Asset();
            view_assetform.ShowDialog();
        }
    }
}
