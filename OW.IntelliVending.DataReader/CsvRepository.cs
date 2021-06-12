using CsvHelper;
using OW.IntelliVending.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace OW.IntelliVending.DataReader
{
    public class CsvRepository : IGenericRepository<VMachine>
    {
        private readonly string fileName;
        private IList<VMachine> Items;

        public CsvRepository()
        {
            //fileName = _fileName;
            //Items = new List<HumphriesItem>();
        }

        public IEnumerable<VMachine> GetAll()
        {

            using (var reader = new StreamReader(@"C:\Training\Builxact\humphries.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Items =  csv.GetRecords<VMachine>().ToList();
            }

            return Items;
        }
    }
}
