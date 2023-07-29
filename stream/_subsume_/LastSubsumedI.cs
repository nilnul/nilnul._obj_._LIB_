using nilnul.obj.op_;

namespace nilnul.obj.stream._subsume_
{
	public interface LastSubsumedI<T>
		
	{
		/// <summary>
		/// the current of the underlying stream, which has been cumulated;
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		/// <seealso cref="slider._cumulus_.NextCumulee{T}"/>
		T justCumulated {
			get;
		}
	}
}