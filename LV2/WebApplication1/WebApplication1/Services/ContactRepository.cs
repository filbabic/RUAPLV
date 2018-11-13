using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;


namespace WebApplication1.Services
{
    public class ContactRepository
    {

        public Contact[] getAllContacts() {
            return new Contact[]
               {
                new Contact
                {
                    Id = 1,
                    Name = "Pilip"
                },
                new Contact
                {
                    Id = 2,
                    Name = "Filip"
                }
               };
        }
    }
}