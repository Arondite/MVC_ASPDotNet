using System;
using PagedList;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Assignment4.DAL;
using MVC_Assignment4.Models;
using MVC_Assignment4.ViewModels;

namespace MVC_Assignment4.Controllers
{
    public class MusicGenreController : Controller
    {
        private AlbumContext db = new AlbumContext();

        // GET: MusicGenre
        public ActionResult Index(string sortOrder, string currentFilter, int? page)
        {
			ViewBag.GenreSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
			var musicGenre = from g in db.MusicGenre
							 select g;
			switch (sortOrder)
			{
				case "name_desc":
					musicGenre = musicGenre.OrderByDescending(g => g.GenreType);
					break;
				default:
					musicGenre = musicGenre.OrderBy(g => g.GenreType);
					break;
			}
			int pageSize = 2;
			int pageNumber = (page ?? 1);
            return View(musicGenre.ToPagedList(pageNumber, pageSize));
        }

        // GET: MusicGenre/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
			//MusicGenre musicGenre = db.MusicGenre.Find(id);
			var musicGenre = db.MusicGenre.Find(id).Album.Id;
			var artistGenre = new ArtistGenre()
			{
				Artist = db.Album.Where(a => a.Id == musicGenre).Select(a => a.Artist).Single(),
				Genre = db.MusicGenre.Where(g => g.Album.Id == musicGenre).ToList()
			};
            if (musicGenre < 1)
            {
                return HttpNotFound();
            }
            return View(artistGenre);
        }

        // GET: MusicGenre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MusicGenre/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MusicGenreId,GenreType")] MusicGenre musicGenre)
        {
            if (ModelState.IsValid)
            {
                db.MusicGenre.Add(musicGenre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(musicGenre);
        }

        // GET: MusicGenre/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusicGenre musicGenre = db.MusicGenre.Find(id);
            if (musicGenre == null)
            {
                return HttpNotFound();
            }
            return View(musicGenre);
        }

        // POST: MusicGenre/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MusicGenreId,GenreType")] MusicGenre musicGenre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(musicGenre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(musicGenre);
        }

        // GET: MusicGenre/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusicGenre musicGenre = db.MusicGenre.Find(id);
            if (musicGenre == null)
            {
                return HttpNotFound();
            }
            return View(musicGenre);
        }

        // POST: MusicGenre/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MusicGenre musicGenre = db.MusicGenre.Find(id);
            db.MusicGenre.Remove(musicGenre);
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
