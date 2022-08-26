using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	public  interface BeNulableI<in TDomain>
	{
		bool? beNulable(TDomain obj);
	}
	
}
