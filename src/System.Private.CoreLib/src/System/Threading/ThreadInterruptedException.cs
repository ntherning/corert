// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*=============================================================================
**
**
**
** Purpose: An exception class to indicate that the thread was interrupted
**          from a waiting state.
**
**
=============================================================================*/

using System.Runtime.Serialization;

namespace System.Threading
{
    [Serializable]
#if !MONO
    [System.Runtime.CompilerServices.TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
#endif
    public class ThreadInterruptedException : SystemException
    {
        public ThreadInterruptedException()
            : base(SR.Threading_ThreadInterrupted)
        {
            HResult = HResults.COR_E_THREADINTERRUPTED;
        }

        public ThreadInterruptedException(String message)
            : base(message)
        {
            HResult = HResults.COR_E_THREADINTERRUPTED;
        }

        public ThreadInterruptedException(String message, Exception innerException)
            : base(message, innerException)
        {
            HResult = HResults.COR_E_THREADINTERRUPTED;
        }

        protected ThreadInterruptedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
