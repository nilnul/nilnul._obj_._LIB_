using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.be_.square_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// alias:
	///		quatic
	///			this is intentially written as quatic ,not quartic, as quar- denotes 1/4
	public class Quatic<T>
		:
		nilnul.obj.matrix.BeI<T>
	{
		public bool be(T[,] obj)
		{
			return Square<T>.Singleton.be(obj) && obj.GetLength(0) == 4;
			//throw new NotImplementedException();
		}


		static public Quatic<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Quatic<T>>.Instance;
			}
		}

	}
}
