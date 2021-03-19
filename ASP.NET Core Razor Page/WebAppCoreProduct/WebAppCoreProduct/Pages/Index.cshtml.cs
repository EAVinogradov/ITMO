using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreProduct.Models;

namespace WebAppCoreProduct.Pages
{
    public class IndexModel : PageModel
    {
        //public string Name { get; set; }
        //public decimal? Price { get; set; }
        public bool IsCorrect { get; set; } = true;
        public Product Product { get; set; }
        public string MessageRezult { get; private set; }

        //public void OnGet(string name, decimal? price)
        //{
        //    Product = new Product();

        //    if (price == null || price < 0 || string.IsNullOrEmpty(name))
        //    {
        //        IsCorrect = false;
        //        return;
        //    }
        //    var result = price * (decimal?)0.18;
        //    MessageRezult = $"��� ������ {name} � ����� {price} ������ ��������� { result}";
        //    Product.Price = price;
        //    Product.Name = name;
        //}
        public void OnGet()
        {
            MessageRezult = "��� ������ ����� ���������� ������";
        }

        public void OnPost(string name, decimal? price)
        {
            Product = new Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageRezult = "�������� ������������ ������. ��������� ����";
            return;
            }
            var result = price * (decimal?)0.18;
            MessageRezult = $"��� ������ {name} � ����� {price} ������ ��������� { result}";
            Product.Price = price;
            Product.Name = name;
        }
    }
}
