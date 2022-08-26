using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// a collection, which is not empty, and which is 
	///		choosable, i.e., we can select one, as implemented by a method/property
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface ChoiceI<T>
	{
		T choice { get; }
	}
}
