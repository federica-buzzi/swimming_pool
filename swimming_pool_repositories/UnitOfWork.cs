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
    public class UnitOfWork
    {
        IConcreteRepository<NewsEntity> _newsRepo;
        IConcreteRepository<PlanningEntity> _planningRepo;
        IConcreteRepository<PriceEntity> _priceRepo;
        IConcreteRepository<BookingFormEntity> _bookingFormRepo;

        public UnitOfWork(string connectionString)
        {
            _newsRepo = new NewsRepository(connectionString);
            _planningRepo = new PlanningRepository(connectionString);
            _priceRepo = new PriceRepository(connectionString);
            _bookingFormRepo = new BookingFormRepository(connectionString); 
        }

        #region Planning
        public List<PlanningModel> GetPlanning()
        {
            //instanciation repo 
           List<PlanningEntity> planningfromDB = _planningRepo.Get();

           //mapping de l'entity vers le model
           List<PlanningModel> planningToController = new List<PlanningModel>();


            foreach (PlanningEntity item in planningfromDB)
            {
                planningToController.Add(new PlanningModel() 
                    { ScheduledDays = item.ScheduledDays,
                      ScheduledTimeStart = item.ScheduledTimeStart, 
                      ScheduledTimeEnd= item.ScheduledTimeEnd, 
                      ExtraInfo= item.ExtraInfo,
                }); 
            }

            return planningToController;
        }
        #endregion

        #region Price

        public Dictionary<string, List<PriceModel>> GetPrice()
        {
            //instanciation repo 
            List<PriceEntity> pricefromDB = _priceRepo.Get();

            //creation d'un dictionary pour stocker les 2 listes priceStGilloisToController, priceNStGilloisToController
            Dictionary<string, List<PriceModel>> allPrices = new Dictionary<string, List<PriceModel>>();

            //mapping de l'entity vers le model
            List<PriceModel> priceStGilloisToController = new List<PriceModel>();
            List<PriceModel> priceNStGilloisToController = new List<PriceModel>();

            foreach (PriceEntity item in pricefromDB)
            {
                if (item.StGillois == true)
                {
                    priceStGilloisToController.Add(new PriceModel()
                    {
                        TicketType = item.TicketType,
                        TicketPrice = item.TicketPrice,
                    });
                }
                else
                {
                    priceNStGilloisToController.Add(new PriceModel()
                    {
                        TicketType = item.TicketType,
                        TicketPrice = item.TicketPrice,
                    });
                }
            }

            allPrices.Add("priceStGillois", priceStGilloisToController);
            allPrices.Add("priceNStGillois", priceNStGilloisToController);
            return allPrices; 
        }

        #endregion

        #region News
        public List<NewsModel> GetNews() 
        {
            //instanciation repo 
            List<NewsEntity> newsfromDB = _newsRepo.Get();

            //mapping de l'entity vers le model
            List<NewsModel> newsToController = new List<NewsModel>(); 

            foreach(NewsEntity item in newsfromDB)
            {
                newsToController.Add(new NewsModel()
                {
                    Image = item.Image, 
                    Caption = item.Caption, 
                }); 

            }
            return newsToController; 
        }
        #endregion

        #region Booking

        public bool SaveBooking(BookingFormModel bfm)
        { 
            //instanciation repo 
            BookingFormEntity bfe = new BookingFormEntity();
            {
                //mapping du model vers l'entité
                bfe.FirstName = bfm.FirstName;
                bfe.LastName = bfm.LastName;
                bfe.SpotsBooked = bfm.SpotsBooked;
                bfe.Email = bfm.Email;
                bfe.Telephone = bfm.Telephone;
                bfe.BookingDate = bfm.BookingDate;
                bfe.BookingTime = bfm.BookingTime;
                bfe.Message = bfm.Message;
            }; 
            return _bookingFormRepo.Insert(bfe); 
        }
        #endregion
    }
}
