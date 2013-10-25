﻿using System;
using System.Diagnostics;

namespace Neon.Utilities {
    public class Contract {
        [Conditional("DEBUG")]
        public static void Requires(bool condition, string message = "") {
            if (condition == false) {
                throw new Exception(message);
            }
        }
    }
}