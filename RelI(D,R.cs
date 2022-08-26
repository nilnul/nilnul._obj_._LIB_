using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	public partial interface RelI<TDomain,TRange>
		:nilnul.obj.op.BinaryI<TDomain,TRange,bool>
		
	{
		//bool contains(TDomain d,TRange r);
	}
}
