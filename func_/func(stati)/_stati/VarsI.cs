using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func._stati
{


	[Obsolete()]
	public  interface VarsI_sDistinct
		:VarsI_sDistinct< obj.var.stati.s.SI>
	{

		

	}

	[Obsolete()]

	public  interface VarsI_sDistinct<TSi>
		:
		VarsI<nilnul.obj.var.stati.s.b.Distinct<TSi>.Asserted>

		where TSi:obj.var.stati.s.SI
	{


	}
	[Obsolete()]

	public  interface VarsI<TVars>
	{

		TVars vars { get; }

	}


	[Obsolete()]
	public  interface VarsI
	{

		nilnul.obj.var.stati.set.Ordered vars { get; }

	}







}
