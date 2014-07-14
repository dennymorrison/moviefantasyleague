using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFL.Web.Models
{
    public class PlayerModel
    {
        public PlayerModel() { }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string EmailAddress { get; set; }
    }
}