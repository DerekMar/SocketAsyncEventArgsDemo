## C#  ʹ��.NET��SocketAsyncEventArgsʵ�ָ�Ч�ܶಢ��TCPSocketͨ��

�ٷ�ʵ������Ҫ�õ�������:

* 1. BufferManager��, ���������Ĵ�С  ԭ�ⲻ���ؿ�������, 

* 2. SocketEventPool��: ����SocketAsyncEventArgs��һ��Ӧ�ó�. ��Ч���ظ�ʹ��.

* 3. AsyncUserToken��: ������Ը����Լ���ʵ�����������.��Ҫ���þ��Ǵ洢�ͻ��˵���Ϣ.

* 4. SocketManager��: ����,ʵ��Socket����,�շ���Ϣ�Ȳ���.

## ���⹦�ܣ�

* �߳���������
	1.�Զ������Ч���Ӳ��Ͽ�
	2.�Զ��ͷ���Դ


## ʹ�÷���

```C#
    int parallelNum = 100;
    int port = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["Port"]);
               
    SocketAsyncServe server = new SocketAsyncServe(port, parallelNum);
    server.Start();
```

##�����ⷴ��
��ʹ�������κ����⣬��ӭ�������ң�������������ϵ��ʽ���ҽ���

* �ʼ�(DerekMar@163.com)
* QQ: 363769150
