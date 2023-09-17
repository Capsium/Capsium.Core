﻿using System;
using System.Runtime.InteropServices;

namespace Capsium.Core
{
// we create some structs for P/Invoke that give 0649's.  It's non-applicable for these, so ignore
#pragma warning disable 0649
    internal static partial class Interop
    {
        public static partial class Nuttx
        {
            //int sigprocmask(int how, FAR const sigset_t *set, FAR sigset_t *oset);
            [DllImport(LIBRARY_NAME, SetLastError = true)]
            public static extern int sigprocmask(int how, ref int set, out int oldset);

            [DllImport(LIBRARY_NAME, SetLastError = true)]
            public static extern int sigaction(int signum, ref SigAction act, ref SigAction oldact);

            [DllImport(LIBRARY_NAME, SetLastError = true)]
            public static extern int sigemptyset(ref int set);

            [DllImport(LIBRARY_NAME, SetLastError = true)]
            public static extern int sigaddset(ref int set, int signum);

            [DllImport(LIBRARY_NAME, SetLastError = true)]
            public static extern int sigwaitinfo(ref int set, ref SigInfo info);

            [DllImport(LIBRARY_NAME, SetLastError = true)]
            public static extern int sigtimedwait(ref int set, ref SigInfo info, ref timespec ts);

            [DllImport(LIBRARY_NAME, SetLastError = true)]
            public static extern int sigpending(ref int set);

            public static int sigfillset(ref int set)
            {
                // this is inlined in the OS, so we just implement it here
                set = -1; // 0xffffffff
                return 0;
            }

            // from signal.h
            // #define SIG_BLOCK       1  /* Block the given signals */
            // #define SIG_UNBLOCK     2  /* Unblock the given signals */
            // #define SIG_SETMASK     3  /* Set the signal mask to the current set */            public const int _GPIOBASE = 0x2300;
            public const int SIG_BLOCK = 1;
            public const int SIG_UNBLOCK = 2;
            public const int SIG_SETMASK = 3;

            /*
            struct sigaction
            {
              union
              {
                _sa_handler_t   _sa_handler;
                _sa_sigaction_t _sa_sigaction;
              } sa_u;
              sigset_t          sa_mask;
              int               sa_flags;
            };
            */
            public struct SigAction
            {
                public IntPtr sa_sigaction;
                public int sa_mask;
                public SigActionFlags sa_flags;
            }

            //* struct sigaction flag values 
            // 
            // #define SA_NOCLDSTOP    (1 << 0) /* Do not generate SIGCHILD when
            //                                   * children stop(ignored) */
            // #define SA_SIGINFO      (1 << 1) /* Invoke the signal-catching function
            //                                   * with 3 args instead of 1
            //                                   * (always assumed) */
            // #define SA_NOCLDWAIT    (1 << 2) /* If signo=SIGCHLD, exit status of child
            //                                   * processes will be discarded */
            [Flags]
            public enum SigActionFlags : int
            {
                NOCLDSTOP = (1 << 0),
                SIGINFO = (1 << 1),
                NOCLDWAIT = (1 << 2)
            }

            //struct siginfo
            //{
            //  uint8_t      si_signo;     /* Identifies signal */
            //  uint8_t      si_code;      /* Source: SI_USER, SI_QUEUE, SI_TIMER, SI_ASYNCIO, or SI_MESGQ */
            //  uint8_t      si_errno;     /* Zero or errno value associated with signal */
            //  union sigval si_value;     /* Data passed with signal */
            //#ifdef CONFIG_SCHED_HAVE_PARENT
            //  pid_t        si_pid;       /* Sending task ID */
            //  int          si_status;    /* Exit value or signal (SIGCHLD only). */
            //#endif
            //  void*        si_addr;
            //};
            public struct SigInfo
            {
                public byte si_signo;
                public SigInfoCode si_code;
                public byte si_errno;
                public int si_value;

                public short si_pid;
                public int si_status;
                public IntPtr si_addr;
            }

            //#define SI_USER         0  /* Signal sent from kill, raise, or abort */
            //#define SI_QUEUE        1  /* Signal sent from sigqueue */
            //#define SI_TIMER        2  /* Signal is result of timer expiration */
            //#define SI_ASYNCIO      3  /* Signal is the result of asynch IO completion */
            //#define SI_MESGQ        4  /* Signal generated by arrival of a message on an */
            //                           /* empty message queue */
            //#define CLD_EXITED      5  /* Child has exited (SIGCHLD only) */
            //#define CLD_KILLED      6  /* Child was killed (SIGCHLD only) */
            //#define CLD_DUMPED      7  /* Child terminated abnormally (SIGCHLD only) */
            //#define CLD_TRAPPED     8  /* Traced child has trapped (SIGCHLD only) */
            //#define CLD_STOPPED     9  /* Child has stopped (SIGCHLD only) */
            //#define CLD_CONTINUED   10 /* Stopped child had continued (SIGCHLD only) */
            public enum SigInfoCode : byte
            {
                USER = 0,
                QUEUE = 1,
                TIMER = 2,
                ASYNCIO = 2,
                MESGQ = 4,
                EXITED = 5,
                KILLED = 6,
                DUMPED = 7,
                TRAPPED = 8,
                STOPPED = 9,
                CONTINUED = 10
            }

            //struct sigevent
            //{
            //  uint8_t      sigev_notify; /* Notification method: SIGEV_SIGNAL, SIGEV_NONE, or SIGEV_THREAD */
            //  uint8_t      sigev_signo;  /* Notification signal */
            //  union sigval sigev_value;  /* Data passed with notification */
            //#ifdef CONFIG_SIG_EVTHREAD
            //  sigev_notify_function_t sigev_notify_function; /* Notification function */
            //  FAR pthread_attr_t *sigev_notify_attributes;   /* Notification attributes (not used) */
            //#endif
            //};
            public struct SigEvent
            {
                public byte sigev_notify;
                public byte sigev_signo;
                public byte sigev_value;

                public IntPtr sigev_notify_function;
                public IntPtr sigev_notify_attributes;
            }
        }
#pragma warning restore 0649
    }
}