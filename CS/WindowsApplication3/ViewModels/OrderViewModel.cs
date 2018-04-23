using System;
using System.Collections.Generic;
using System.Linq;
using DXSample.Common.ViewModels;
using DXSample.Models;


namespace DXSample.ViewModels {
    public class OrderViewModel : BaseViewModel<Order> {
        protected override void LoadEntities() {
            base.LoadEntities();
            for (int i = 0; i < 10; i++) {
                Entities.Add(new Order() { ID = Entities.Count, OrderDate = DateTime.Now.AddDays(-i), ProductType = i % 4 });
            }
        }
    }
}
