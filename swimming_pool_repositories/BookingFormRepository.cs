using NetFlask.DAL.Repositories;
using swimmin_pool_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimming_pool_repositories
{
    public class BookingFormRepository : BaseRepository<BookingFormEntity>, IConcreteRepository<BookingFormEntity>
    {
        public BookingFormRepository(string Cnstr) : base(Cnstr)
        {

        }

        public bool Delete(BookingFormEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<BookingFormEntity> Get()
        {
            throw new NotImplementedException();
        }

        public BookingFormEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(BookingFormEntity toInsert)
        {
            string requete = @"INSERT INTO [dbo].[BookingForm]([FirstName], [LastName], [SpotsBooked], [Email], [BookingDate], [BookingTime], [Telephone]) VALUES (@FirstName, @LastName, @SpotsBooked, @Email, @BookingDate, @BookingTime, @Telephone)";
            return base.Insert(toInsert, requete); 
        }

        public bool Update(BookingFormEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
