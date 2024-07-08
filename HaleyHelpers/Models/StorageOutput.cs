﻿using Haley.Enums;
using Haley.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Haley.Models {
    public class StorageOutput {
        public bool Status { get; set; }
        public string StoredPath { get; set; }
        public StorageOutput(bool status) { Status = status; }
    }
}
