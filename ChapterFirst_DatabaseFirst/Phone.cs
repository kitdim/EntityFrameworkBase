using System;
using System.Collections.Generic;

namespace ChapterFirst_DatabaseFirst
{
    public partial class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Price { get; set; }
    }
}
