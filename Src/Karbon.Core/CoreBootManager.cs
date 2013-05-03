﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karbon.Core.IO;
using Karbon.Core.Serialization;

namespace Karbon.Core
{
    public class CoreBootManager
    {
        private bool _isInitialized;

        public virtual void Initialize()
        {
            if (_isInitialized)
                throw new InvalidOperationException("The boot manager has already been initialized");

            KarbonAppContext.Current = new KarbonAppContext();
        }
    }
}
