using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.be_.square_
{
	public class Tertiary<T>
		:
		nilnul.obj.matrix.BeI<T>
	{
		public bool be(T[,] obj)
		{
			return Square<T>.Singleton.be(obj) && obj.GetLength(0) == 3;
			//throw new NotImplementedException();
		}


		static public Tertiary<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Tertiary<T>>.Instance;
			}
		}

	}
}
