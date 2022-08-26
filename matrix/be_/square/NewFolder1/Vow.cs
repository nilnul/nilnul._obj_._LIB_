using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.be_.square
{

	[Obsolete()]

	public class Vow

	{
		public void vow<T>(T[,] matrix) {
			nilnul.obj.vow_.True.Singleton.vow(
				Square.Singleton.be<T>(matrix)
			);
		}

		static public Vow Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Vow>.Instance;
			}
		}

	}
}
