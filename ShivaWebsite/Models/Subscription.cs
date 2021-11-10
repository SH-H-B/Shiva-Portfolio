using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ShivaWebsite.Data;


namespace ShivaWebsite.Models
{
    public class Subscription
    {
        // This function returns a list of tbl subscription 
        public List<tblSubscription> getAllEmails()
        {
            using (ShivaWebEntities myDb = new ShivaWebEntities())
            {
                return myDb.tblSubscriptions.ToList();
            }
        }

        public string addSubscription(string userEmail)
        {
            using (ShivaWebEntities myDb = new ShivaWebEntities())
            {
                try
                {
                    tblSubscription newTbSubscription = new tblSubscription();
                    newTbSubscription.Email = userEmail;
                    myDb.tblSubscriptions.Add(newTbSubscription);
                    myDb.SaveChanges();
                    return "OK";
                }
                catch(Exception e)
                {
                    return "Server Error";
                }
            }

        }

    }
}