using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    partial class Calculator
    {
        public float Cong()
        {
            return A + B;
        }

        public float Tru()
        {
            return A - B;
        }

        public float Nhan()
        {
            return A * B;
        }

        public string Chia()
        {
            if (B == 0)
            {
                return "Lỗi không thể tính toán";
            }
            return (A / B).ToString();
        }

      
    }
}
