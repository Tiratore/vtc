using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VTC
{
    public class Frame
    {        
        public int priority;
        public float xStart;
        public float yStart;
        public float xStop;
        public float yStop;

        // img

        public Frame(int priority, float xStart, float yStart)
        {
            this.priority = priority;
            this.xStart = xStart;
            this.yStart = yStart;
        }

        public bool isPointInRectangle(float x, float y)
        {
            bool result = false;
            if (this.xStart < this.xStop)
            {
                if (x >= this.xStart && x <= this.xStop)
                {
                    result = true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (x <= this.xStart && x >= this.xStop)
                {
                    result = true;
                }
                else
                {
                    return false;
                }
            }
            if (this.yStart < this.yStop)
            {
                if (y >= this.yStart && y <= this.yStop)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                if (y <= this.yStart && y >= this.yStop)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }
    }


}
