﻿using iShop.Web.Server.Commons.BaseClasses;
using iShop.Web.Server.Core.Models;
using iShop.Web.Server.Core.Resources;

namespace iShop.Web.Server.Mapping
{
    public class OrderItemProfile:BaseProfile
    {
        public OrderItemProfile(string profileName) : base(profileName)
        {
        }

        protected override void CreateMap()
        {
            CreateMap<OrderedItem, OrderedItemResource>();
            CreateMap<OrderedItemResource, OrderedItem>();
        }
    }
}
