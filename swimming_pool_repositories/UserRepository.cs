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
    public class UserRepository : BaseRepository<UserEntity>, IConcreteRepository<UserEntity>
    {

        public UserRepository(string Cnstr): base(Cnstr)
        {

        }
        public bool Delete(UserEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<UserEntity> Get()
        {
            throw new NotImplementedException();
        }

        public UserEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(UserEntity toInsert)
        {
            string requete = @"EXEC [dbo].[SP_User_Insert]
                @firstName,
                @lastName,
                @telephone,
                @email, 
                @password,
                @userName";
            return base.Insert(toInsert, requete); 
        }

        public bool Update(UserEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
