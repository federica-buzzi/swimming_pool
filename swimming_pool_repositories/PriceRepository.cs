using NetFlask.DAL.Repositories;
using swimmin_pool_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimming_pool_repositories
{
    public class PriceRepository : BaseRepository<PriceEntity>, IConcreteRepository<PriceEntity>
    {
        public PriceRepository(string Cnstr): base(Cnstr)
        {

        }
        public bool Delete(PriceEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<PriceEntity> Get()
        {
            throw new NotImplementedException();
        }

        public PriceEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PriceEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(PriceEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
