﻿using System.Collections.Generic;

namespace NooBIT.Web.Http
{
    public class HeaderPolicy
    {
        public IDictionary<string, Header> SetHeaders { get; } = new Dictionary<string, Header>();

        public ISet<string> RemoveHeaders { get; } = new HashSet<string>();
    }
}