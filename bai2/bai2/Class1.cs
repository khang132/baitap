using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    private int mssv;
    private string hoten;
    private float diemlt;
    private float diemth;

    public int MSSV
    {
        get { return mssv; }
        set { mssv = (value > 0) ? value : 0; }
    }

    public string HoTen
    {
        get { return hoten; }
        set { hoten = (value != "") ? value : "Unknown"; }
    }

    public float DiemLT
    {
        get { return diemlt; }
        set { diemlt = (value >= 0 && value <= 10) ? value : 0; }
    }

    public float DiemTH
    {
        get { return diemth; }
        set { diemth = (value >= 0 && value <= 10) ? value : 0; }
    }

    public float DiemTB()
    {
        return (diemlt + diemth) / 2;
    }

    public override string ToString()
    {
        return string.Format("{0,-15} {1,-20} {2,-10} {3,-10} {4,-10}",
            mssv, hoten, diemlt, diemth, DiemTB());
    }
}

