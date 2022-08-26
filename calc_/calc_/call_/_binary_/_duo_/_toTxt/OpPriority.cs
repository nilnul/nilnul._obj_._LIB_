using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.call_._duo_._toTxt
{
	public abstract class PriorityA
	{
		public abstract bool? compare(nilnul.obj.CombineI a, nilnul.obj.CombineI b);
		static public PriorityA StaticInstance = new Priority_allIncomparable();

	}

	public class Priority_allIncomparable : PriorityA
	{
		public override bool? compare(CombineI a, CombineI b)
		{

			return null;
			//throw new NotImplementedException();
		}
	}
}
