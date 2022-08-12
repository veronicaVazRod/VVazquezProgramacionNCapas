﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUsuario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUsuario
    {

        [OperationContract]
        SL_WCF.Result Add(ML.Usuario usuario); //firma de los métodos
         
        [OperationContract]
        SL_WCF.Result Update(ML.Usuario usuario); //firma de los métodos

        [OperationContract]
        SL_WCF.Result Delete(int IdUsuario); //firma de los métodos



    }

 }

