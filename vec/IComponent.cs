using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vec
{
	/// <summary>
	/// </summary>
	public interface IComponent:str.IComponent
	{
	}
	public interface IComponent<T> : IComponent, str.IComponent<T> { }
}
