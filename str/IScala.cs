using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		sample
	///		scala
	///			starts with "s" as sample does;
	public interface IScala : tup.IScala { }

	/// <summary>
	/// return <typeparamref name="T"/> from <see cref="obj.IStr{T}"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IScala<T>:IScala, tup.IScala<T>
	{
	}
}
