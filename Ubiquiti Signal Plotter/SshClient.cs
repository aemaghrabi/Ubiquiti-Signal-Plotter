using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubiquiti_Signal_Plotter
{
    public class SshClient : Renci.SshNet.SshClient
    {
        public event EventHandler<EventArgs> ClientConnected;

        public SshClient(string host, string username, string password) : base(host, username, password)
        {
            ClientConnected += ClientConnected;
        }

        protected override void OnConnected()
        {
            base.OnConnected();
            ClientConnected?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnDisconnected()
        {
            base.OnDisconnected();
        }
    }
}
