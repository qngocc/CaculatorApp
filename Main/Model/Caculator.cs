using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Model
{
    public class Caculator
    {
        private double so1 = 0;
        private string toan = "";
        public bool inputnew = true;
        public void saveInput(double soNhap, string phepToan)
        {
            so1 = soNhap;
            toan = phepToan;
            inputnew = true;
        }
        public double tinhToan(double so2)
        {
            double ketqua = 0;
            switch (toan)
            {
                case "+":
                    ketqua = so1 + so2; break;
                case "-":
                    ketqua = so1 - so2;break;
                case "x":
                    ketqua = so1 * so2;break;
                case "÷":
                    if(so2 != 0)
                    {
                        ketqua = so1 / so2; break;
                    }
                    else
                    {
                        throw new DivideByZeroException("Không thể chia cho 0.");
                    }
                    break;
                case "%":
                    ketqua = so1 % so2; break;
            }
            so1 = ketqua;
            return ketqua;
        }
        public void deteleAll()
        {
            so1 = 0;
            toan = "";
            inputnew = true;
        }
    }
}
