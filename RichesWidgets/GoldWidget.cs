using System;
using System.Collections.Generic;
using System.Text;
using static RichesWidgets.Program;

namespace RichesWidgets {
    class GoldWidget : IProduct{

        private Product Product { get; set; }
        public GoldWidget() {
            Product = new Product {
                Code = "GW",
                Name = "Gold Widget",
                Model = ModelType.Gold
            };
        }

        public double GetPrice() {

            return Product.GetPrice();

        }
    }
}
