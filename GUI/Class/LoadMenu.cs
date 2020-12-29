using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Class
{
    class LoadMenu
    {
        public static FrmHeThong frm = new FrmHeThong();

        public LoadMenu() { }

        public void Load(bool isLogin)
        {
            frm.miDangNhap.Enabled = !isLogin;

            frm.miHuyKetNoi.Enabled = isLogin;
            frm.mDanhMuc.Enabled = isLogin;
            frm.mHoaDon.Enabled = isLogin;
            frm.mBaoCao.Enabled = isLogin;
            frm.mTraCuu.Enabled = isLogin;
        }

        static void Main()
        {
            Application.Run(frm);
        }
    }
}
