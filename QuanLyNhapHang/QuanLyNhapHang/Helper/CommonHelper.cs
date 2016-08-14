

namespace QuanLyNhapHang.Helper
{
    using System;
    using System.Windows.Forms;
    public static class CommonHelper
    {
        public static bool CloseTabForm(this Form form)
        {
            try
            {
                var tabpage = form.Parent as TabPage;
                if (tabpage != null)
                {
                    var tab = tabpage.Parent as TabControl;
                    if (tab != null)
                    {
                        tab.TabPages.Remove(tabpage);
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
