using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//example Code
//http://www.fluxbytes.com/csharp/create-and-connect-to-a-microsoft-access-database-programmatically-in-c/
namespace einsatzLeitSoftware
{
    class dataBase
    {
        public dataBase()
        {

        }

        public bool createDataBases()
        {
            bool isSuccesfullyCreated = true;

            if(createMainDataBase() == false)
            {
                isSuccesfullyCreated = false;
            }

            return isSuccesfullyCreated;
        }

        private bool createMainDataBase()
        {
            bool isSuccesfullyCreatedMainDataBase = true;
            string connectionString = string.Format("Provider={0}; Data Source={1}; Jet OLEDB:Engine Type={2}",
                                                    "Microsoft.Jet.OLEDB.4.0",
                                                    "mainDataBase.mdb",
                                                    5);
            ADOX.CatalogClass catalog = new ADOX.CatalogClass();
            catalog.Create(connectionString);

            ADOX.Table table = new ADOX.Table();
            table.Name = "mainDataBase";   // Table name

            // Column 1 (id)
            ADOX.ColumnClass idCol = new ADOX.ColumnClass();
            idCol.Name = "Id";  // The name of the column
            idCol.ParentCatalog = catalog;
            idCol.Type = ADOX.DataTypeEnum.adInteger;   // Indicates a four byte signed integer.
            idCol.Properties["AutoIncrement"].Value = true;     // Enable the auto increment property for this column.
 
            return isSuccesfullyCreatedMainDataBase;
        }
    }
}
