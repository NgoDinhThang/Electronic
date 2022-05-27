using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace BTL_Winform
{
    public partial class HoaDon_GUI : Form
    {
        HoaDon_DTO hoaDonDTO = new HoaDon_DTO();
        HoaDon_BUS HoaDonBUS = new HoaDon_BUS();
        public HoaDon_GUI()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao = MessageBox.Show("Bạn có muốn đóng trang này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ThongBao == DialogResult.No) return;
            else
            {
                this.Close();
            }
        }
        private void loadData()
        {
            dgvHoaDon.DataSource = HoaDonBUS.getData();
        }
        private void fHoaDon_Load(object sender, EventArgs e)
        {
            loadData();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {

            if (keyData == Keys.Enter)
            {
                btnTimKiem.PerformClick();
                return true;
            }

            else return base.ProcessDialogKey(keyData);
        }
        private void InHoaDon()
        {
            String filename = "HoaDon";
            var savefile = new SaveFileDialog();
            savefile.FileName = filename;
            savefile.DefaultExt = ".pdf";
            if (savefile.ShowDialog() == DialogResult.OK)
            { // set up để thêm dữ liệu
                iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 20f);
                Stream stream = new System.IO.FileStream(savefile.FileName, FileMode.Create);
                PdfWriter.GetInstance(document, stream);
                document.Open();

                PdfPTable table = new PdfPTable(2);
                PdfPTable table1 = new PdfPTable(2);
                float[] columnsWidth = { 1, 1 };
                table.SetWidths(columnsWidth);
                table.DefaultCell.BorderWidth = 0;
                table.DefaultCell.Padding = 10;
                table.WidthPercentage = 100;
                table.HorizontalAlignment = Element.ALIGN_CENTER;
                // font chữ
                string FontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                BaseFont bf = BaseFont.CreateFont(FontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font fontHearder = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font font8 = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.ITALIC);

                Chunk b = new Chunk(" Công ty Điện lực Hà Nội\n", fontHearder);
                Paragraph a = new Paragraph();
                a.Alignment = Element.ALIGN_CENTER;
                a.Add(b);

                Phrase phrase2 = new Phrase("\nHÓA ĐƠN GTGT (TIỀN ĐIỆN) ", fontHearder);
                PdfPCell pdfPCell2 = new PdfPCell(phrase2);
                pdfPCell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell2.Colspan = 3;
                pdfPCell2.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell2.PaddingBottom = 25;
                table.AddCell(pdfPCell2);

                Paragraph parablank = new Paragraph(" ", font);

                Phrase phrase8 = new Phrase("Mã hóa đơn:    " + txtHoaDon.Text, fontHearder);
                PdfPCell pdfPCell8 = new PdfPCell(phrase8);
                pdfPCell8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell8.Colspan = 3;
                pdfPCell8.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell8.PaddingBottom = 25;
                pdfPCell8.PaddingRight = 20;
                table1.AddCell(pdfPCell8);

                Phrase phrase4 = new Phrase("Mã khách hàng:     " + txtMaKH.Text, fontHearder);
                PdfPCell pdfPCell4 = new PdfPCell(phrase4);
                pdfPCell4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell4.Colspan = 3;
                pdfPCell4.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell4.PaddingBottom = 25;
                pdfPCell4.PaddingRight = 20;
                table1.AddCell(pdfPCell4);

                Phrase phrase5 = new Phrase("Tên khách hàng:    " + txtTenKH.Text, fontHearder);
                PdfPCell pdfPCell5 = new PdfPCell(phrase5);
                pdfPCell5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell5.Colspan = 3;
                pdfPCell5.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell5.PaddingBottom = 25;
                pdfPCell5.PaddingRight = 20;
                table1.AddCell(pdfPCell5);

                Phrase phrase6 = new Phrase("Loại điện:     " + txtLoaiDien.Text, fontHearder);
                PdfPCell pdfPCell6 = new PdfPCell(phrase6);
                pdfPCell6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell6.Colspan = 3;
                pdfPCell6.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell6.PaddingBottom = 25;
                pdfPCell6.PaddingRight = 20;
                table1.AddCell(pdfPCell6);

                Phrase phrase7 = new Phrase("Lượng tiêu thụ:       " + txtTieuThu.Text, fontHearder);
                PdfPCell pdfPCell7 = new PdfPCell(phrase7);
                pdfPCell7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell7.Colspan = 3;
                pdfPCell7.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell7.PaddingBottom = 25;
                pdfPCell7.PaddingRight = 20;
                table1.AddCell(pdfPCell7);

                Phrase phrase3 = new Phrase("Tổng tiền thanh toán:     " + txtTien.Text, font8);
                PdfPCell pdfPCell3 = new PdfPCell(phrase3);
                pdfPCell3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell3.Colspan = 3;
                pdfPCell3.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfPCell3.PaddingBottom = 15;
                pdfPCell3.PaddingRight = 20;
                pdfPCell3.BackgroundColor = BaseColor.RED;
                table1.AddCell(pdfPCell3);

                document.Add(a);
                document.Add(table);
                document.Add(parablank);
                document.Add(table1);
                document.Close();
                stream.Close();
                MessageBox.Show("In hóa đơn thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    System.Diagnostics.Process.Start("explorer.exe", savefile.FileName);
                }
                catch (Exception)
                {
                    System.Diagnostics.Process.Start("msedge.exe", savefile.FileName);

                }

            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoaDon.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Chọn hóa đơn cần thanh toán", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Xác nhận thanh toán", "Xác nhận", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        hoaDonDTO.MaHD = txtHoaDon.Text;
                        if (HoaDonBUS.getThanhToan(hoaDonDTO.MaHD))
                        {
                            MessageBox.Show("Thanh toán thành công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (MessageBox.Show("Bạn có muốn in hóa đơn?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                            {
                                InHoaDon();
                            }
                            loadData();
                        }
                        else
                        {
                            MessageBox.Show("Thanh toán không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        btnReset_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbHoaDon.Checked)
                {
                    dgvHoaDon.DataSource = HoaDonBUS.searchMaHD(txtTimKiem.Text);

                }
                else
                {
                    dgvHoaDon.DataSource = HoaDonBUS.searchMaKH(txtTimKiem.Text);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            loadData();
            txtTenKH.Clear();
            txtHoaDon.Clear();
            txtLoaiDien.Clear();
            txtMaThang.Clear();
            txtMaKH.Clear();
            txtTien.Clear();
            txtTieuThu.Clear();
            txtTimKiem.Clear();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtHoaDon.Text = dgvHoaDon.Rows[row].Cells[0].Value.ToString();
                txtMaKH.Text = dgvHoaDon.Rows[row].Cells[1].Value.ToString();
                txtMaThang.Text = dgvHoaDon.Rows[row].Cells[2].Value.ToString();
                txtTenKH.Text = dgvHoaDon.Rows[row].Cells[3].Value.ToString();
                txtLoaiDien.Text = dgvHoaDon.Rows[row].Cells[4].Value.ToString();
                txtTieuThu.Text = dgvHoaDon.Rows[row].Cells[5].Value.ToString();
                txtTien.Text = dgvHoaDon.Rows[row].Cells[6].Value.ToString();

            }
        }
    }
}
