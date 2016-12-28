using System;
using System.Linq;

namespace WinePusher.BusinessLogic
{
    class WineHandler
    {
        winepusherEntities wpe = new winepusherEntities();

        public WineHandler()
        {
        }

        public int CreateWine(string Type, string Name, decimal Price, string Store)
        {
            wines wine = new wines();
            wine.Type = Type;
            wine.Name = Name;
            wine.Price = Price;
            wine.Store = Store;

            try
            {
                wpe.wines.Add(wine);
                wpe.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return wine.Id;
        }
    }
}
