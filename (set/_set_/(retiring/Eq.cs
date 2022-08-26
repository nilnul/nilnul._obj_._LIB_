using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._set_
{
	[Obsolete(nameof(MemberEqI<T>) + ": elEq is reserved for set.Family")]
	public interface ElementEqI<T>
	{
		IEqualityComparer<T> elementEq { get; }
	}
}
