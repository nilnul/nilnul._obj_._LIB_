using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.be_
{
	public interface CommutativeI<T,TOp>
		:nilnul.obj.BeI1<TOp>
		where TOp: nilnul.obj.op_.BinaryI<T>
 {

	}

	public interface CommutativeI<T>
		:CommutativeI<T,nilnul.obj.op_.BinaryI<T>>
 {

	}

	/// <summary>
	/// whether the op is commutative
	/// </summary>
	class Commutative
	{
	}
}
