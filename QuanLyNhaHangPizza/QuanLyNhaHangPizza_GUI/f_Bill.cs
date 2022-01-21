using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHangPizza_GUI.BUS_Pizza;

namespace QuanLyNhaHangPizza_GUI
{
    public partial class f_Bill : Form
    {
        BUS_Bill bus_bill;

        public f_Bill()
        {
            InitializeComponent();
            bus_bill = new BUS_Bill();
        }

        private void f_Bill_Load(object sender, EventArgs e)
        {
            bus_bill.getAllBill(gridBill);
        }

        private void gridBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_Bill.Text = gridBill.CurrentRow.Cells["ID_Bill"].Value.ToString();
            txtID_Cus.Text = gridBill.CurrentRow.Cells["ID_Bill"].Value.ToString();
            txtID_Emp.Text = gridBill.CurrentRow.Cells["ID_Emp"].Value.ToString();
            txtDateFounded.Text = gridBill.CurrentRow.Cells["DateFounded"].Value.ToString();
            txtTotalMoney.Text = gridBill.CurrentRow.Cells["TotalMoney"].Value.ToString();
            txtNote.Text = gridBill.CurrentRow.Cells["BillNotes"].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID_Bill.Text == "")
                {
                    throw new Exception("Vui lòng chọn đơn hàng cần hủy thanh toán");

                }
                BILL bill = new BILL();
                bill.ID_Bill = txtID_Bill.Text;
                
                bus_bill.updateBillNote(bill);

                bus_bill.getAllBill(gridBill);

                txtID_Bill.Text = "";
                txtID_Cus.Text = "";
                txtID_Emp.Text = "";
                txtDateFounded.Text = "";
                txtTotalMoney.Text = "";
                txtNote.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
