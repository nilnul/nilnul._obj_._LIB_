using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.be_.square_
{
	public class Secondary<T>
		:
		nilnul.obj.matrix.BeI<T>
	{
		public bool be(T[,] obj)
		{
			return Square<T>.Singleton.be(obj) && obj.GetLength(0) == 2;
			//throw new NotImplementedException();
		}


		static public Secondary<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Secondary<T>>.Instance;
			}
		}

	}
}
