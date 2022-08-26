using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.vow_.ofIn
{
	public class Ee<TComponent>
		:
		nilnul.obj.vow.Ee_ofIn<(TComponent, TComponent)>
	{
		public Ee(in (TComponent, TComponent) val, in obj.VowI_ofIn<(TComponent, TComponent)> vow) : base(in val, in vow)
		{
		}
		public Ee(in (TComponent, TComponent) val, VowI_ofIn<(TComponent, TComponent)> vow) : base(in val, vow)
		{
		}
		public Ee( (TComponent, TComponent) val, in VowI_ofIn<(TComponent, TComponent)> vow) : base(in val, in vow)
		{
		}

		public Ee(  (TComponent, TComponent) val, VowI_ofIn<(TComponent, TComponent)> vow) : base(in val, in vow)
		{
		}

		public Ee( TComponent x,  TComponent y,  in VowI_ofIn<(TComponent, TComponent)> vow)
			:this( (  x,   y), in vow )
		{

		}
		public Ee( TComponent x,  TComponent y, VowI_ofIn<(TComponent, TComponent)> vow)
			:this( (  x,   y), in vow )
		{

		}



	}
}
