﻿using Eng.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng.Domain.Interfaces
{
	public interface ICategoryRepository
	{
		Task<IEnumerable<Category>> GetCatories();
		Task<Category> GetById(int? id);

		Task<Category> Create(Category category);
		Task<Category> Update(Category category);
		Task<Category> Remove(Category category);
	}
}