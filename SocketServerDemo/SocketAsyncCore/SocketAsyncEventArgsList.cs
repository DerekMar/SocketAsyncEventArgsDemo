using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace socketDemo.SocketAsyncCore
{
    public class SocketAsyncEventArgsList : Object
    {
        private List<SocketAsyncEventArgs> m_list;

        public SocketAsyncEventArgsList()
        {
            m_list = new List<SocketAsyncEventArgs>();
        }

        public void Add(SocketAsyncEventArgs s)
        {
            lock(m_list)
            {
                m_list.Add(s);
            }
        }

        public void Remove(SocketAsyncEventArgs s)
        {
            lock (m_list)
            {
                m_list.Remove(s);
            }
        }

        public void CopyList(ref SocketAsyncEventArgs[] array)
        {
            lock (m_list)
            {
                array = new SocketAsyncEventArgs[m_list.Count];
                m_list.CopyTo(array);
            }
        }
    }
}
