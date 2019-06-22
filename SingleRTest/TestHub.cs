using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SingleRTest
{
    public class TestHub : Hub
    {
        public void SendMessage(string name, string msg)
        {

            //string name1 = Context.QueryString["username"];
            //string age = Context.QueryString["age"];
            Clients.All.onMessage(name + "和大家说" + msg);//调用所有连接上来的客户端（包括自己）监听的onMessage事件。All是一个dynamic属性，所以可以随意的监听
        }


        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }
    }
}