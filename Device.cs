using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IsoMetall
{
    class Device
    {
        // DMX
        public const String mainDLL = "C:\\Users\\le-dams\\Desktop\\K8062d.dll";

        [DllImport(mainDLL)]
        public static extern void StartDevice();

        [DllImport(mainDLL)]
        public static extern void StopDevice();

        [DllImport(mainDLL)]
        public static extern void SetData(int Channel, int Data);

        [DllImport(mainDLL)]
        public static extern void SetChannelCount(int Count);

        // Vars
        const int max = 255;

        private int limit = 0;
        private int value = 0;

        private int ratio = 0;
        private int position = 0;

        public void setLimit(int inLimit)
        {
            this.limit = inLimit;
            this.setRatio();
        }

        public void setValue(int inValue)
        {
            this.value = inValue;
            this.setRatio();
        }

        private void setRatio()
        {
            this.ratio = this.value * 100 / this.limit;
        }

        public void setPosition()
        {
            this.position = max / 100 * this.ratio;
            //SetData(1, this.position);
        }

        public int getPosition()
        {
            return this.position;
        }

        // Actions

        public void open()
        {
            SetData(4, 0);
            SetData(5, 255);
        }

        public void close()
        {
            SetData(5, 0);
        }

        public void blink()
        {
            SetData(5, 255);
            SetData(4, 200);
        }

        // Power

        public void Start()
        {
            StartDevice();

            SetData(1, 127);
            SetData(2, 127);

            SetData(3, 255);
            SetData(5, 255);
        }

        public void Stop()
        {
            StopDevice();
        }
    }
}
