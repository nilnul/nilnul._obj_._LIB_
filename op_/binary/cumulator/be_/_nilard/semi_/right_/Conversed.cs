using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.be_._nilard.semi_.right_
{
	/// <summary>
	/// used to judge another cumulator which is the converse of the original.
	/// </summary>
	public class ByConversing<T>
		:
		cumulator.be_.ByConversing<T,cumulator.be_._nilard.semi_.LeftNilardI<T>>
		,

		binary.cumulator.be_._nilard.SemiNilardI<T>

	{
		public ByConversing(cumulator.be_._nilard.semi_.LeftNilardI<T> val) : base(val)
		{
		}

		

	}
}
