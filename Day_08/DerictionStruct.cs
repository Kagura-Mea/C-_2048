using System;
using System.Collections.Generic;
using System.Text;

namespace Day_08
{
    struct DerictionStruct
    {
        public int Rindex { get; set; }
        public int Cindex { get; set; }
        //因为结构体自带无参数构造函数，所以不能包含无参数的构造函数
        //public DerictionStruct() { }
        public DerictionStruct(int rindex, int cindex) : this() 
        {
            this.Rindex = rindex;
            this.Cindex = cindex;
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
