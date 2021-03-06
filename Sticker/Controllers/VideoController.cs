﻿using System.Collections.Generic;
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
        #region Private Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly VideoViewModelFactory _viewModelFactory;
        private readonly VideoEntityFactory _entityFactory;

        #endregion
        
        #region Constructor

        public VideoController(IUnitOfWork unitOfWork, VideoViewModelFactory viewModelFactory,
            VideoEntityFactory entityFactory)
        {
            _unitOfWork = unitOfWork;
            _viewModelFactory = viewModelFactory;
            _entityFactory = entityFactory;
        }

        #endregion
        
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
                Video entity = _entityFactory.CreateFrom(viewModel);

                _unitOfWork.VideosRepository.Add(entity);

                _unitOfWork.Complete();

                return RedirectToAction("List");
            }
            else
            {
                // there are validation errors...
                return View();
            }
        }

        public ActionResult List(string filterTerm = null)
        {
            IEnumerable<Video> existingVideosInDb = 
                _unitOfWork.VideosRepository.GetAll()
                .Where(v => filterTerm.IsNullOrWhiteSpace() || v.Name.ToLower().Contains(filterTerm.ToLower()))
                .OrderByDescending(video => video.Comments?.Count);

            List<VideoViewModel> videos = _viewModelFactory.CreateFrom(existingVideosInDb);

            return View("List", videos);
        }
    }
}