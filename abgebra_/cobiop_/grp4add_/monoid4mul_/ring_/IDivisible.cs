
namespace nilnul.obj.abgebra_.cobiop_.grp4add_.monoid4mul_.ring_
{



	/// <summary>
	/// division ring;
	/// </summary>
	/// alias:
	///		divisible
	///			,somewhat near inversible
	///			,vs:
	///				inversible, which might be applied to 0, whileas divisible means for all nonnil, the inversal is nonnil.
	///		inversible
	///		
	public interface IDivisible
		:
		IRing
		,
		_divisible.IInversible4nonnil
	{
	}


}
