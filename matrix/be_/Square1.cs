using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.be_
{
	public class Square<T> : nilnul.obj.matrix.BeI<T>
		
	{
		public bool be(T[,] matrix)
		{
			return matrix.GetLength(0) == matrix.GetLength(1);
			//throw new NotImplementedException();
		}



		static public Square<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Square<T>>.Instance;
			}
		}


	}
}
