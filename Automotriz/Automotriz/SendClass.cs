﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ClASE QYE SE UTILIZA PARA REALIZA PASO DE VARIABLES ENTRE CLASES
namespace Automotriz
{
    class SendClass
    {
        string Id; // Id que lleva
        public SendClass()
        {
    
        }
        public void GetterId(string id)
        {
            Id = id; //id que trae
        }

        public string SetterId()
        {
            return Id;
        }
    }
}
