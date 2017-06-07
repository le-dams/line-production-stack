using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoMetall
{
    public class Coil
    {
        private string batch;

        [DisplayName("Couleur")]
        private String color { get; set; }

        [DisplayName("Epaisseur")]
        private double thickness { get; set; }

        [DisplayName("Largeur")]
        private int width { get; set; }

        [DisplayName("Longueur")]
        private int length { get; set; }

        [DisplayName("Reste")]
        private int lengthLeft { get; set; }

        public Coil(String inColor, double inThickness, int inWidth, int inLength)
        {
            this.color = inColor;
            this.thickness = inThickness;
            this.width = inWidth;
            this.length = inLength * 1000;

            this.lengthLeft = this.length;
        }

        public void use(int useLength)
        {
            if (this.lengthLeft - useLength < 0)
            {
                this.lengthLeft = 0;
            }
            else
            {
                this.lengthLeft -= useLength;
            }
        }

        // Setter
        public void setLengthLeft(int inLength)
        {
            this.lengthLeft = inLength  * 1000;
        }

        // getter

        public String getColor()
        {
            return this.color;
        }

        public int getLength()
        {
            return this.length;
        }

        public int getLengthLeft()
        {
            return this.lengthLeft;
        }

        public double getThickness()
        {
            return this.thickness;
        }

        public int getWidth()
        {
            return this.width;
        }
    }
}
