namespace nilnul.obj._call_
{

	public interface OpI1<out TOp>
		:BlankI
		where TOp:nilnul.obj._op_.BlankI
	{
		TOp op { get;  }
	}
}