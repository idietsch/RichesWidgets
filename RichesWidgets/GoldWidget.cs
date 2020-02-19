using System;
using System.Collections.Generic;
using System.Text;

namespace RichesWidgets {
    class GoldWidget : IProduct {

        private Product Product { get; set; }
        public string GetModelName() {
            return Product.GetModelName();
        }
        public double GetPrice() {

            return Product.GetPrice();

        }
        public GoldWidget() {
            Product = new Product {
                Code = "GW",
                Name = "Gold Widget",
                Model = ModelType.Gold
            };
        }

    }
}
