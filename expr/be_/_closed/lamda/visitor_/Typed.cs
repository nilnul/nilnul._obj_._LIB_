using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr.be_._closed.lamda.visitor_
{
	/// <summary>
	/// return false if found any par
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Typed<T> : Visitor
	{
		public Typed() : base(typeof(T))
		{
		}
	}
}
