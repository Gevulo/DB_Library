﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Library
{
    public static class MediatorLoadBook
    {
        public static Func<DataGridViewRowCollection> GetBooks { set; get; }
    }
}
