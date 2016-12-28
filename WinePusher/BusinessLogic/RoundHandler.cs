using System;
using System.Collections.Generic;
using System.Linq;
using WinePusher.Models;

namespace WinePusher.BusinessLogic
{
    class RoundHandler
    {
        winepusherEntities wpe = new winepusherEntities();

        public RoundHandler()
        {
        }

        public void CreateRound(int WineId, DateTime RoundDate, string Status)
        {
            rounds round = new rounds();
            round.WineId = WineId;
            round.Date = RoundDate;
            round.Status = Status;

            try
            {
                wpe.rounds.Add(round);
                wpe.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<RoundListItem> ListRounds()
        {
            var statusList = new[] { "A", "B" };

            List<RoundListItem> roundListItemList = wpe.rounds
                                                   .Join(wpe.wines,
                                                      round => round.WineId,
                                                      wine => wine.Id,
                                                      (round, wine) => new { round, wine })
                                                   .GroupJoin(wpe.orders,
                                                      o => o.round.Id,
                                                      order => order.RoundId,
                                                      (o, order) => new { o, orderCount = order.Count() })
                                                   .Where(w => statusList.Contains(w.o.round.Status))
                                                   .GroupBy(w => new
                                                   {
                                                       w.o.round.Id,
                                                       w.o.wine.Name,
                                                       w.o.wine.Type,
                                                       w.o.wine.Store,
                                                       w.o.wine.Price,
                                                       w.o.round.Date,
                                                       w.o.round.Status,
                                                       w.orderCount
                                                   })
                                                   .Select(w => new RoundListItem
                                                   {
                                                       RoundId = w.Key.Id,
                                                       WineName = w.Key.Name,
                                                       WineType = w.Key.Type,
                                                       Store = w.Key.Store,
                                                       WinePrice = w.Key.Price,
                                                       RoundDate = w.Key.Date,
                                                       RoundStatus = w.Key.Status == "A" ? "Aktiv" : (w.Key.Status == "B" ? "Bestilt" : null),
                                                       OrdersCount = w.Key.orderCount
                                                   }).ToList();
            return roundListItemList;
        }

        public Wine GetRoundWine(int RoundId)
        {
            Wine wine = wpe.rounds
                        .Join(wpe.wines, r => r.WineId, w => w.Id, (r, w) => new { r, w })
                        .Where(ws => ws.r.Id == RoundId)
                        .Select(w => new Wine
                        {
                            Id = w.w.Id,
                            Type = w.w.Type,
                            Name = w.w.Name,
                            Store = w.w.Store,
                            Price = w.w.Price
                        }).FirstOrDefault();

            return wine;
        }
    }
}
