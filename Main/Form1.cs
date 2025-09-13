using Main.Model;

namespace Main
{
    public partial class Form1 : Form
    {
        private Caculator casio = new Caculator();
        public Form1()
        {
            InitializeComponent();
        }
        private void btb_ac_Click(object sender, EventArgs e)
        {
            casio.deteleAll();
            lb_input.Text = "";
        }

        private void btb_ce_Click(object sender, EventArgs e)
        {
            if (lb_input.Text.Length > 0 && lb_input.Text != "0")
            {
                lb_input.Text = lb_input.Text.Substring(0, lb_input.Text.Length - 1);
            }
            if(lb_input.Text.Length == 0)
            {
                lb_input.Text = "0";
                casio.inputnew = true;
            }
        }
        private void xuLy_Click(object sender, EventArgs e)
        {
            Button nut = (Button)sender;
            if (casio.inputnew)
            {
                lb_input.Text = "";
                casio.inputnew = false;
            }
            if(nut.Text == "." && lb_input.Text.Contains("."))
            {
                return;
            }
            lb_input.Text += nut.Text;
        }
        private void xulyPhepToan(object sender, EventArgs e)
        {
            Button nut = (Button)sender;
            if (!casio.inputnew)
            {
                casio.saveInput(double.Parse(lb_input.Text), nut.Text);
            }
            lb_input.Text = "0";
        }
        private void xulyKQ_Click(object sender, EventArgs e)
        {
            try
            {
                double so2 = double.Parse(lb_input.Text);
                double ketQua = casio.tinhToan(so2);
                lb_input.Text = ketQua.ToString();
            }
            catch (DivideByZeroException ex)
            {
                lb_input.Text = ex.Message;
            }
            catch (Exception)
            {
                lb_input.Text = "Lỗi";
            }
        }
    }
}
