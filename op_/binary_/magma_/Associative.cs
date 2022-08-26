using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.magma_
{

	/// <summary>
	///  The difference between this and <see cref="nameof(binary_.IAssociative)"/> is that the latter might throw exception.
	///  for the latter, if an exception is thrown somewhere, the cumulative result would be exception. But is this still associative? 
	/// </summary>
	/// <remarks>
	/// alias:
	///		semigrp
	/// </remarks>
	public interface IAssociative : IMagma
	
		{ }
	public interface IAssociative<T> : IAssociative, IMagma<T> { }


	public interface AssociativeI<T> :
		MagmaI<T>
		,
		IAssociative<T>
	{

	}

	




}
