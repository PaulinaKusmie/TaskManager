using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ManagerTask.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManagerTask.Controllers
{
    public class TaskController : Controller
    {

        private static IList<TaskModel> tasks = new List<TaskModel>()
        {

        new TaskModel() {TaskId = 1, Name = "Zadzwonić do klienta", Description = "godzina 14:00", Done = false},

        new TaskModel() {TaskId = 2, Name = "Wizyta u lekarza", Description = "godzina 17:00", Done = false},

        new TaskModel() {TaskId = 3, Name = "Odebrać męża", Description = "godzina 21:00", Done = false}

        };

        // GET: TaskController
        public ActionResult Index()
        {
            return View(tasks);
        }

        // GET: TaskController/Details/5
        public ActionResult Details(int id)
        {
            return View(tasks.FirstOrDefault(x => x.TaskId == id));
        }

        // GET: TaskController/Create
        public ActionResult Create()
        {
            return View(new TaskModel());

        }

        // POST: TaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TaskModel taskModel)
        {
            taskModel.TaskId = tasks.Count + 1;
            tasks.Add(taskModel);
            return RedirectToAction(nameof(Index));
            
        }

        // GET: TaskController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(tasks.FirstOrDefault(x => x.TaskId == id));
        }

        // POST: TaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TaskModel taskModel)
        {
            TaskModel task = tasks.FirstOrDefault(x => x.TaskId == id);
            task.Name = taskModel.Name;
            return RedirectToAction(nameof(Index));
          
        }

        // GET: TaskController/Delete/5
        public ActionResult Delete(int id)
        {
           
           
            return View(tasks.FirstOrDefault(x => x.TaskId == id));
        }

        // POST: TaskController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TaskModel taskMode)
        {
            TaskModel task = tasks.FirstOrDefault(x => x.TaskId == id);
            tasks.Remove(task);
            return RedirectToAction(nameof(Index));
           
               
        }
        //GET: Task/Done/5
        //public ActionResult Done(int id)
       
    }
}
