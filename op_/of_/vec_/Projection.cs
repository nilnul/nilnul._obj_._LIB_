using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.of_.vec_
{
	/// <summary>
	/// get 
	/// </summary>
	/// vs: projector, which is a map for nilnul.geometry
	///		
	public class Projection<T> : op_.of_.Vec<T>
	{
		public Projection(int arity, int index) : base(
			arity
			,
			(str)=> str.ElementAt(index)
		)
		{
			nilnul.bit.vow_._TrueX.Vow(
				arity>index, new ArgumentOutOfRangeException(nameof(index))
			);

		}
	}
}
