using System;
using System.Collections.Generic;
using System.Text;

using Firebase.Database;

namespace MVVM.App.Conexion
{
	public class CConexion
	{
		public static FirebaseClient firebase = new FirebaseClient("https://mvvm-5320a-default-rtdb.firebaseio.com/");
	}
}
