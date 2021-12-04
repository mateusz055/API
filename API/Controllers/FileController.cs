using Core.Interfaces.Services;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : Controller
    {
        private readonly IFileService _fileService;
        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }
        [HttpGet("get")]
        public async Task<IEnumerable<File>> Get()
        {
            return await _fileService.GetAll();
            
            
        }
    }
} 
    

