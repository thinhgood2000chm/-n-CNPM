using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class serviceManage
    {
        public List<nhanVien> getAllNhanVien()
        {
            QLCHDCEntities dbNhanVien = new QLCHDCEntities();
            var listNhanVien = dbNhanVien.nhanViens.ToList();
            return listNhanVien;
        }
        public List<khachHang> getAllKhachHang()
        {
            QLCHDCEntities dbKhachHang = new QLCHDCEntities();
            var listKH = dbKhachHang.khachHangs.ToList();
            return listKH;
        }
        public List<doChoi> getAllDC()
        {
            QLCHDCEntities dbDC = new QLCHDCEntities();
            var listDC = dbDC.doChois.ToList();
            return listDC;
        }
        public List<thanhToan> getAllConsumeP()
        {
            QLCHDCEntities dbConsP = new QLCHDCEntities();
            var listConsP = dbConsP.thanhToans.ToList();
            return listConsP;
        }
        public List<taiKhoan> getAllAcc()
        {
            QLCHDCEntities dbAcc = new QLCHDCEntities();
            var listAcc = dbAcc.taiKhoans.ToList();
            return listAcc;

        }
    }
}
