namespace nilnul.obj.matrix.op_.unary_
{
	/// <summary>
	/// to transpose a matrix, in notation <see cref="matrix.phrase_"/>, we can simply move the cap from top to left <see cref="phrase_.Colmajor"/>
	/// eg:
	///		1,2,3
	///		4,5,6
	///		when transposed, would be:
	///		/            #
	///		|  1, 2, 3   #
	///		|  4 ,5, 6   #
	///		\            #
	///		or:
	///		/             #
	///		|  1 | 2 | 3  #
	///		|  4 | 5 | 6  #
	///		\             #
	///		or:
	///			1|2|3
	///			4|5|6
	///			that is, when seprated by "|" (in writing, the bar can be connected as a vertical line), it's colmajor, whileas "," means rowmajor.
	///				this means [[1,4], [2,5] , [3,6]]
	/// </summary>
	/// <remarks>
	/// when multiplied, the right matrix is rendered colmajor. But the right is still a str of vecs as cols. (the left is a str of vecs as rows)
	///		but this is not required for <see cref="num.real.vec.str.op_.binary_.multi_.ByCartesian"/>
	/// </remarks>
	public interface ITranspose { }
}
