using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.tup
{
	/// <summary>
	/// </summary>
	public interface IComponent:rec.IComponent
	{
	}
	public interface IComponent<T> : IComponent, rec.IComponent<T> { }
}
