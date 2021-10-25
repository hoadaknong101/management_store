using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management_store
{
    class ItemEqualityComparer : IEqualityComparer<UCSanPhamBar>
    {
        public bool Equals(UCSanPhamBar x, UCSanPhamBar y)
        {
            return x.MaSP == y.MaSP;
        }

        public int GetHashCode(UCSanPhamBar obj)
        {
            return obj.MaSP.GetHashCode();
        }
    }
}
