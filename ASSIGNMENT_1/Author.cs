﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_3_ASSIGNMENT.ASSIGNMENT_1
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }

        public override string ToString()
        {
            return $"AuthorID: {AuthorID}\t AuthorName: {AuthorName}";
        }
    }
}
