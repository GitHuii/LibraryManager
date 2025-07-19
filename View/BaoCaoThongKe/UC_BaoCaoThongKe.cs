using LibraryManager.DAO;
using LibraryManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.View
{
    public partial class UC_BaoCaoThongKe : UserControl
    {
        AppDbContext dbContext = DbContextProvider.Instance;
        public UC_BaoCaoThongKe()
        {
            InitializeComponent();
        }

        public void BieuDoTienPhat(Guna.Charts.WinForms.GunaChart chart)
        {
            string[] months = { "January", "February", "March", "April", "May", "June",
                                "July", "August", "September", "October", "November", "December"
                              };

            decimal[] values = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //Chart configuration
            chart.Misc.BarCornerRadius = 10;
            chart.YAxes.GridLines.Display = false;
            

            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaBarDataset();
            dataset.Label = "Số tiền phạt theo tháng";
            
            var listPhieuPhat = dbContext.PhieuPhats.ToList();
            foreach(PhieuPhat pp in listPhieuPhat)
            {
                int m = pp.NgayLap.Month - 1; // Lấy tháng từ Ngày Lập
                if (m >= 0 && m < values.Length)
                {
                    values[m] += pp.SoTienPhat; // Cộng dồn số tiền phạt theo tháng
                }
            }

            for (int i = 0; i < months.Length; i++)
            {
                dataset.DataPoints.Add(months[i], Convert.ToDouble(values[i]));
            }

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }

        public void BieuDoTheLoaiMuon(Guna.Charts.WinForms.GunaChart chart)
        {
            string[] theloai = { "Giáo dục", "Khoa học", "Lịch sử", "Tâm lý", "Thiếu nhi", "Truyện ngắn", "Văn học" };
            decimal[] values = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //Chart configuration  
            chart.Legend.Position = Guna.Charts.WinForms.LegendPosition.Bottom;
            chart.Legend.Align = Guna.Charts.WinForms.ChartTextAlignment.Start;
            chart.XAxes.Display = false;
            chart.YAxes.Display = false;
            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaPieDataset();
            dataset.Label = "Số lượng sách mượn theo thể loại";
            var listchitietphieumuon = dbContext.ChiTietPhieuMuons.ToList();
            foreach (ChiTietPhieuMuon ccpm in listchitietphieumuon)
            {
                var sach = dbContext.Saches.FirstOrDefault(s => s.MaSach == ccpm.MaSach);
                if (sach != null)
                {
                    int index = Array.IndexOf(theloai, sach.TheLoai);
                    if (index >= 0 && index < values.Length)
                    {
                        values[index] += ccpm.SoLuongMuon; // Cộng dồn số lượng mượn theo thể loại
                    }
                }
            }
            for (int i = 0; i < theloai.Length; i++)
            {
                dataset.DataPoints.Add(theloai[i], Convert.ToDouble(values[i]));
            }

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }

        private void UC_BaoCaoThongKe_Load(object sender, EventArgs e)
        {
            charttienphat.Datasets.Clear();
            charttheloaimuon.Datasets.Clear();
            charttienphat.Legend.Display = false;
            BieuDoTienPhat(charttienphat);
            BieuDoTheLoaiMuon(charttheloaimuon);

            btn1.Text = $"TỔNG TIỀN PHẠT\n{dbContext.PhieuPhats.Sum(pp => pp.SoTienPhat).ToString("#,0", new System.Globalization.CultureInfo("vi-VN"))} VNĐ";
            btn2.Text = $"SỐ SÁCH CÒN LẠI\n{dbContext.Saches.Sum(s => s.SoLuong)}";
            btn3.Text = $"SỐ SÁCH CHƯA TRẢ\n{dbContext.ChiTietPhieuMuons.Where(ccpm => !ccpm.DaTra).Sum(ccpm => ccpm.SoLuongMuon)}";
            btn4.Text = $"TỔNG SÁCH ĐÃ MƯỢN\n{dbContext.ChiTietPhieuMuons.Sum(ccpm => ccpm.SoLuongMuon)}";
        }
    }
}
