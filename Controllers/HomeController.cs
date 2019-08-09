using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chart.Models;

namespace Chart.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult<List<ChartModel>> GetLineData(){
            ChartModel data1 = new ChartModel
            {
                Count = 20,
                Month = "January"
            };
            ChartModel data2 = new ChartModel
            {
                Count = 40,
                Month = "January"
            };
            ChartModel data3 = new ChartModel
            {
                Count = 80,
                Month = "January"
            };

            List<ChartModel> charts = new List<ChartModel>
            {
                data1,
                data2,
                data3
            };

            return charts;
        }

        //TODO: to get bar data
            //TODO: create new Chart model
        public ActionResult<List<BarModel>> GetBarData()
        {
            BarModel data1 = new BarModel
            {
                Count = 10,
                Month = "January"
            };
            BarModel data2 = new BarModel
            {
                Count = 10,
                Month = "January"
            };
            BarModel data3 = new BarModel
            {
                Count = 10,
                Month = "January"
            };
            List<BarModel> charts = new List<BarModel>
            {
                data1,
                data2,
                data3
            };
            return charts;
        }
        //TODO: to get pie data
        //TODO: create new pie model
        public ActionResult<List<PieModel>> GetPieData()
        {
            PieModel data1 = new PieModel
            {
                Count = 10,
                Month = "January"
            };
            PieModel data2 = new PieModel
            {
                Count = 10,
                Month = "January"
            };
            PieModel data3 = new PieModel
            {
                Count = 10,
                Month = "January"
            };
            List<PieModel> charts = new List<PieModel>
            {
                data1,
                data2,
                data3
            };
            return charts;
        }
        public ActionResult<List<BubbleModel>> GetBubbleData()
        {
            BubbleModel data1 = new BubbleModel
            {
                Count = new Count
                {
                    X = 20,
                    Y = 30,
                    R = 10
                },
                Month = "January"
            };
            BubbleModel data2 = new BubbleModel
            {
                Count = new Count
                {
                    X = 20,
                    Y = 20,
                    R = 2
                },
                Month = "January"
            };
            BubbleModel data3 = new BubbleModel
            {
                Count = new Count
                {
                    X = 0,
                    Y = 0,
                    R = 20
                },
                Month = "January"
            };
            List<BubbleModel> charts = new List<BubbleModel>
            {
                data1,
                data2,
                data3
            };
            return charts;
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
