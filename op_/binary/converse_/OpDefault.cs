using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.of_.binary.converse_
{
	public class OpDefault<T, TOp>
		: Converse<T>
		where TOp : BinaryI<T>, new()
	{
		public OpDefault() : base(nilnul._obj.typ_._UnisonX<TOp>.Unison)
		{
		}



		static public OpDefault<T, TOp> Singleton
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<OpDefault<T, TOp>>.Unison;
			}
		}


	}
}
