## C#  使用.NET的SocketAsyncEventArgs实现高效能多并发TCPSocket通信

官方实例中需要用到几个类:

* 1. BufferManager类, 管理传输流的大小  原封不动地拷贝过来, 

* 2. SocketEventPool类: 管理SocketAsyncEventArgs的一个应用池. 有效地重复使用.

* 3. AsyncUserToken类: 这个可以根据自己的实际情况来定义.主要作用就是存储客户端的信息.

* 4. SocketManager类: 核心,实现Socket监听,收发信息等操作.

## 额外功能？

* 线程守卫精灵
	*自动检测无效连接并断开
	*自动释放资源


##使用方法

```C#
    int parallelNum = 100;
    int port = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["Port"]);
               
    SocketAsyncServe server = new SocketAsyncServe(port, parallelNum);
    server.Start();
```

##有问题反馈
在使用中有任何问题，欢迎反馈给我，可以用以下联系方式跟我交流

* 邮件(DerekMar@163.com)
* QQ: 363769150
