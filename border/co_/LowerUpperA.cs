namespace nilnul.obj.border.co_
{
	public class LowerUpperA<T, TLower, TUpper>
		:LowerUpperI<T,TLower,TUpper>
		where TLower : border_.LowerI<T>
		where TUpper : border_.UpperI<T>

	{
		private TLower _lower;

		public TLower lower
		{
			get { return _lower; }
			set { _lower = value; }
		}

		private TUpper _upper;

		public TUpper upper
		{
			get { return _upper; }
			set { _upper = value; }
		}

		public LowerUpperA(TLower lower, TUpper upper)
		{
			_lower = lower;
			_upper = upper;
		}
	}
}
