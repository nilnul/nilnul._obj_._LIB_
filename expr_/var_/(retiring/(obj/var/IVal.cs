using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var
{
	/// <summary>
	/// the val of the var.
	/// for reference type, the var is a pointer;
	/// for value type, the var directly contain the val;
	/// </summary>
	/// Note: var is a syntax concept. It maynot be materialized when it's a value type as in that case, the var is infact the val itself, and the concept of var is how we, not the runtime code, address that value;
	/// 
	internal class IVal
	{
	}


}
