﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryService _categoryService;
		private readonly IMapper _mapper;

		public CategoryController(ICategoryService categoryService, IMapper mapper)
		{
			_categoryService = categoryService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult CategoryList()
		{
			var values = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
			return Ok(values);
		}

		[HttpGet("CategoryCount")]
		public IActionResult CategoryCount()
		{
			return Ok(_categoryService.TCategoryCount());
		}

		[HttpGet("ActiveCategoryCount")]
		public IActionResult ActiveCategoryCount()
		{
			return Ok(_categoryService.TActiveCategoryCount());
		}

		[HttpGet("PassiveCategoryCount")]
		public IActionResult PassiveCategoryCount()
		{
			return Ok(_categoryService.TPassiveCategoryCount());
		}

		[HttpPost]
		public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
		{
			Category category = new Category()
			{
				CategoryName = createCategoryDto.CategoryName,
				Status = createCategoryDto.Status,
			};

			_categoryService.TAdd(category);
			return Ok("Kategori kısmı başarılı bir şekilde eklendi.");
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteCategory(int id)
		{
			var value = _categoryService.TGetByID(id);
			_categoryService.TDelete(value);
			return Ok("Kategori Alanı Silindi.");
		}

		[HttpPut]
		public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
		{
			Category category = new Category()
			{
				CategoryID = updateCategoryDto.CategoryID,
				CategoryName = updateCategoryDto.CategoryName,
				Status = updateCategoryDto.Status,
			};
			_categoryService.TUpdate(category);
			return Ok("Kategori alanı güncellendi.");
		}

		[HttpGet("{id}")]
		public IActionResult GetCategory(int id)
		{
			var value = _categoryService.TGetByID(id);
			return Ok(value);
		}
	}
}
