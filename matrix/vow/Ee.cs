using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.vow
{
	public class Ee<T>
		:
		nilnul.obj.vow.Ee1<T[,]>
	{
		public Ee(T[,] val, VowI2<T[,]> vow) : base(val, vow)
		{
		}
	}
}
