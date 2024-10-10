﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LezzetKitabi.Data.Repositories.Abstract;
using LezzetKitabi.Domain.Dtos.IngredientDtos;
using LezzetKitabi.Domain.Entities;
using LezzetKitabi.Services.Abstract;

namespace LezzetKitabi.Application.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientService(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }
    }
}
