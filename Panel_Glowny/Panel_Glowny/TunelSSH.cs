using System;
using Renci.SshNet;

namespace Panele_Glowne
{
    public static class TunelSSH
    {
        private static SshClient _client;
        private static ForwardedPortLocal _port;

        public static void Polacz(string login, string haslo)
        {
            _client = new SshClient("eduweb.pwste.edu.pl", 55522, login, haslo);

            _client.Connect();

            _port = new ForwardedPortLocal("127.0.0.1", 3306, "127.0.0.1", 3306);

            _client.AddForwardedPort(_port);
            _port.Start();
        }

        public static void Rozlacz()
        {
            if (_port != null && _port.IsStarted)
                _port.Stop();

            if (_client != null && _client.IsConnected)
                _client.Disconnect();
        }
    }
}