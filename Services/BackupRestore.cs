using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BackupRestore
    {
        McBackupRestore mapper = new McBackupRestore();


        public void Backup()
        {
            String s = DateTime.Now.ToString();
            s = s.Replace("/", "-").Replace(":", ".");
            s = "USE MASTER BACKUP DATABASE Vand TO DISK = 'C:\\BackupRestoreVand\\" + s + ".bak'";
            mapper.impactarBD(s);
        }

        public void Restore(String Directorio)
        {

            String S = "USE MASTER" + Environment.NewLine;
            S += "ALTER DATABASE Vand SET SINGLE_USER WITH ROLLBACK IMMEDIATE" + Environment.NewLine;
            S += "DROP DATABASE Vand" + Environment.NewLine;
            S += "RESTORE DATABASE Vand FROM DISK = '" + Directorio + "' WITH REPLACE;";
            mapper.impactarBD(S);
        }


    }
}
