using System;
using System.Collections.Generic;
using System.Text;

namespace Day_08
{
    class Deriction
    {
        public int Rindex { get; set; }
        public int Cindex { get; set; }
        public Deriction() { }
        public Deriction(int rindex, int cindex) 
        {
            this.Rindex = rindex;
            this.Cindex = Cindex;
        }
        public static Deriction Up 
        {
            get {
                return new Deriction(-1, 0);
            }
        }
        public static Deriction Down
        {
            get
            {
                return new Deriction(1, 0);
            }
        }
        public static Deriction Left
        {
            get
            {
                return new Deriction(0, -1);
            }
        }
        public static Deriction Right
        {
            get
            {
                return new Deriction(0, 1);
            }
        }
    }
}
