using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Audit_DAO = DAO.Audit;

namespace BUS
{
    public class Audit
    {
        Audit_DAO audit = new Audit_DAO();
        public DataTable GetObjects(string username, string password) => audit.LoadObjects(username, password);
        public DataTable StandardAudit(string username, string password, string objectName) => audit.StandardAudit(username, password, objectName);

    }
}
