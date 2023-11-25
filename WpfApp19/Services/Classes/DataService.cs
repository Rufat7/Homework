using GalaSoft.MvvmLight.Messaging;
using WpfApp19.Messages;
using WpfApp19.Services.Interfaces;
namespace WpfApp19.Services.Classes;

class DataService : IDataService
{
	private readonly IMessenger _messenger;

	public DataService(IMessenger messenger)
	{
		_messenger = messenger;
	}

	public void SendData(object data)
	{
		_messenger.Send(new DataMessage()
		{
			Data = data
		});
	}
	public void SendDatas(object[] data)
	{
		_messenger.Send(new DatasMessage()
		{
			Datas = data
		});
	}
}
