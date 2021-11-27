using Core.Models;
using Core.Repository.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IFileRepository
    {
        async Task<List<File>> GetAll();
    }
}
