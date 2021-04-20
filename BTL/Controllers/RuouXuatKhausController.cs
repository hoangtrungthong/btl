using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BTL.Models;

namespace BTL.Controllers
{
    public class RuouXuatKhausController : Controller
    {
        private KhoDbContext db = new KhoDbContext();

        // GET: RuouXuatKhaus
        public ActionResult Index()
        {
            return View(db.RuouXuatKhaus.ToList());
        }

        // GET: RuouXuatKhaus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RuouXuatKhau ruouXuatKhau = db.RuouXuatKhaus.Find(id);
            if (ruouXuatKhau == null)
            {
                return HttpNotFound();
            }
            return View(ruouXuatKhau);
        }

        // GET: RuouXuatKhaus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RuouXuatKhaus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDRuou,TenRuou,NongDo,SoLuong,DonVi_Chai,DanhGia,TinhChat,NguonGoc,DonGia,NguoiXuat,NguoiNhap")] RuouXuatKhau ruouXuatKhau)
        {
            if (ModelState.IsValid)
            {
                db.KhoRuous.Add(ruouXuatKhau);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ruouXuatKhau);
        }

        // GET: RuouXuatKhaus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RuouXuatKhau ruouXuatKhau = db.RuouXuatKhaus.Find(id);
            if (ruouXuatKhau == null)
            {
                return HttpNotFound();
            }
            return View(ruouXuatKhau);
        }

        // POST: RuouXuatKhaus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDRuou,TenRuou,NongDo,SoLuong,DonVi_Chai,DanhGia,TinhChat,NguonGoc,DonGia,NguoiXuat,NguoiNhap")] RuouXuatKhau ruouXuatKhau)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ruouXuatKhau).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ruouXuatKhau);
        }

        // GET: RuouXuatKhaus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RuouXuatKhau ruouXuatKhau = db.RuouXuatKhaus.Find(id);
            if (ruouXuatKhau == null)
            {
                return HttpNotFound();
            }
            return View(ruouXuatKhau);
        }

        // POST: RuouXuatKhaus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RuouXuatKhau ruouXuatKhau = db.RuouXuatKhaus.Find(id);
            db.KhoRuous.Remove(ruouXuatKhau);
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
