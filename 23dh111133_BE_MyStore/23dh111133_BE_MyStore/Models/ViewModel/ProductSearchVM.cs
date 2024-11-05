using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23dh111133_BE_MyStore.Models.ViewModel
{
    public class ProductSearchVM
    {
        //tiêu chí để search theo tên,mô tả sp hoặc phân loại sp
        public string SearchTerm { get; set; }
        //tiêu chí để search theo giá tiền 
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        //tiêu chí sắp xếp 
        public string SortOrder {  get; set; }
        //danh sách các sản phẩm thỏa điều kiện tìm kiếm
        public List<Product> Products { get; set; }
    }
}