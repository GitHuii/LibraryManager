using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.Models;

namespace LibraryManager.DAO
{
    public class DocGiaDAO
    {
        AppDbContext _context = new AppDbContext();
        public List<DocGia> GetAllDocGias()
        {
            return _context.DocGias.ToList();
        }
        public void Add(DocGia dg)
        {
            _context.DocGias.Add(dg);
            _context.SaveChanges();
        }

        public void Update(int ma, Action<DocGia> updateAction)
        {
            var dg = _context.DocGias.Find(ma);
            if (dg != null)
            {
                updateAction(dg); // cho phép sửa trực tiếp
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Không tìm thấy độc giả để sửa.");
            }
        }

        public void Delete(int maDG)
        {
            try
            {
                var dg = _context.DocGias.Find(maDG);
                if (dg == null)
                {
                    MessageBox.Show("Không tìm thấy độc giả để xóa trong CSDL.");
                    return;
                }

                _context.DocGias.Remove(dg);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi EF khi xóa trong DAO: " + ex.Message);
            }
        }


        public List<DocGia> Search(string keyword)
        {
            return _context.DocGias.Where(d => d.Ten.Contains(keyword)).ToList();
        }
    }

}


