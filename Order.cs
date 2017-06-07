using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoMetall
{
    public class Order
    {
        private bool _roof = true;
        private int height = 0;
        private int width = 0;
        private int ondes = 5;

        public Order(int inHeight, int inWidth)
        {
            this.setHeight(inHeight);
            this.setWidth(inWidth);
        }

        // Getter

        public int getHeight()
        {
            return this.height;
        }

        public int getWidth()
        {
            return this.width;
        }

        public int getLength(List<Sheet> inListSheet)
        {
            int length = 0;

            foreach (Sheet iSheet in inListSheet)
            {
                length += iSheet.getLength();
            }

            return length;
        }

        public bool isRoof()
        {
            return this._roof;
        }

        public int getOndes()
        {
            return this.ondes;
        }

        // Setter

        // Roof
        public void enabledRoof(bool chg)
        {
            this._roof = chg;
        }

        public void setOndes(int nbr)
        {
            this.ondes = nbr;
        }

        public void setHeight(int inHeight)
        {
            this.height = inHeight;
        }

        public void setWidth(int inWidth)
        {
            this.width = inWidth;
        }
    }
}
