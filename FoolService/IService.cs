﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FoolService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService
    {
	    [OperationContract(IsOneWay = true)]
	    void Go();
			[OperationContract(IsOneWay = true)]
			void Wait();
			[OperationContract(IsOneWay = true)]
			void Beat();
    }
		
}