﻿// Copyright (c) 2007-2016 CSJ2K contributors.
// Licensed under the BSD 3-Clause License.

namespace CSJ2K.Util
{
    using System;

    using CSJ2K.j2k.util;

    public class DotnetMsgLogger : StreamMsgLogger
    {
        #region CONSTRUCTORS

        public DotnetMsgLogger()
            : base(Console.OpenStandardOutput(), Console.OpenStandardError(), 78)
        {
        }

        #endregion
    }
}
