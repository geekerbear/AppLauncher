using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppLauncher.Helper
{
    internal static partial class ThrowHelper
    {
        internal static void ThrowIfNull(object? argument,
            [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (argument is null)
            {
                Throw(paramName);
            }
        }

        private static void Throw(string? paramName) => throw new ArgumentNullException(paramName);
    }
}
