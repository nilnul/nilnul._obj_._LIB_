using nilnul.obj.op_;

namespace nilnul.obj.stream_.slider
{
	/// <summary>
	/// unlike series which as a slider takes 0 as it's initial value, this take the underhood slider's current as initial value;
	/// 
	/// the index is the same as the underlying slider's index;
	/// vs:
	///		<see cref="stream.Cumulated{T, TStream, TFold}"/>
	/// </summary>
	/// 
	public interface ISubsume:stream.ISubsume
	{
		
	}

}