using System;
using System.Collections.Generic;
using System.Linq;
using WinePusher.Models;

namespace WinePusher.BusinessLogic
{
    class OrderHandler
    {
        winepusherEntities wpe = new winepusherEntities();

        public OrderHandler()
        {
        }

        public void CreateOrder(int RoundId, int MemberId, int Bottles, string Delivered, string Paid, string Status)
        {
            orders order = new orders();

            order.RoundId = RoundId;
            order.MemberId = MemberId;
            order.Bottles = Bottles;
            order.Delivered = Delivered;
            order.Paid = Paid;
            order.Status = Status;
            order.Date = DateTime.Now;

            try
            {
                wpe.orders.Add(order);
                wpe.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<OrderListItem> ListOrders(int RoundId)
        {
            List<OrderListItem> orderListItemList = wpe.orders
                                                   .Join(wpe.rounds,
                                                      o => o.RoundId,
                                                      r => r.Id,
                                                      (o, r) => new { o, r })
                                                   .Join(wpe.wines,
                                                      ro => ro.r.WineId,
                                                      w => w.Id,
                                                      (ro, w) => new { ro, w })
                                                   .Join(wpe.members,
                                                      row => row.ro.o.MemberId,
                                                      m => m.Id,
                                                   (row, m) => new { row, m })
                                                   .Where(rowm => rowm.row.ro.r.Id == RoundId)
                                                   .Select(rowmw => new OrderListItem
                                                   {
                                                       OrderId = rowmw.row.ro.o.Id,
                                                       MemberName = rowmw.m.Name,
                                                       OrderDate = rowmw.row.ro.o.Date,
                                                       WineName = rowmw.row.w.Name,
                                                       TotalAmount = (decimal)rowmw.row.w.Price * (decimal)rowmw.row.ro.o.Bottles,
                                                       Delivered = rowmw.row.ro.o.Delivered == "N" ? "Nej" : (rowmw.row.ro.o.Delivered == "Y" ? "Ja" : null),
                                                       Paid = rowmw.row.ro.o.Paid == "N" ? "Nej" : (rowmw.row.ro.o.Paid == "Y" ? "Ja" : null),
                                                   }).ToList();
            return orderListItemList;
        }
        public Order GetOrder(int OrderId)
        {
            Order order = wpe.orders
                                     .Join(wpe.rounds,
                                                      o => o.RoundId,
                                                      r => r.Id,
                                                      (o, r) => new { o, r })
                                                   .Join(wpe.wines,
                                                      ro => ro.r.WineId,
                                                      w => w.Id,
                                                      (ro, w) => new { ro, w })
                                                   .Join(wpe.members,
                                                      row => row.ro.o.MemberId,
                                                      m => m.Id,
                                                   (row, m) => new { row, m })
                                                   .Where(rowm => rowm.row.ro.o.Id == OrderId)
                                                   .Select(rowmw => new Order
                                                   {
                                                       OrderId = rowmw.row.ro.o.Id,
                                                       OrderDate = rowmw.row.ro.o.Date,
                                                       RoundId = rowmw.row.ro.r.Id,
                                                       MemberName = rowmw.m.Name,
                                                       WineName = rowmw.row.w.Name,
                                                       WineType = rowmw.row.w.Type,
                                                       WinePrice = (decimal)(rowmw.row.w.Price),
                                                       Bottles = (int)(rowmw.row.ro.o.Bottles),
                                                       OrderAmount = (decimal)rowmw.row.w.Price * (decimal)rowmw.row.ro.o.Bottles,
                                                       Delivered = rowmw.row.ro.o.Delivered,
                                                       Paid = rowmw.row.ro.o.Paid,
                                                   }).FirstOrDefault();
            return order;
        }
    }
}
