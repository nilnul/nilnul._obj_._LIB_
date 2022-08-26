using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vec
{
	public interface IScala : str.IScala { }

	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IScala<T>
		:IScala
	{
	}
}
