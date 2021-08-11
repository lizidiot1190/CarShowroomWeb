using CarShowroom.Models;
using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace CarShowroom.DAO
{
    public class ContactDAO
    {
        private ApplicationDbContext db = null;
        public ContactDAO()
        {
            db = new ApplicationDbContext();
        }

        public long Insert(Contact entity)
        {
            db.Contacts.Add(entity);
            db.SaveChanges();
            return entity.id;

        }

        public bool Delete(int id)
        {
            try
            {
                var contact = db.Contacts.Find(id);
                db.Contacts.Remove(contact);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Contact> ListAllPage(int page, int pageSize)
        {
            return db.Contacts.OrderByDescending(p => p.id).ToPagedList(page, pageSize);
        }

    }
}