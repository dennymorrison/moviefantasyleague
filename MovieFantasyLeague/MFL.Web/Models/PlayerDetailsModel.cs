using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MFL.Data;

namespace MFL.Web.Models
{
    public class PlayerDetailsModel
    {
        public PlayerDetailsModel() { }

        public PlayerDetailsModel(User u)
        {
            PlayerId = u.UserId;
            Name = u.Name;
        }

        public Guid PlayerId { get; set; }

        public string Name { get; set; }


    }
}