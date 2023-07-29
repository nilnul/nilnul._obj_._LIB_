using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.str.every.be_.comp_.gt_
{
	public class CompDefault<TEl,TComp>
		:
		Gt<TEl>
		where TComp:IComparer<TEl>,new()
	{

		public CompDefault() : base(
			//in
			nilnul._obj.typ_._UnisonX<TComp>.Unison
		)
		{
		}


		static public CompDefault<TEl,TComp> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<CompDefault<TEl,TComp>>.Unison;
			}
		}




	}
}
