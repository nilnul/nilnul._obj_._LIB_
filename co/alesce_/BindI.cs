using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co
{
	[Obsolete(nameof(co.IAlesce))]
	public interface BindI<out T,in TCo>
	{
		T bind(TCo co);
	}


	[Obsolete(nameof(co.IAlesce))]
	public abstract class BindA<T, TCo> : BindI<T, TCo>
		//where TCo:CoI<T>,new()
	{
		public abstract T bind(TCo co);
		
	}


}
