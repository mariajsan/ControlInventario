﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ControlInventario.Models;

namespace ControlInventario.Controllers
{
    [Authorize]
    public class proveedoresController : Controller
    {
        private proveedorescontextdb db = new proveedorescontextdb();

        // GET: proveedores
        public ActionResult Index()
        {
            return View(db.Proveedor.ToList());
        }

        // GET: proveedores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            proveedores proveedores = db.Proveedor.Find(id);
            if (proveedores == null)
            {
                return HttpNotFound();
            }
            return View(proveedores);
        }

        // GET: proveedores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: proveedores/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "supplierId,supplierCode,supplierName,Email,Phone,Address")] proveedores proveedores)
        {
            if (ModelState.IsValid)
            {
                db.Proveedor.Add(proveedores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(proveedores);
        }

        // GET: proveedores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            proveedores proveedores = db.Proveedor.Find(id);
            if (proveedores == null)
            {
                return HttpNotFound();
            }
            return View(proveedores);
        }

        // POST: proveedores/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "supplierId,supplierCode,supplierName,Email,Phone,Address")] proveedores proveedores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proveedores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(proveedores);
        }

        // GET: proveedores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            proveedores proveedores = db.Proveedor.Find(id);
            if (proveedores == null)
            {
                return HttpNotFound();
            }
            return View(proveedores);
        }

        // POST: proveedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            proveedores proveedores = db.Proveedor.Find(id);
            db.Proveedor.Remove(proveedores);
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