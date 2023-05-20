using AutoMapper;
using Book_Management.DTOs;
using Book_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Book_Management.Services
{
    public class BookService
    {
        public static BookDto Insert(BookDto data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<BookDto, Book>();
                c.CreateMap<Book, BookDto>();
            });
            var mapper = new Mapper(config);
            var dbobj = mapper.Map<Book>(data);
            var ret = DataAccessFactory.BookDataAccess().Insert(dbobj);
            if (ret != null)
            {
                return mapper.Map<BookDto>(data);
            }
            else
            {
                return null;
            }


        }
        //public static object GetAll()
        // {
        //throw new NotImplementedException();
        //}
        public static List<BookDto> Get()   //chnage3
        {

            var dbdata = DataAccessFactory.BookDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Book, BookDto>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<BookDto>>(dbdata);  //List convert data by list

            return data;
        }

        public static BookDto Get(int id)       //chnage2
        {
            var data = DataAccessFactory.BookDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Book, BookDto>());
            var mapper = new Mapper(config);
            var user = mapper.Map<BookDto>(data);  //list convert user to list
            return user;



        }
        public static void Update(BookDto data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<BookDto, Book>();
                c.CreateMap<Book, BookDto>();
            });
            var mapper = new Mapper(config);
            var dbobj = mapper.Map<Book>(data);
            DataAccessFactory.BookDataAccess().Update(dbobj);



        }
        public static bool Delete(int id)
        {
            var ret = DataAccessFactory.BookDataAccess().Delete(id);
            return ret;




        }
    }
}