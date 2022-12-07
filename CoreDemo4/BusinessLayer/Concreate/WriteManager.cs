using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class WriteManager : IWriteService
    {
        IWriterDal _writeDal;
        public WriteManager(IWriterDal writerDal)
        {
            _writeDal = writerDal;
        }
        public void WriteAdd(Writer writer)
        {
            _writeDal.Insert(writer);
        }

    }
}
