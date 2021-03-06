﻿//-----------------------------------------------------------------------
// <copyright file="ProductSearchResultViewModel.cs" company="Sitecore Corporation">
//     Copyright (c) Sitecore Corporation 1999-2016
// </copyright>
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

using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Sitecore.Diagnostics;
using Sitecore.Feature.Commerce.Catalog.Factories;
using Sitecore.Foundation.Commerce.Models;
using Sitecore.Foundation.SitecoreExtensions.Extensions;
using Sitecore.Mvc.Presentation;

namespace Sitecore.Feature.Commerce.Catalog.Models
{
    public class SearchResultViewModel
    {
        public SearchResultViewModel(SearchResults searchResult)
        {
            Assert.ArgumentNotNull(searchResult, nameof(searchResult));

            var productViewFactory = DependencyResolver.Current.GetService<ProductViewModelFactory>();
            var categoryViewFactory = DependencyResolver.Current.GetService<CategoryViewModelFactory>();

            Title = searchResult.Title;
            Items = new List<CatalogItemViewModel>();
            foreach (var child in searchResult.SearchResultItems)
            {
                CatalogItemViewModel productModel = null;
                if (child.IsDerived(Foundation.Commerce.Templates.Commerce.Product.Id))
                    productModel = productViewFactory.Create(child);
                if (child.IsDerived(Foundation.Commerce.Templates.Commerce.Category.Id))
                    productModel = categoryViewFactory.Create(child);
                if (productModel != null)
                    Items.Add(productModel);
            }
        }

        public List<CatalogItemViewModel> Items { get; set; }

        public string Title { get; set; }

    }
}