﻿//-----------------------------------------------------------------------
// <copyright file="CartModel.cs" company="Sitecore Corporation">
//     Copyright (c) Sitecore Corporation 1999-2016
// </copyright>
// <summary>Sitecore redering class for the CommerceCart.</summary>
//-----------------------------------------------------------------------
// Copyright 2016 Sitecore Corporation A/S
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
// except in compliance with the License. You may obtain a copy of the License at
//       http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the 
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, 
// either express or implied. See the License for the specific language governing permissions 
// and limitations under the License.
// -------------------------------------------------------------------------------------------

using Sitecore.Commerce.Connect.CommerceServer.Orders.Models;
using Sitecore.Mvc.Presentation;

namespace Sitecore.Feature.Commerce.Orders.Models
{
    public class CartViewModel
    {
        public CartViewModel(CommerceCart cart)
        {
            Cart = cart;
        }

        public CommerceCart Cart { get; set; }
    }
}