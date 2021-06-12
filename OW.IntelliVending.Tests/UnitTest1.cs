using NUnit.Framework;
using OW.IntelliVending.DataReader;
using OW.IntelliVending.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OW.IntelliVending.Service
{
    public class Tests
    {
        IGenericRepository<VTransaction> _jsonRepository;
        

        private IList<VTransaction> transactionItems;


        [SetUp]
        public void Setup()
        {
            _jsonRepository = new JsonRepository();


            transactionItems = _jsonRepository.GetAll().ToList();
        
        }

        [Test]
        public void ShouldGetAtleastOneRecordFromJson()
        {
            Assert.That(transactionItems.Count > 0);
        }
        
    }
}