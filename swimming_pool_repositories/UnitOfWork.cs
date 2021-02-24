using NetFlask.DAL.Repositories;
using swimmin_pool_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimming_pool_repositories
{
    public class UnitOfWork
    {
        IConcreteRepository<NewsEntity> _newsRepo;
        IConcreteRepository<PlanningEntity> _planningRepo;
        IConcreteRepository<PriceEntity> _priceRepo; 


        public UnitOfWork(string connectionString)
        {
            //_newsRepo = new NewsEntity(connectionString);
            //_planningRepo = new PlanningEntity 
        }
    }
}
