﻿using OnlineStore.Domain.Entities;
using OnlineStore.Repstory.Repostory;
using OnlineStore.Service.CustomServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Service.Product
{
    public class CategoryService : ICustomService<Category>
    {
        private  IRepstory<Category> _repstory;

        public CategoryService(IRepstory<Category> repstory)
        {
            _repstory = repstory;
        }

        public void Delete(Category entity)
        {
           _repstory.Delete(entity);
        }

        public Category GetById(int Id)
        {
           return _repstory.GetById(Id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _repstory.GetAll();
        }

        public void Insert(Category entity)
        {
           _repstory.Insert(entity);
        }

        public void Update(Category entity)
        {
            _repstory.Update(entity);
        }
    }
}
