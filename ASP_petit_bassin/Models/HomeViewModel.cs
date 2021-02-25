using swimming_pool_models;
using swimming_pool_repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ASP_petit_bassin.Models
{
    public class HomeViewModel
    {
        private UnitOfWork uow = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

        
        private List<PlanningModel> _planning;
        private List<PriceModel> _priceStGillois, _priceNStGillois; 
        private List<NewsModel> _news;

        public HomeViewModel()
        {
            //   section horaires
            Planning = new List<PlanningModel>();
            Planning.Add(new PlanningModel() { ScheduledDays = "lundi, mardi, jeudi, vendredi", ScheduledTimeStart= new TimeSpan(08,00,00), ScheduledTimeEnd= new TimeSpan(19,00,00), ExtraInfo="rentrée chaque 30 min" });
            Planning.Add(new PlanningModel() { ScheduledDays = "mercredi", ScheduledTimeStart = new TimeSpan(14, 00, 00), ScheduledTimeEnd = new TimeSpan(19, 00, 00), ExtraInfo = "rentrée chaque 30 min" });
            Planning.Add(new PlanningModel() { ScheduledDays = "samedi", ScheduledTimeStart = new TimeSpan(09, 00, 00), ScheduledTimeEnd = new TimeSpan(12, 00, 00), ExtraInfo = "rentrée chaque 30 min" });
            Planning.Add(new PlanningModel() { ScheduledDays = "dimanche", ScheduledTimeStart = new TimeSpan(08, 30, 00), ScheduledTimeEnd = new TimeSpan(14, 00, 00), ExtraInfo = "rentrée chaque 30 min" });


            //   section tarifs StGillois 
            PriceStGillois = new List<PriceModel>();
            PriceStGillois.Add(new PriceModel() { TicketType = "ticket simple", TicketPrice = 2.5 });
            PriceStGillois.Add(new PriceModel() { TicketType = "ticket simple junior/senior", TicketPrice = 2 });
            PriceStGillois.Add(new PriceModel() { TicketType = "carnet 12 bains adulte", TicketPrice = 25 });
            PriceStGillois.Add(new PriceModel() { TicketType = "carnet 12 bains junior/senior", TicketPrice = 20 });
            PriceStGillois.Add(new PriceModel() { TicketType = "abbonnement 3 mois adulte", TicketPrice = 48 });
            PriceStGillois.Add(new PriceModel() { TicketType = "abbonnement 3 mois junior/senior", TicketPrice = 40 });

            //   section tarifs NStGillois
            PriceNStGillois = new List<PriceModel>();
            PriceNStGillois.Add(new PriceModel() { TicketType = "ticket simple", TicketPrice = 4.5 });
            PriceNStGillois.Add(new PriceModel() { TicketType = "ticket simple junior/senior", TicketPrice = 3.5 });
            PriceNStGillois.Add(new PriceModel() { TicketType = "carnet 12 bains adulte", TicketPrice = 45 });
            PriceNStGillois.Add(new PriceModel() { TicketType = "carnet 12 bains junior/senior", TicketPrice = 35 });
            PriceNStGillois.Add(new PriceModel() { TicketType = "abbonnement 3 mois adulte", TicketPrice = 68 });
            PriceNStGillois.Add(new PriceModel() { TicketType = "abbonnement 3 mois junior/senior", TicketPrice = 57 });

            // section news
            News = new List<NewsModel>();
            News.Add(new NewsModel() { Image = "illustration1.png", Caption = "amazing pool party!" });
            News.Add(new NewsModel() { Image = "illustration2.png", Caption = "swimming pool closed from 14th february" });
            News.Add(new NewsModel() { Image = "illustration3.png", Caption = "no aquagym classes" });

        }



        #region Props



        public List<PriceModel> PriceStGillois
        {
            get
            {
                return _priceStGillois;
            }

            set
            {
                _priceStGillois = value;
            }
        }

        public List<PriceModel> PriceNStGillois
        {
            get
            {
                return _priceNStGillois;
            }

            set
            {
                _priceNStGillois = value;
            }
        }

        public List<NewsModel> News
        {
            get
            {
                return _news;
            }

            set
            {
                _news = value;
            }
        }

        public List<PlanningModel> Planning
        {
            get
            {
                return _planning;
            }

            set
            {
                _planning = value;
            }
        }

        #endregion
    }
}