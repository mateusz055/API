using Core.Interfaces;
using Core.Interfaces.Services;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class FileService : IFileService
    {
        private readonly IFileRepository _fileRepository;
        public FileService(IFileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }

        public async Task<List<File>> GetAll()
        {
            return await _fileRepository.GetAll();
        }
    }
}
