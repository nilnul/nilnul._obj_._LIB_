using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._matrix
{
	/// <summary>
	/// [ [0,1,2],  [3,4,5] ]
	///
	/// we have the 0th or primary dimension, which is 2 in length; it's called primary in that it's about the overrall big structure.
	/// and the auxilary dimension, which is 3 in length, as it's about a smaller component
	/// Here we avoid row or col in order to rid off ambiguity.
	/// this matrix is [2,3], where '2' appears first|front, and describes the main strucutre.
	/// 
	/// </summary>
	/// <remarks>
	/// someone would write down, with line break, of the whole structure. Let regard it as text of lines:
	///		[0,1,2]
	///		[3,4,5]
	///	This is called rowmajor, as the writedown system writes row first. The text is composed of lines or rows. The line goes from left to right here.
	///
	/// Some culture would write down vertically, col by col. next col is to the right of the previous col:
	/// then the same matrix would be written down like:
	///		0,                3
	///		1,                4
	///		2,                5
	///
	/// try it and you would find with the current computer editor tools, it is easier to write with rowmajor. That's due to the editor following our habit, or our habit following the editor.
	///
	/// In mathematics, matrix is a str; the component is vector; This wouldnot change whetherever you use rowmajor or colmajor.
	/// But you can choose to write colwise or rowwise. Generally we writ line by line, from left to right, then from top to bottom. It seems more natural to write [[0,1,2], [3,4,5] ] as :
	///		[0,1,2]
	///		[3,4,5]
	///	So rowmajor is not about how your data is stored in memory (your structure would not change), but about how you writedown/visualize your data.
	///
	/// 
	/// </remarks>
	public interface IDimensions
	{
	}
}
