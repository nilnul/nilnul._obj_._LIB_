using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	public interface CompI:IComparer<bool>
	{

	}
	public class Comp : CompI
	{
		public int Compare(bool x, bool y)
		{
			return nilnul.bit.to_.Int.Singleton.to(x).CompareTo(
				nilnul.bit.to_.Int.Singleton.to(y)
			);
			
		}
	}
}
