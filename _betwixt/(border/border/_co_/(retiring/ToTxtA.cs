using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border._duo_
{
	[Obsolete()]

	public abstract class ToTxtA<T,TBorder, TBorder1>
		:DuoI<T,TBorder,TBorder1>

		where TBorder:BorderI<T>
		where TBorder1:BorderI<T>
	{
		public abstract TBorder lower { get; }
		public abstract TBorder1 upper { get; }

		public override string ToString()
		{
			return $"{_duo_.lower._ToTxtX.ToTxt(lower)},{_duo_.upper._ToTxtX.ToTxt(upper)}";
			;
		}
	}
	public abstract class ToTxtA<T,TBorder>
		:ToTxtA<T,TBorder,TBorder>

		where TBorder:BorderI<T>
	{
		
	}


}
