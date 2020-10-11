﻿using KNU.IT.DbManagementSystem.Models;
using KNU.IT.DbManager.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KNU.IT.DbManagementSystem.Services.RowService
{
    public interface IRowService
    {
        Task<Row> GetAsync(Guid id);
        Task CreateAsync(Row row);
        Task UpdateAsync(Row row);
        Task DeleteAsync(Guid id);
        Task<List<RowViewModel>> GetAllViewModelsByTableAsync(Guid tableId);
    }
}