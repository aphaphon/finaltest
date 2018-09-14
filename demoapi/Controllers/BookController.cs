using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace demoapi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
         IEnumerable<Book> books = new List<Book>()
         {
             new Book{ id = "b01", name = "b01", price = 100 },
             new Book{ id = "b02", name = "b02", price = 200 },
             new Book{ id = "b03", name = "b03", price = 300 },
         };

        //getรายการหนังสือทั้งหมด
        [HttpGet]
        public IEnumerable<Book> GetAllBook()
        {
            return books;
        }

        //ดึงเฉพาะหนังสือจากชื่อหนังสือ
        //เพิ่มหนังสือใหม่
        //แก้ไขหนังสือ
        //ลบหนังสือจากรหัสหนังสือ
    }
}