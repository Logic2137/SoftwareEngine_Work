using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HotelBookingSystem
{
    public class MultiCellBuffer
    {
        private static Semaphore semaphore = new Semaphore(2, 2); // 最多两个单元
        private static string[] buffer = new string[2];
        private static readonly object lockObj = new object();

        public static void SetOneCell(string data)
        {
            semaphore.WaitOne();
            lock (lockObj)
            {
                for (int i = 0; i < buffer.Length; i++)
                {
                    if (buffer[i] == null)
                    {
                        buffer[i] = data;
                        break;
                    }
                }
            }
            semaphore.Release();
        }

        public static string GetOneCell()
        {
            lock (lockObj)
            {
                for (int i = 0; i < buffer.Length; i++)
                {
                    if (buffer[i] != null)
                    {
                        string data = buffer[i];
                        buffer[i] = null;
                        return data;
                    }
                }
            }
            return null;
        }
    }

}
