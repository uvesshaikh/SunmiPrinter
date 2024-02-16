﻿using ZXing;

namespace SunmiPOSLib.Models
{
    public class CODE128A : BarcodeModel
    {
        public CODE128A() : base(8, "CODE128A", BarcodeFormat.CODE_128)
        {
        }
    }
}
