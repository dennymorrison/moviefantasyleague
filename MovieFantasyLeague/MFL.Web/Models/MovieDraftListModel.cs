using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFL.Web.Models
{
    public class MovieDraftListModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public int DraftCost { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool IsSelected { get; set; }
    }
}