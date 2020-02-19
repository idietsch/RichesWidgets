using System;
using System.Collections.Generic;
using System.Text;

namespace RichesWidgets {
    class SilverWidget : IProduct{

        private Product Product { get; set; }
        public string GetModelName() {
            return Product.GetModelName();
        }
        public SilverWidget() {
            Product = new Product {
                Code = "SW",
                Name = "Silver Widget",
                Model = ModelType.Silver
            };
        }

        public double GetPrice() {

            return Product.GetPrice();

        }
    }
}
