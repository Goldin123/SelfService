using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfService.Business.Interface;
using SelfService.Model;

namespace SelfService.Business.Abstract
{
    public sealed class DashboardBL : Interface.IDashboardBL
    {
        private SelfService.Data.Inteface.IDashboardDB _dashboardDB = new SelfService.Data.Abstract.DashboardDB();
        Dashboard IDashboardBL.GetDashboard() => _dashboardDB.GetDashboard();
        
    }
}
