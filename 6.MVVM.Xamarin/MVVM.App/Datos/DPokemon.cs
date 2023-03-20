using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

using Firebase.Database.Query;

using MVVM.App.Conexion;
using MVVM.App.Datos;
using MVVM.App.Model;

namespace MVVM.App.Datos
{
	public class DPokemon
	{
		public async Task PostPokemon(MPokemon parametros)
		{
			await CConexion.firebase
				.Child("Pokemon")
				.PostAsync(new MPokemon()
				{
					Numero = parametros.Numero,
					Nombre = parametros.Nombre,
					Imagen = parametros.Imagen,
					Tipo1 = parametros.Tipo1,
					Tipo2 = parametros.Tipo2,
				});
		}
		public async Task<List<MPokemon>> GetPokemon()
		{
			return (await CConexion.firebase
				.Child("Pokemon")
				.OnceAsync<MPokemon>())
				.Select(item => new MPokemon
				{
					ID = item.Key,
					Numero = item.Object.Numero,
					Nombre = item.Object.Nombre,
					Imagen = item.Object.Imagen,
					Tipo1 = item.Object.Tipo1,
					Tipo2 = item.Object.Tipo2,
				}
				).ToList();
		}
	}
}
