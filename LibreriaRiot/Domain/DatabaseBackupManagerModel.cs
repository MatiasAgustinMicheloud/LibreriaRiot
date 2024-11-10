using LibreriaRiot.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaRiot.Domain
{
    internal class DatabaseBackupManagerModel
    {
        private DatabaseBackupManager backupManager = new DatabaseBackupManager();

        public bool RealizarBackUp(string backupPath)
        {
            return backupManager.RealizarBackup("bd_LibreriaRiot", backupPath);
        }

        public bool RealizarRestauracion(string backupPath)
        {
            return backupManager.RealizarRestauracion("bd_LibreriaRiot", backupPath);
        }

    }
}
