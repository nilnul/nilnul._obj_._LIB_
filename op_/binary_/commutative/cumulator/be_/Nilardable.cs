using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.commutable_
{
	/// <summary>
	/// a commutive op which also has at least one nilard
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface NilardableI<T>:CommutableI<T>
	{
	}
}
