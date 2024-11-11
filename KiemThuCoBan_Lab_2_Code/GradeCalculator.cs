using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemThuCoBan_Lab_2_Code
{
    public class GradeCalculator
    {
        /// <summary>
        /// Tính trung bình điểm của 3 môn toán, lý, hoá
        /// </summary>
        /// <param name="diemToan"></param>
        /// <param name="diemLy"></param>
        /// <param name="diemHoa"></param>
        /// <returns></returns>
        public double CalculateAverage(double math, double physics, double chemistry)
        {
            if (math < 0 || math > 10 || physics < 0 || physics > 10 || chemistry < 0 || chemistry > 10)
            {
                throw new ArgumentOutOfRangeException("Điểm phải nằm trong khoảng từ 0 đến 10.");
            }

            return (math + physics + chemistry) / 3;
        }
    }
}
