#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.ovNuly_
{
	/// <summary>
	/// <see cref="nilnul.obj.eq_.ovNuly_.NulNeException"/>
	/// in db, we may apply unique constraint on each val except nulls.
	/// </summary>
	/// <typeparam name="T">nulable. default to class? ; but can also be Nullable struct such as int?</typeparam>
	public interface  NulNeI<T>
		:OvNulyI<T>
	{
	}

	


}
