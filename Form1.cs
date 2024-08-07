using System.Globalization;

namespace CSharpp_TinhLaiSuat3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (double i = 0.01; i < 0.101; i += 0.001)
            {
                cbxLai.Items.Add(String.Format("{0:P1}", Math.Round(i, 3)));

            }
            txtGui.Text = "10000000";
            cbxLai.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listLKQ.Items.Clear();
            double Gui =Convert.ToInt64(txtGui.Text);
            int Nam = (int)txtGui.Value;
            double laisuat = double.Parse(cbxLai.SelectedItem.ToString().Replace("%", "")) / 100;
            for (int i = 0; i < Nam; i++)
            {
                double tienlai = Gui * laisuat;
                listLKQ.Items.Add("Năm" + i + "Tiền Gốc" + Gui.ToString("N", new CultureInfo("en-US")) + "- Lãi:" + tienlai.ToString("N", new CultureInfo("en-US")));
                Gui += tienlai;
            } 
                

        }
    }
}
