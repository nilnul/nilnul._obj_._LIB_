using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.be_
{
	public class Square : nilnul.obj.matrix.BeI
		
	{
		public bool be<T>(T[,] matrix)
		{
			return matrix.GetLength(0) == matrix.GetLength(1);
			//throw new NotImplementedException();
		}


		static public Square Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Square>.Instance;
			}
		}

	}
}
