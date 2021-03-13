using NetFlask.DAL.Repositories;
using swimmin_pool_entities;
using swimming_pool_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimming_pool_repositories
{
    public class AdminRepository: BaseRepository<AdminModel>, IConcreteRepository<AdminEntity>
    {
        public AdminRepository(string Cnstr) : base(Cnstr)
        {

        }

        public bool Delete(AdminEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<AdminEntity> Get()
        {
            throw new NotImplementedException();
        }

        public AdminEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(AdminEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(AdminEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
