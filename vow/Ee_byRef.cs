namespace nilnul.obj.vow
{
	public class Ee_byRef<T, TVow>
		:
	
		_ee_.RetRefI<T>
		,
		_ee_.vow_.RetRefI<TVow>
		where TVow : nilnul.obj.Vow_ofRefI<T>
	{
		private T _ee;

		public ref T eeByRef
		{
			get { return ref _ee; }
			//set { _ee = value; }
		}

		public Ee_byRef(ref T val,ref TVow vow) 
		{
			this._ee = val;
			vow.vow(ref _ee);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val"></param>
		/// <param name="vow">in case it is an expr, convert it to a var for reference</param>
		public Ee_byRef(ref T val,TVow vow) :this(ref val, ref vow)
		{
		}
		public Ee_byRef( T val,ref TVow vow) :this(ref val, ref vow)
		{
		}
		public Ee_byRef( T val, TVow vow) :this(ref val, ref vow)
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
		static public implicit operator T(Ee_byRef<T,TVow> ee)
		{
			return ee.eeByRef;
		}

		
	}


}
