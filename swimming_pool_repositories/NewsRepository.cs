using NetFlask.DAL.Repositories;
using swimmin_pool_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimming_pool_repositories
{
    public class NewsRepository : BaseRepository<NewsEntity>, IConcreteRepository<NewsEntity>
    {
        public NewsRepository(string Cnstr): base(Cnstr)
        {

        }
        public bool Delete(NewsEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<NewsEntity> Get()
        {
            string requete = "Select * from News";
            return base.Get(requete); 
        }

        public NewsEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(NewsEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(NewsEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
