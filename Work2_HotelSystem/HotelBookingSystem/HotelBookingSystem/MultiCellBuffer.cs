using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HotelBookingSystem
{
    /**
     * MultiCellBuffer类用于旅行社（客户）和HotelSupplier（服务器）之间的通信
     */
    public class MultiCellBuffer
    {
        private static Semaphore semaphore = new Semaphore(2, 2); // 最多两个单元
        private static DataCell[] buffer = new DataCell[2];
        private static readonly ReaderWriterLockSlim[] cellLocks = new ReaderWriterLockSlim[2]
        {
        new ReaderWriterLockSlim(),
        new ReaderWriterLockSlim()
        };

        public static void SetOneCell(string data)
        {
            semaphore.WaitOne(); // 获取写入权限
            try
            {
                for (int i = 0; i < buffer.Length; i++)
                {
                    cellLocks[i].EnterWriteLock(); // 获取写锁
                    try
                    {
                        if (buffer[i] == null || buffer[i].flag == 0) // 找到空闲单元
                        {
                            buffer[i] = new DataCell { new_order = data, flag = 1 }; // 写入数据并标记为已使用
                            break;
                        }
                    }
                    finally
                    {
                        cellLocks[i].ExitWriteLock(); // 释放写锁
                    }
                }
            }
            finally
            {
                semaphore.Release(); // 释放写入权限
            }
        }

        public static string GetOneCell()
        {
            string data = null;
            for (int i = 0; i < buffer.Length; i++)
            {
                cellLocks[i].EnterReadLock(); // 获取读锁
                try
                {
                    if (buffer[i] != null && buffer[i].flag == 1) // 找到已使用的单元
                    {
                        data = buffer[i].new_order; // 读取数据
                        buffer[i].flag = 0; // 标记为空闲
                        break;
                    }
                }
                finally
                {
                    cellLocks[i].ExitReadLock(); // 释放读锁
                }
            }
            return data;
        }
    }

    // 数据单元类，用于缓冲区中的每个单元
    public class DataCell
    {
        public string new_order; // 存储订单
        public int flag = 0; // 标记单元状态：0 表示空闲，1 表示已使用
    }

}
