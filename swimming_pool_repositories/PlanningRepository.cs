using NetFlask.DAL.Repositories;
using swimmin_pool_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimming_pool_repositories
{
    public class PlanningRepository : BaseRepository<PlanningEntity>, IConcreteRepository<PlanningEntity>
    {

        public PlanningRepository(string Cnstr) : base(Cnstr)
        {

        }

        public bool Delete(PlanningEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<PlanningEntity> Get()
        {
            string requete = "Select * from Planning";
            return base.Get(requete); 
        }

        public PlanningEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PlanningEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(PlanningEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
