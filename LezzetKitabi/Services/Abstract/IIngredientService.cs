﻿using LezzetKitabi.Domain.Dtos.IngredientDtos;
using LezzetKitabi.Domain.Entities;
using LezzetKitabi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezzetKitabi.Services.Abstract
{
    public interface IIngredientService
    {
        bool AddIngredient(IngredientAddDto ingredientAddDto);
        bool DeleteIngredient(Guid id);
        Task<IngredientGetDto?> GetIngredientByIdAsync(Guid id);
        Task<bool> UpdateIngredientAsync(IngredientUpdateDto ingredient);
        Task<List<Ingredient>> GetAllIngredientsByOrderAndFilterAsync(IngredientSortingType sortingType, List<FilterCriteria> filterCriteriaList = null, int page = -1);


    }
}
