using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	/// <summary>
	/// </summary>
	public interface IComponent:tup.IComponent
	{
	}
	public interface IComponent<T> : IComponent, tup.IComponent<T> { }
}
