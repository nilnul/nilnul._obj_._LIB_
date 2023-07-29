using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._set_
{
	//[Obsolete(nameof(MemberEqI<T,TEq>) + ": elEq is reserved for set.Family")]

	[Obsolete(nameof(ElEqI1<T,TEq>))]
	public interface ElementEqI<T, TEq>
		where TEq:IEqualityComparer<T>
	{
		TEq elementEq { get; }


	}

	[Obsolete(nameof(ElEqI1<T>))]
	public interface ElEqI<T>
		:ElementEqI<T,IEqualityComparer<T>>

	{ }

}
