using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// tensor is recursively defined:
	///		*) base clause:
	///			T, is a tensor.
	///		*) extension clause:
	///			a str of tensors, each of wich has the same size,  is a tensor.
	///		*) exclusion clause:
	///			nothing but the above are tensors.
	/// Simply put: a tensor is a str of tensors, each of which has a lower rank (count of dimensions.)
	///	eg:
	///		[1,2,3] is tensor, rank is 1, size is 3, or [3]
	///		[ [1,2],[3,4],[5,6] ] is tensor, rank is 2, size is 3*2, or [3,2]
	///		double[3,2,1] x; //in c#, variable declaration, where x is tensor, rank is 3, size is 3*2*1, or [3,2,1]
	///		1 is tensor, rank is 0, size is a product of an empty str of nums: [].
	/// </summary>
	/// alias:
	///		multi-dimensional array.
	///			or simply in c#, array.
	///		vec/str for 1d array
	///		matrix for 2d array.
	///		if the rank of tensor is more than 2, we would call it hypermatrix.
	///
	/// 
	/// T, a scalar (unstructured), is 0-dimensional array.
	/// T[] is 1-dimensional tensor, <see cref="obj.IVec"/>, <see cref="obj.IStr"/>
	/// T[,], or <see cref="IMatrix"/> is 2-dimensional tensor
	/// T[,,] is  3-dimensional tensor. We might also call this rubik. <see cref="obj.IRubic"/>

	public interface ITensor
	{
	}
}
