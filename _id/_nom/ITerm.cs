using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._id._nom
{
	/// <summary>
	/// </summary>
	/// <remarks>
	///eg:
	///		go2map
	///		go2WorldMap
	///		AppleOrPears
	///			(apple) or (pears)
	///		AppleOrPearEs
	///			(apple or pear) s
	///		AppleOrPear1bananaEs
	///			(apple or (pear with banana) ) s
	///			
	///		AppleOrPear1bananaesEs
	///			(apple or ( (pear with banana)s ) ) s
	///
	/// underscoe can be used
	///		when uppercasing
	///			ABC_DEF
	///		for grouping
	///			Abc_Def__Gh
	///				longer consective "___" has lower precedence. So the above is interpreted as (abcDef)gh
	///
	/// 
	///			
	/// </remarks>
	/// alias:
	///		gram
	///			like in 2-gram, n-gram
	class ITerm
	{
	}
}
