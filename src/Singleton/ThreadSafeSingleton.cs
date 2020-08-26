using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class ThreadSafeSingleton
    {
        // Variable is declared to be volatile to ensure that assignment to the instance variable completes before the instance variable can be accessed.
        private static volatile ThreadSafeSingleton _instance;
        private static object _syncRoot = new Object();

        private ThreadSafeSingleton()
        {
        }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new ThreadSafeSingleton();
                        }

                        return _instance;
                    }
                }
                return _instance;
            }
        }
    }
}
