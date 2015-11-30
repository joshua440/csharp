using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic
{
    class Card
    {
        private String name, description, cost, color, image;
        
        public Card(String name, String description, String image, String color,String cost)
        {
            this.name = name;
            this.description = description;
            this.color = color;
            this.image = image;
            this.cost = cost;
        }
        public Card(String name, String color)
        {
            this.name = name;
            this.color = color;
        }

        public String getName() { return name; }
        public String getDescription() { return description; }

        public String getColor() { return color; }
        public String getImage() { return image; }
    }
}
