﻿using System;

namespace Dotnet.Shell.API
{
    /// <summary>
    /// Throwing this exception will terminate the shell safely.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ExitException : Exception
    {

    }
}
