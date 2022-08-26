using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_
{

	/// <summary>
	/// will not throw exception except timeout, or memory overflow.
	/// in retrospect, <see cref="nameof(op_.IBinary)"/> might throw exception such as div by zero exception.
	/// Herit this means that the descendant type is magma. It's the implementer's responsibility to ensure that it's indeed a magma.
	/// The mechanism to check whether a <see cref="nameof(IBinary)"/> is magma might be nonexistant.
	/// In hindersight, <see cref="obj.op_.IBinary"/> might throw exception.
	/// </summary>
	public interface IMagma : IBinary
	
		{ }
	public interface IMagma<T> : IMagma, IBinary<T> { }


	public interface MagmaI<T> : BinaryI<T>
		,IMagma<T>
		

	{

	}

	




}
