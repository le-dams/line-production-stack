using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoMetall
{
    public class Sheet
    {
        private Material inner = new Material();
        private Material upper = new Material();

        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Longueur")]
        public int length {get; set;}

        [DisplayName("Largeur")]
        public int width { get; set; }

        [DisplayName("Hauteur")]
        public int height { get; set; }

        [DisplayName("LR")]
        public int cutLeft { get; set; }

        [DisplayName("RR")]
        public int cutRight { get; set; }

        public Sheet(int inId,int inLength,int inWidth, int inHeigth, int inCutLeft,int inCutRight)
        {
            this.id = inId;
            this.length = inLength;
            this.width = inWidth;
            this.height = inHeigth;
            this.cutLeft = inCutLeft;
            this.cutRight = inCutRight;
        }

        public int getId()
        {
            return this.id;
        }

        public int getLength()
        {
            return this.length;
        }

        public int getWidth()
        {
            return this.width;
        }

        public int getHeigth()
        {
            return this.height;
        }

        public int getCutRigth()
        {
            return this.cutRight;
        }

        public int getCutLeft()
        {
            return this.cutLeft;
        }
    }
}
