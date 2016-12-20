using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_13_TipCalc.Models
{
    public class TipsViewModel
    {
        public ObservableCollection<Tip> Tips { get; set; }

        public TipsViewModel()
        {
            Tips = new ObservableCollection<Tip>
            {
                new Tip { Id = 1, Description = "Restaurants, Bartenders", Percentage = 0.15m },
                new Tip { Id = 2, Description = "Food Delivery", Percentage = 0.175m },
                new Tip { Id = 3, Description = "Hotel Room Service", Percentage = 0.20m },
                new Tip { Id = 4, Description = "Automotive Services, Mechanic" },
                new Tip { Id = 5, Description = "Mover, Furniture, or Appliance Delivery", FixedAmount = 5, IsFixedTip = true },
                new Tip { Id = 6, Description = "Home Services", FixedAmount = 10, IsFixedTip = true },
                new Tip { Id = 7, Description = "Hairstylists, Barber", Percentage = 0.10m },
                new Tip { Id = 8, Description = "Massage", Percentage = 0.10m },
                new Tip { Id = 9, Description = "Taxi", Percentage = 0.15m },
                new Tip { Id = 10, Description = "Tour Guides", FixedAmount = 1, IsFixedTip = true },
            };
        }
    }
}
