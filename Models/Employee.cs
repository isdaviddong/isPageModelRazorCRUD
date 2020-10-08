using System;
using System.Collections.Generic;

namespace RazorPageDemo.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Memo { get; set; }
        public bool? IsValid { get; set; }
    }
}
