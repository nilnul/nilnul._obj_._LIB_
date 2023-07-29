using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.of_.binary.cascader_
{
	public class OpDefault<T, TOp>
		: Cascader<T, TOp>
		where TOp : nilnul.obj.of_.BinaryI<T>, new()
	{
		public OpDefault() : base(
				 nilnul._obj.typ_._UnisonX<TOp>.Unison
		)
		{
		}



		static public OpDefault<T, TOp> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<OpDefault<T, TOp>>.Unison;
			}
		}


	}
}
