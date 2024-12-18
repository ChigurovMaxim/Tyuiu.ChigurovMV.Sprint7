using Tyuiu.ChigurovMV.Sprint7.Project.V10.Lib;
namespace Project.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        private void buttonOpenFile_CMV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            openFileDialogTask_CMV.ShowDialog();
            openFilePath = openFileDialogTask_CMV.FileName;

            int[,] arrayValues = ds.GetMatrix(openFilePath);


        }
    }
}
