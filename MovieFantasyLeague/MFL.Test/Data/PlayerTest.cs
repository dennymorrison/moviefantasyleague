using System;
using System.Linq;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MFL.Data;

namespace MFL.Test.Data
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void CreatePlayer()
        {
            Player p = new Player();
            p.PlayerID = Guid.NewGuid();
            p.Name = "Denny";
            p.EmailAddress = "dennymorrison@gmail.com";

            using (var db = new MFLContext())
            {
                db.Players.Add(p);
                db.SaveChanges();
            }

            using (var db = new MFLContext())
            {
                var result = db.Players.SingleOrDefault(x => x.Name == "Denny");
                Assert.IsNotNull(result);
            }           
        }

        [TestCleanup]
        private void DeletePlayer()
        {
            using(var db = new MFLContext())
            {
                var result = db.Players.SingleOrDefault(x => x.Name == "Denny");
                if(result!=null)
                {
                    db.Players.Remove(result);
                    db.SaveChanges();
                }
            }
        }
    }
}
