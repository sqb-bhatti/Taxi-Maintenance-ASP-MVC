﻿using sb_admin_2.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sb_admin_2.Web.Domain
{
    public class Data
    {
        public IEnumerable<Navbar> navbarItems()
        {
            var menu = new List<Navbar>();
            menu.Add(new Navbar { Id = 1, nameOption = "Dashboard", controller = "Home", action = "Index", imageClass = "fa fa-dashboard fa-fw", status = true, isParent = false, parentId = 0 });
            menu.Add(new Navbar { Id = 22, nameOption = "Add New Taxi", controller = "Home", action = "TaxiDetails", imageClass = "fa fa-edit fa-fw", status = true, isParent = false, parentId = 0 });
            //menu.Add(new Navbar { Id = 23, nameOption = "Search Taxi", controller = "Home", action = "SearchTaxi", imageClass = "fa fa-edit fa-fw", status = true, isParent = false, parentId = 0 });
            //menu.Add(new Navbar { Id = 2, nameOption = "Charts", imageClass = "fa fa-bar-chart-o fa-fw", status = true, isParent = true, parentId = 0 });
            menu.Add(new Navbar { Id = 3, nameOption = "Flot Charts", controller = "Home", action = "FlotCharts", status = true, isParent = false, parentId = 2 });
            menu.Add(new Navbar { Id = 4, nameOption = "Morris.js Charts", controller = "Home", action = "MorrisCharts", status = true, isParent = false, parentId = 2 });
            menu.Add(new Navbar { Id = 5, nameOption = "Search Taxi", controller = "Home", action = "Tables", imageClass = "fa fa-table fa-fw", status = true, isParent = false, parentId = 0 });
            //menu.Add(new Navbar { Id = 6, nameOption = "Forms", controller = "Home", action = "Forms", imageClass = "fa fa-edit fa-fw", status = true, isParent = false, parentId = 0 });
            //menu.Add(new Navbar { Id = 7, nameOption = "UI Elements", imageClass = "fa fa-wrench fa-fw", status = true, isParent = true, parentId = 0 });
            //menu.Add(new Navbar { Id = 8, nameOption = "Panels and Wells", controller = "Home", action = "Panels", status = true, isParent = false, parentId = 7 });
            //menu.Add(new Navbar { Id = 9, nameOption = "Buttons", controller = "Home", action = "Buttons", status = true, isParent = false, parentId = 7 });
            //menu.Add(new Navbar { Id = 10, nameOption = "Notifications", controller = "Home", action = "Notifications", status = true, isParent = false, parentId = 7 });
            //menu.Add(new Navbar { Id = 11, nameOption = "Typography", controller = "Home", action = "Typography", status = true, isParent = false, parentId = 7 });
            //menu.Add(new Navbar { Id = 12, nameOption = "Icons", controller = "Home", action = "Icons", status = true, isParent = false, parentId = 7 });
            //menu.Add(new Navbar { Id = 13, nameOption = "Grid", controller = "Home", action = "Grid", status = true, isParent = false, parentId = 7 });
            //menu.Add(new Navbar { Id = 14, nameOption = "Multi-Level Dropdown", imageClass = "fa fa-sitemap fa-fw", status = true, isParent = true, parentId = 0 });
            //menu.Add(new Navbar { Id = 15, nameOption = "Second Level Item", status = true, isParent = false, parentId = 14 });
            //menu.Add(new Navbar { Id = 16, nameOption = "Sample Pages", imageClass = "fa fa-files-o fa-fw", status = true, isParent = true, parentId = 0 });
            menu.Add(new Navbar { Id = 17, nameOption = "Blank Page", controller = "Home", action = "Blank", status = true, isParent = false, parentId = 16 });
            menu.Add(new Navbar { Id = 18, nameOption = "Login Page", controller = "Home", action = "Login", status = true, isParent = false, parentId = 16 });

            menu.Add(new Navbar { Id = 19, nameOption = "Maintenance Selection", imageClass = "fa fa-bar-chart-o fa-fw", status = true, isParent = true, parentId = 0 });
            menu.Add(new Navbar { Id = 20, nameOption = "Preventive Maintenance", controller = "Home", action = "SiteTaxiDetails", status = true, isParent = false, parentId = 19 });
            menu.Add(new Navbar { Id = 21, nameOption = "Corrective Maintenance", controller = "Home", action = "CSiteTaxiDetails", status = true, isParent = false, parentId = 19 });

            
            return menu.ToList();
        }
    }
}