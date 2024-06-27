using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Audit_DAO = DAO.AuditDAO;

namespace BUS
{
    public class AuditBUS
    {
        Audit_DAO audit = new Audit_DAO();
        public DataTable GetObjects(string username, string password) => audit.LoadObjects(username, password);
        public DataTable StandardAudit(string username, string password, string objectName) => audit.StandardAudit(username, password, objectName);

        public DataTable FineGrainedAudit(string username, string password) => audit.FineGrainedAudit(username, password);
    }
}
