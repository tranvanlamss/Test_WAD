﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Test_WAD.Models;

namespace Test_WAD.Controllers
{
    public class ClassRoomsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: ClassRooms
        public ActionResult Index()
        {
            return View(db.ClassRooms.ToList());
        }

        // GET: ClassRooms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassRoom classRoom = db.ClassRooms.Find(id);
            if (classRoom == null)
            {
                return HttpNotFound();
            }
            return View(classRoom);
        }

        // GET: ClassRooms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassRooms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Classroom")] ClassRoom classRoom)
        {
            if (ModelState.IsValid)
            {
                db.ClassRooms.Add(classRoom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(classRoom);
        }

        // GET: ClassRooms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassRoom classRoom = db.ClassRooms.Find(id);
            if (classRoom == null)
            {
                return HttpNotFound();
            }
            return View(classRoom);
        }

        // POST: ClassRooms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Classroom")] ClassRoom classRoom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classRoom).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classRoom);
        }

        // GET: ClassRooms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassRoom classRoom = db.ClassRooms.Find(id);
            if (classRoom == null)
            {
                return HttpNotFound();
            }
            return View(classRoom);
        }

        // POST: ClassRooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClassRoom classRoom = db.ClassRooms.Find(id);
            db.ClassRooms.Remove(classRoom);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
