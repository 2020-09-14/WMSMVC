using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WMSMvc.Controllers
{
    public class InventoryController : Controller
    {
        /// <summary>
        /// 查询显示仓库
        /// </summary>
        /// <returns></returns>
        public IActionResult ShowInventory()
        {
            return View();
        }
        /// <summary>
        /// 添加仓库
        /// </summary>
        /// <returns></returns>
        public IActionResult AddInventory()
        {
            return View();
        }
        /// <summary>
        /// 查询显示仓库库区
        /// </summary>
        /// <returns></returns>
        public IActionResult ShowReservoirArea()
        {
            return View();
        }
        public IActionResult Alarm()
        {
            return View();
        }
        /// <summary>
        /// 查询显示仓库库区库位
        /// </summary>
        /// <returns></returns>
        public IActionResult ShowGoodsAllocation()
        {
            return View();
        }
        /// <summary>
        /// 仓库管理权限
        /// </summary>
        /// <returns></returns>
        public IActionResult ShowWareHouseKeeperlist()
        {
            return View();
        }
        /// <summary>
        /// 库管员权限
        /// </summary>
        /// <returns></returns>
        public IActionResult GetWareHouseKeeper()
        {
            return View();
        }
    }
}
