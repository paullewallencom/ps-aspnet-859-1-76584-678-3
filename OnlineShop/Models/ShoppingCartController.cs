using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Models;

namespace OnlineShop.Models
{
    public class ShoppingCartController : Controller
    {
        private IPieRepository _pieRepository;
        private ShoppingCart _shoppingCart;

        public ShoppingCartController(IPieRepository pieRepository, ShoppingCart shoppingCart)
        {
            _pieRepository = pieRepository;
            _shoppingCart = shoppingCart;
        }
    }
}
