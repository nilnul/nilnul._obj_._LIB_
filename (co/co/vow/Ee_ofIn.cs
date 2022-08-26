using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.vow
{
	public class Ee_ofIn<TComponent>
		:
		nilnul.obj.vow.Ee_ofIn<(TComponent, TComponent)>
	{
		public Ee_ofIn(in (TComponent, TComponent) val, in VowI_ofIn<(TComponent, TComponent)> vow) : base(in val, in vow)
		{
		}
		public Ee_ofIn(in (TComponent, TComponent) val, VowI_ofIn<(TComponent, TComponent)> vow) : base(in val, vow)
		{
		}
		public Ee_ofIn( (TComponent, TComponent) val, in VowI_ofIn<(TComponent, TComponent)> vow) : base(in val, in vow)
		{
		}

		public Ee_ofIn(  (TComponent, TComponent) val,  VowI_ofIn<(TComponent, TComponent)> vow) : base(in val, in vow)
		{
		}

		public Ee_ofIn( in TComponent x, in  TComponent y,  in VowI_ofIn<(TComponent, TComponent)> vow)
			:this(  (  x,   y), in vow )
		{

		}
		public Ee_ofIn( in TComponent x,  TComponent y,  in VowI_ofIn<(TComponent, TComponent)> vow)
			:this( in  x,  in y, in vow )
		{

		}

		public Ee_ofIn( TComponent x, in TComponent y,   VowI_ofIn<(TComponent, TComponent)> vow)
			:this( in  x, in  y, in vow )
		{

		}

		public Ee_ofIn( TComponent x,  TComponent y,   VowI_ofIn<(TComponent, TComponent)> vow)
			:this( in  x, in  y, in vow )
		{

		}



	}
}
