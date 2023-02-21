namespace Lab03_Homework
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void stuStrip_Click(object sender, EventArgs e)
        {
            formStu f = new formStu() ;
            f.ShowDialog();
        }

        private void deTaiStrip_Click(object sender, EventArgs e)
        {
            formDeTai f = new formDeTai();
            f.ShowDialog();
        }

        private void stuResStrip_Click(object sender, EventArgs e)
        {
            formStuRes f = new formStuRes();
            f.ShowDialog();
        }

        private void formMenu_Load(object sender, EventArgs e)
        {

        }
    }
}