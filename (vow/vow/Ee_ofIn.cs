namespace nilnul.obj.vow
{
	public class Ee_ofIn<T, TVow>
		:
	
		_ee_.RetRefI<T>
		,
		_ee_.vow_.RetRefI<TVow>
		where TVow : nilnul.obj.VowI_ofIn<T>
	{
		private T _ee;

		public ref T eeByRef
		{
			get { return ref _ee; }
			//set { _ee = value; }
		}

		public Ee_ofIn(in T val,in TVow vow) 
		{
			this._ee = val;
			vow.vow(in _ee);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val"></param>
		/// <param name="vow">in case it is an expr, convert it to a var for reference</param>
		public Ee_ofIn(in T val,TVow vow) :this(in val, in vow)
		{
		}
		public Ee_ofIn( T val,in TVow vow) :this(in val, in vow)
		{
		}
		public Ee_ofIn( T val, TVow vow) :this(in val, in vow)
		{
		}




		private TVow _vow;

		public ref TVow vow
		{
			get { return ref _vow; }
			//set {
			//	value.vow(ref this._ee);
			//	_vow = value;
			//}
		}
		static public implicit operator T(Ee_ofIn<T,TVow> ee)
		{
			return ee.eeByRef;
		}

		
	}


}
