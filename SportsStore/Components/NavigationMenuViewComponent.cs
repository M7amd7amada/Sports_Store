// Copyright (c) 2023 Mohammed Hamada, GitHub: M7amd7amada.
// Licensed under MIT license. See LICENSE file in the project root for license information.

using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Components;


public class NavigationMenuViewComponent : ViewComponent
{
    private IStoreRepository repository;

    public NavigationMenuViewComponent(IStoreRepository repo)
    {
        repository = repo;
    }

    public IViewComponentResult Invoke()
    {
        ViewBag.SelectedCategory = RouteData?.Values["category"];
        return View(repository.Products
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x));
    }
}
