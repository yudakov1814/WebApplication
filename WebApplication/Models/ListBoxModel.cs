using System.Collections.Generic;

namespace WebApplication.Models
{
    public class ListBoxModel
    {
        public IList<Months> Months { get; set; }

        public ListBoxModel()
        {
            Months = new List<Months>();
        }
    }
}
