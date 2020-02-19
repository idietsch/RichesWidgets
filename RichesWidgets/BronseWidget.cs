using System;
using System.Collections.Generic;
using System.Text;

namespace RichesWidgets {
        
    class BronseWidget : IProduct{
        private Product Product { get; set; }
        public string GetModelName() {
            return Product.GetModelName();
        }
        public BronseWidget() {
            Product = new Product {
                Code = "BW",
                Name = "Bronse Widget",
                Model = ModelType.Bronse
            };
        }

        public double GetPrice() {

            return Product.GetPrice();
            
        }
    }
}
