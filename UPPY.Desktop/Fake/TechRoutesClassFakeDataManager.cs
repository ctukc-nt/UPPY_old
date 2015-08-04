﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;

namespace UPPY.Desktop.Fake
{
    public class TechRoutesClassFakeDataManager : List<TechRoute>, IClassDataManager<TechRoute>
    {
        public TechRoutesClassFakeDataManager()
        {
            Add(new TechRoute()
            {
                Id = 1,
                Name = "A - B",
                TechOperations = new List<TechOperation>()
                        {
                            new TechOperation() {Id = 1, ShortName = "A"},
                            new TechOperation() {Id = 2, ShortName = "B"},
                        }
            });

            Add(new TechRoute()
            {
                Id = 2,
                Name = "B - C",
                TechOperations = new List<TechOperation>()
                        {
                            new TechOperation() {Id = 2, ShortName = "B"},
                            new TechOperation() {Id = 3, ShortName = "C"},
                        }
            });
        }

        private int _count = 0;

        public Task<List<TechRoute>> GetListCollectionAsync()
        {
            return new Task<List<TechRoute>>(() => this);
        }
        public List<TechRoute> GetListCollection()
        {
            return this;
        }

        public void Insert(TechRoute doc)
        {
            Add(doc);
            doc.Id = _count++;
        }

        public void InsertAsync(TechRoute doc)
        {
            Insert(doc);
        }

        public void Update(TechRoute doc)
        {

        }

        public void UpdateAsync(TechRoute doc)
        {

        }

        public void Delete(TechRoute doc)
        {
            Remove(doc);
        }

        public void DeleteAsync(TechRoute doc)
        {
            Remove(doc);
        }

        public void InsertOrUpdate(TechRoute doc)
        {
            if (doc.Id != null)
                Update(doc);
            else
            {
                Insert(doc);
            }
        }

        public TechRoute GetDocument(int? id)
        {
            return this.FirstOrDefault(x => x.Id == id);
        }

        public Task<TechRoute> GetDocumentAsync(int? id)
        {
            return new Task<TechRoute>(() => GetDocument(id));
        }

        public List<TechRoute> FindInDbDirectly(Func<TechRoute, bool> id)
        {
            throw new NotImplementedException();
        }

       
    }
}