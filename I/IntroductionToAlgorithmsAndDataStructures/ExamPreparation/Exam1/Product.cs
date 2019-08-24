﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Product
    {
        private string name;
        private Product next;

        public Product(string name)
        {
            this.Name = name;

        }

        public string Name
        {
            get;
            set;
        }

        public Product Next
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"Product {this.Name}";
        }

    }

}
