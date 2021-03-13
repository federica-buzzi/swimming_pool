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
        private Dictionary<string, List<PriceModel>> _allprices;
        

        public HomeViewModel()
        {
            //   section horaires
            
            Planning = uow.GetPlanning();

            //   recuperate allprices dictionary
            Allprices = uow.GetPrice();

            //   dans le dictionary recuperer tarifs StGillois 

            PriceStGillois = Allprices["priceStGillois"];

            //   tarifs NStGillois

            PriceNStGillois = Allprices["priceNStGillois"];

            //   section news
            News = uow.GetNews();

            

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

        public Dictionary<string, List<PriceModel>> Allprices
        {
            get
            {
                return _allprices;
            }

            set
            {
                _allprices = value;
            }
        }



        #endregion
    }
}