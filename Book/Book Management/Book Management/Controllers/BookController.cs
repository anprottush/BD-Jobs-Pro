using Book_Management.DTOs;
using Book_Management.Models;
using Book_Management.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Book_Management.Controllers
{
    [EnableCors("*", "*", "*")] //universal url, universal method, universal headers
    public class BookController : ApiController
    {
        [Route("api/book/all")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = BookService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/book/all/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = BookService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/book/add")]
        [HttpPost]
        public HttpResponseMessage Insert(BookDto book) 
        {
            var data = BookService.Insert(book); 
            if (data!=null)
            {
                return Request.CreateResponse(HttpStatusCode.OK,"Book Insert");
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }

        [Route("api/book/delete/{ID}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id) 
        {
            var data = BookService.Delete(id);
            if (data)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Book delete");
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }
        [Route("api/book/update")] 
        [HttpPost]
        public HttpResponseMessage Update(BookDto book) 
        {
            BookService.Update(book);
            //if (data)
            //{
                return Request.CreateResponse(HttpStatusCode.OK, "Book Update");
            //}
            //return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }
    }
}
