using System;
using MFL.Data;

namespace MFL.Web.Models
{
    public class PlayerListItemModel
    {
        public PlayerListItemModel() { }

        public PlayerListItemModel(User u)
        {
            PlayerId = u.UserId;
            Name = u.Name;
            IsAdmin = u.IsAdmin;
        }

        public Guid PlayerId { get; set; }

        public string Name { get; set; }

        public bool IsAdmin { get; set; }
    }
}