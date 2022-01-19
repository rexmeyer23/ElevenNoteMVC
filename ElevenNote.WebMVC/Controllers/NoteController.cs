using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.WebMVC.Controllers
{
    [Authorize] //makes views accessible only to logged in users
    public class NoteController : Controller
    {
        // GET: Note
        public ActionResult Index()
        {
            var model = new NoteListItem[0];
            return View(model);
        }
        // In the code above, we are initializing a new instance of the NoteListItem as an IEnumerable with the [0] syntax. This will satisfy some of the requirements for our Index View. When we added the List template for our view, it created some IEnumerable requirements for our list view. 
    }
}