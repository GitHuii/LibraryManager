using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DAO
{
    public static class DbContextProvider
    {
        public static AppDbContext Instance { get; } = new AppDbContext();
        public static void Initialize()
        {
            var _ = Instance;
            try
            {
                Instance.TaiKhoans.ToList();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
