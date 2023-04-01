namespace nilnul.bit
{
	public class Comp : CompI
	{
		public int Compare(bool x, bool y)
		{
			return x.CompareTo(y);
			return nilnul.bit.to_.Int.Singleton.to(x).CompareTo(
				nilnul.bit.to_.Int.Singleton.to(y)
			);
			
		}

		static public Comp Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Comp>.Instance;
			}
		}

	}
}
