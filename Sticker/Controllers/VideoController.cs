using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Sticker.DataAccess;
using Sticker.DataAccess.Entities;
using Sticker.Models;
using Sticker.Models.Factories;

namespace Sticker.Controllers
{
    public class VideoController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public VideoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(VideoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.VideosRepository.Add(viewModel.ToEntityModel());

                _unitOfWork.Complete();

                return RedirectToAction("List");
            }
            else
            {
                // there are validation errors...
                return View();
            }
        }

        public ActionResult List(string filter = null)
        {
            IEnumerable<Video> existingVideosInDb = _unitOfWork.VideosRepository.GetAll()
                .Where(v => filter.IsNullOrWhiteSpace() || v.Name.ToLower().Contains(filter.ToLower()))
                .OrderByDescending(video => video.Comments?.Count);

            List<VideoViewModel> videos = existingVideosInDb.ToViewModel();

            return View("List", videos);
        }
    }
}