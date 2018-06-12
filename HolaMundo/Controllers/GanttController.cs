using System.Collections.Generic;
//using System.Data.Linq;
using System.Linq;
using System.Web.Mvc;
using HolaMundo.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using HolaMundo.Service;
using Datos;

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
            followupEntities context = new followupEntities();
            List<TaskViewModel> tasks = new List<TaskViewModel>();
            var queryPrograms = context.master_followup.ToList();
            int contador = 1;
            foreach (var item in queryPrograms)
            {
                if(item.start_date != null)
                {
                    TaskViewModel newRecord = new TaskViewModel();
                    newRecord.TaskID = (int)item.project_num;
                    newRecord.ParentID = null;
                    //newRecord.Thumbnail =
                    newRecord.Type = item.support_type!=null?item.support_type.support_name:string.Empty;
                    newRecord.Title = item.project_name;
                    newRecord.Site = item.site1!=null?item.site1.site_name:string.Empty;
                    newRecord.SeatClass = item.seat_class1!=null?item.seat_class1.seat_class_name:string.Empty;
                    newRecord.Customer = item.customer;
                    newRecord.Status = item.status1!=null?item.status1.status_name:string.Empty;
                    newRecord.PlannedBudget = item.planned_budget;
                    newRecord.ActualBudget = item.actual_budget;
                    newRecord.Start = (DateTime)item.start_date;
                    newRecord.End = (DateTime)item.end_date;
                    newRecord.Summary = false;
                    newRecord.Expanded = false;
                    newRecord.PercentComplete = Convert.ToDecimal(item.progress);
                    newRecord.OrderId = contador;
                    tasks.Add(newRecord);
                    contador++;
                }
            }
            var queryBricks = context.table_project_rd.ToList();
            foreach (var brick in queryBricks)
            {
                master_followup item = brick.master_followup;
                TaskViewModel newRecord = new TaskViewModel();
                newRecord.TaskID = (int)item.project_num;
                newRecord.ParentID = brick.id_project;
                //newRecord.Thumbnail =
                newRecord.Type = item.support_type != null ? item.support_type.support_name : string.Empty;
                newRecord.Title = item.project_name;
                newRecord.Site = item.site1 != null ? item.site1.site_name : string.Empty;
                newRecord.SeatClass = item.seat_class1 != null ? item.seat_class1.seat_class_name : string.Empty;
                newRecord.Customer = item.customer;
                newRecord.Status = item.status1 != null ? item.status1.status_name : string.Empty;
                newRecord.PlannedBudget = item.planned_budget;
                newRecord.ActualBudget = item.actual_budget;
                newRecord.Start = (DateTime)item.start_date;
                newRecord.End = (DateTime)item.end_date;
                newRecord.Summary = false;
                newRecord.Expanded = false;
                newRecord.PercentComplete = Convert.ToDecimal(item.progress);
                newRecord.OrderId = contador;
                tasks.Add(newRecord);
                contador++;
            }
            
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