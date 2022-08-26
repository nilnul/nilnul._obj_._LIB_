using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_
{
	public interface IAssociative : IBinary
	
		{ }
	/// <summary>
	/// we not only see the implementation of <see cref="op_.BinaryI{T}.op"/>, but also see all instances of the type as a set. Now we have a set and an op, we can determine whether it's associative or not.
	/// </summary>
	public interface IAssociative<T> : IAssociative, IBinary<T> { }


	public interface AssociativeI<T> : BinaryI<T>
		,IAssociative<T>
		

	{

	}

	




}
