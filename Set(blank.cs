using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// a finite collection disregarding order and mulitplicity
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface ISet
	{
	}

	/// <summary>
	///
	/// </summary>
	/// <typeparam name="T"> the element 's type</typeparam>
	public interface ISet<out T> : ISet {

	}
}
