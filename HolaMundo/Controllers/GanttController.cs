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
            //    var tasks = new List<TaskViewModel> {
            //    new TaskViewModel { TaskID = 6, Title = "My Project 1", Start = new DateTime(2014,8,21,11,00,00), End = new DateTime(2014,8,25,18,30,00), Summary = true, Expanded = true, ParentID = null, OrderId = 1 },
            //    new TaskViewModel { TaskID = 1, ParentID = 6, Title = "Task 1", Start = new DateTime(2014,8,21,11,00,00), End = new DateTime(2014,8,23,14,30,00), OrderId = 2 },
            //    new TaskViewModel { TaskID = 10, ParentID = 6, Title = "Task 2", Start = new DateTime(2014,8,21,15,00,00), End = new DateTime(2014,8,25,18,00,00), OrderId = 3 },
            //    new TaskViewModel { TaskID = 6, Title = "My Project 2", Start = new DateTime(2014,8,21,11,00,00), End = new DateTime(2014,8,25,18,30,00), Summary = true, Expanded = true, ParentID = null, OrderId = 4 },
            //    new TaskViewModel { TaskID = 9, ParentID = 7, Title = "Task 1", Start = new DateTime(2014,8,21,11,00,00), End = new DateTime(2014,8,23,14,30,00), OrderId = 5 },
            //    new TaskViewModel { TaskID = 11, ParentID = 6, Title = "Task 2", Start = new DateTime(2014,8,21,15,00,00), End = new DateTime(2014,8,25,18,00,00), OrderId = 6 }
            //};

            var queryPrograms = context.master_followup.Where(p => p.type_project == 1).ToList();
            int contador = 1;
            foreach (var item in queryPrograms)
            {
                if (item.start_date != null)
                {
                    TaskViewModel newRecord = new TaskViewModel();
                    newRecord.TaskID = item.id_project;
                    newRecord.ProjectNum = (int)item.project_num;
                    //newRecord.ParentID = null;
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
                    newRecord.Summary = true;
                    newRecord.Expanded = true;
                    newRecord.PercentComplete = Convert.ToDecimal(item.progress) / 100;
                    newRecord.OrderId = contador;// (int)item.project_num;
                    tasks.Add(newRecord);
                    contador++;
                    if (item.table_project_rd.Count() > 0)
                    {
                        var x = item.table_project_rd;
                    }

                    if (item.table_project_rd1.Count() > 0)
                    {
                        var e = item.table_project_rd1;
                    }
                    if (item.table_project_tecno_bricks.Count() > 0)
                    {
                        var TBricks = item.table_project_tecno_bricks;
                        foreach (var tBrick in TBricks)
                        {
                            tecno_bricks i = tBrick.tecno_bricks;
                            TaskViewModel newRecordt = new TaskViewModel();
                            newRecordt.TaskID = i.id_tecno_brick;
                            newRecordt.ProjectNum = (int)i.brick_num;
                            newRecordt.ParentID = tBrick.id_project;
                            //newRecordt.Thumbnail =
                            newRecordt.Type = i.support_type != null ? item.support_type.support_name : string.Empty;
                            newRecordt.Title = i.project_name;
                            newRecordt.Site = i.site1 != null ? item.site1.site_name : string.Empty;
                            newRecordt.SeatClass = i.seat_class1 != null ? item.seat_class1.seat_class_name : string.Empty;
                            newRecordt.Customer = string.Empty;
                            newRecordt.Status = i.status1 != null ? item.status1.status_name : string.Empty;
                            newRecordt.PlannedBudget = i.plan_budget;
                            newRecordt.ActualBudget = i.actual_budget;
                            newRecordt.Start = (DateTime)i.start_date;
                            newRecordt.End = (DateTime)i.end_date;
                            //newRecordt.Summary = true;
                            //newRecordt.Expanded = false;
                            newRecordt.PercentComplete = 0;
                            newRecordt.OrderId = contador;//i.id_tecno_brick; ;
                            tasks.Add(newRecordt);
                            contador++;
                        }
                    }
                }
            }
            //var queryBricks = context.table_project_rd.ToList();
            //foreach (var brick in queryBricks)
            //{
            //    master_followup item = brick.master_followup;
            //    TaskViewModel newRecord = new TaskViewModel();
            //    newRecord.TaskID = item.id_project;
            //    newRecord.ProjectNum = (int)item.project_num;
            //    newRecord.ParentID = brick.id_project;
            //    //newRecord.Thumbnail =
            //    newRecord.Type = item.support_type != null ? item.support_type.support_name : string.Empty;
            //    newRecord.Title = item.project_name;
            //    newRecord.Site = item.site1 != null ? item.site1.site_name : string.Empty;
            //    newRecord.SeatClass = item.seat_class1 != null ? item.seat_class1.seat_class_name : string.Empty;
            //    newRecord.Customer = item.customer;
            //    newRecord.Status = item.status1 != null ? item.status1.status_name : string.Empty;
            //    newRecord.PlannedBudget = item.planned_budget;
            //    newRecord.ActualBudget = item.actual_budget;
            //    newRecord.Start = (DateTime)item.start_date;
            //    newRecord.End = (DateTime)item.end_date;
            //    newRecord.Summary = false;
            //    newRecord.Expanded = false;
            //    newRecord.PercentComplete = Convert.ToDecimal(item.progress)/100;
            //    newRecord.OrderId = contador;
            //    tasks.Add(newRecord);
            //    contador++;
            //}

            //var queryTBricks = context.table_project_tecno_bricks.ToList();
            //foreach (var tBrick in queryTBricks)
            //{
            //    tecno_bricks item = tBrick.tecno_bricks;
            //    TaskViewModel newRecord = new TaskViewModel();
            //    newRecord.TaskID = item.id_tecno_brick;
            //    newRecord.ProjectNum = (int)item.brick_num;
            //    newRecord.ParentID = tBrick.id_project;
            //    //newRecord.Thumbnail =
            //    newRecord.Type = item.support_type != null ? item.support_type.support_name : string.Empty;
            //    newRecord.Title = item.project_name;
            //    newRecord.Site = item.site1 != null ? item.site1.site_name : string.Empty;
            //    newRecord.SeatClass = item.seat_class1 != null ? item.seat_class1.seat_class_name : string.Empty;
            //    newRecord.Customer = string.Empty;
            //    newRecord.Status = item.status1 != null ? item.status1.status_name : string.Empty;
            //    newRecord.PlannedBudget = item.plan_budget;
            //    newRecord.ActualBudget = item.actual_budget;
            //    newRecord.Start = (DateTime)item.start_date;
            //    newRecord.End = (DateTime)item.end_date;
            //    newRecord.Summary = false;
            //    newRecord.Expanded = false;
            //    newRecord.PercentComplete = Convert.ToDecimal(100) / 100;
            //    newRecord.OrderId = contador;
            //    tasks.Add(newRecord);
            //    contador++;
            //}

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