using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.vow
{
	public class Ee<TComponent>
		:
		nilnul.obj.vow.Ee_byRef<(TComponent, TComponent)>
	{
		public Ee(ref (TComponent, TComponent) val, ref Vow_ofRefI<(TComponent, TComponent)> vow) : base(ref val, ref vow)
		{
		}
		public Ee(ref (TComponent, TComponent) val, Vow_ofRefI<(TComponent, TComponent)> vow) : base(ref val, vow)
		{
		}
		public Ee( (TComponent, TComponent) val, ref Vow_ofRefI<(TComponent, TComponent)> vow) : base(ref val, ref vow)
		{
		}

		public Ee(  (TComponent, TComponent) val,  Vow_ofRefI<(TComponent, TComponent)> vow) : base(ref val, ref vow)
		{
		}

		public Ee( TComponent x,  TComponent y,  ref Vow_ofRefI<(TComponent, TComponent)> vow)
			:this( (  x,   y), ref vow )
		{

		}
		public Ee( TComponent x,  TComponent y,   Vow_ofRefI<(TComponent, TComponent)> vow)
			:this( (  x,   y), ref vow )
		{

		}



	}
}
