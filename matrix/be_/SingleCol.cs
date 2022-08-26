using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.be_
{
	public class SingleCol<T> : nilnul.obj.matrix.BeI<T>
		
	{
		public bool be(T[,] matrix)
		{
			return matrix.GetLength(1) ==(1);
			//throw new NotImplementedException();
		}



		static public SingleCol<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<SingleCol<T>>.Instance;
			}
		}


	}
}
