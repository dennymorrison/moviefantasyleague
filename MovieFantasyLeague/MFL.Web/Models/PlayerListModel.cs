using System.Collections.Generic;

namespace MFL.Web.Models
{
    public class PlayerListModel
    {
        public PlayerListModel() 
        {
            Players = new List<PlayerListItemModel>();
        }

        public List<PlayerListItemModel> Players { get; set; }
    }
}