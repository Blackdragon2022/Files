﻿using System.Collections.Generic;
using System.Net;

namespace Files.Uwp.Storage.FtpStorage
{
    internal static class FtpManager
    {
        public static readonly Dictionary<string, NetworkCredential> Credentials = new();

        public static readonly NetworkCredential Anonymous = new("anonymous", "anonymous");
    }
}
