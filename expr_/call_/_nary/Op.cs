namespace nilnul.obj.expr_.call_._nary
{
	public interface IOp {

	}

	public interface OpI<out TOp>
		:IOp
		where TOp:nilnul.obj.IOp
	{
		TOp op { get;  }
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	public class Op<TOp>

	{
		private TOp _op;
		public TOp op
		{
			get
			{
				return _op;
			}
			set
			{
				_op = value;
			}
		}
		public Op(TOp op)
		{
			this.op = op;
		}
	}
}