using System.Collections.Generic;
//using System.Data.Linq;
using System.Linq;
using System.Web.Mvc;
using HolaMundo.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using HolaMundo.Service;

namespace HolaMundo.Controllers
{
    public partial class GanttController : Controller
    {
        private ShowGantService taskService;
        private DependencyViewModel dependencyService;
        //private GanttAssignmentService assignmentService;
        //private GanttResourceService resourceService;

        public GanttController()
        {
            taskService = new ShowGantService();
            dependencyService = new DependencyViewModel();
            //assignmentService = new GanttAssignmentService();
            //resourceService = new GanttResourceService();
        }

        //protected override void Dispose(bool disposing)
        //{
        //    taskService.Dispose();
        //    dependencyService.Dispose();

        //    base.Dispose(disposing);
        //}
        
        public ActionResult ShowGantt()
        {
            return View();
        }

        public JsonResult Tasks([DataSourceRequest] DataSourceRequest request)
        {
            var tasks = new List<TaskViewModel> {
            new TaskViewModel { TaskID = 1, Title = "My Project", Start = new DateTime(2014,8,21,11,00,00), End = new DateTime(2014,8,25,18,30,00), Summary = true, Expanded = true, ParentID = null, OrderId = 1 },
            new TaskViewModel { TaskID = 2, ParentID = 1, Title = "Task 1", Start = new DateTime(2014,8,21,11,00,00), End = new DateTime(2014,8,23,14,30,00), OrderId = 2 },
            new TaskViewModel { TaskID = 3, ParentID = 1, Title = "Task 2", Start = new DateTime(2014,8,21,15,00,00), End = new DateTime(2014,8,25,18,00,00), OrderId = 3 }
        };

            return Json(tasks.AsQueryable().ToDataSourceResult(request));
        }

        public JsonResult Dependencies([DataSourceRequest] DataSourceRequest request)
        {
            var dependencies = new List<DependencyViewModel> {
            new DependencyViewModel { DependencyID = 100, PredecessorID = 2, SuccessorID = 3, Type = 0 }
        };

            return Json(dependencies.AsQueryable().ToDataSourceResult(request));
        }

        //public virtual JsonResult Read_Tasks([DataSourceRequest] DataSourceRequest request)
        //{
        //    return Json(taskService.GetAll().ToDataSourceResult(request));
        //}

        //public virtual JsonResult Destroy_Task([DataSourceRequest] DataSourceRequest request, TaskViewModel task)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        taskService.Delete(task, ModelState);
        //    }

        //    return Json(new[] { task }.ToDataSourceResult(request, ModelState));
        //}

        //public virtual JsonResult Create_Task([DataSourceRequest] DataSourceRequest request, TaskViewModel task)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        taskService.Insert(task, ModelState);
        //    }

        //    return Json(new[] { task }.ToDataSourceResult(request, ModelState));
        //}

        //public virtual JsonResult Update_Task([DataSourceRequest] DataSourceRequest request, TaskViewModel task)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        taskService.Update(task, ModelState);
        //    }

        //    return Json(new[] { task }.ToDataSourceResult(request, ModelState));
        //}

        //public virtual JsonResult Read_Dependencies([DataSourceRequest] DataSourceRequest request)
        //{
        //    return Json(dependencyService.GetAll().ToDataSourceResult(request));
        //}

        //public virtual JsonResult Destroy_Dependency([DataSourceRequest] DataSourceRequest request, DependencyViewModel dependency)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        dependencyService.Delete(dependency, ModelState);
        //    }

        //    return Json(new[] { dependency }.ToDataSourceResult(request, ModelState));
        //}

        //public virtual JsonResult Create_Dependency([DataSourceRequest] DataSourceRequest request, DependencyViewModel dependency)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        dependencyService.Insert(dependency, ModelState);
        //    }

        //    return Json(new[] { dependency }.ToDataSourceResult(request, ModelState));
        //}
    }
}