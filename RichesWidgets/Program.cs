using System;
using System.Collections.Generic;

namespace RichesWidgets {
    class Program {
        static void Main(string[] args) { 
        
           // var slvrNbr = 7;
           // var gldNbr = 9;
            
            var widgets = new List<IProduct>();
            for(var idx = 0; idx <3; idx++) {
                widgets.Add(new BronseWidget());
            }
            for (var idx2 = 0; idx2 < 7; idx2++) {
                widgets.Add(new SilverWidget());
            }
            for (var idx3 = 0; idx3 < 9; idx3++) {
                widgets.Add(new GoldWidget());
            }
            var total = 0.0;
            foreach(var widget in widgets) {
                total += widget.GetPrice();
            }

        }
                public enum ModelType { Bronse, Silver, Gold };
        public int BrnsNbr { get; set; }
        public int SlvrNbr { get; set; }
        public int GldNbr { get; set; }
        public class Product {​
                public string Code { get; set; }
                public string Name { get; set; }
                public ModelType Model { get; set; } 
​
            public double GetPrice() {
                    return Model switch {
                        ModelType.Bronse => 20,
                        ModelType.Silver => 90,
                        ModelType.Gold => 500,
                        _ => 0 // everything else
                    };
            }
            

​
            public Product() { 
            }
            public void Totaling() {
                var total = GetPrice();
                Console.WriteLine($"Total is ${total}");
            }
        }

        public class GenericCollection {

        }

        public interface IProduct {
            
            public double GetPrice();
​
        }
        
    }
}
