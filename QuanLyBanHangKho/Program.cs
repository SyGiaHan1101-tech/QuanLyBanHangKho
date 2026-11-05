using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangKho
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmStockReceiptDetail());
        }
    }
}
// frmSupplierManagement - Quản lý nhà cung cấp 
// frmCategoryManagement - Quản lý danh mục 
// frmProductManagement - Quản lý sản phẩm
// frmStockReceipt - Quản lý phiếu nhập
// frmStockReceiptDetail - Quản lý chi tiết phiếu nhập
// frmInventoryReport - Báo cáo tồn kho
