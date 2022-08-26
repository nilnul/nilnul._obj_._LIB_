using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.be_._unard.semi_.right_
{
	/// <summary>
	/// used to judge another cumulator which is the converse of the original.
	/// </summary>
	public class ByConversing<T>
		:
		cumulator.be_.ByConversing<T,cumulator.be_._unard.semi_.LeftUnardI<T>>
		,

		binary.cumulator.Be_cumulatorGeneriI<T>

	{
		public ByConversing(cumulator.be_._unard.semi_.LeftUnardI<T> val) : base(val)
		{
		}

		

	}
}
