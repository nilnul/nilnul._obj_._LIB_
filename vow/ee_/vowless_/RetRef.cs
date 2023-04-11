namespace nilnul.obj.vow.ee_.vowless_
{
	public class RetRef<T, TVow>
		:
	
		_ee_.RetRefI<T>
		//,
		//_ee_.vow_.RetRefI<TVow>
		where TVow : nilnul.obj.VowI_ofIn<T>
	{
		private T _ee;

		public ref T eeByRef
		{
			get { return ref _ee; }
			//set { _ee = value; }
		}

		public RetRef(in T val,in TVow vow) 
		{
			vow.vow(in _ee);
			this._ee = val;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val"></param>
		/// <param name="vow">in case it is an expr, convert it to a var for reference</param>
		public RetRef(in T val,TVow vow) :this(in val, in vow)
		{
		}
		public RetRef( T val,in TVow vow) :this(in val, in vow)
		{
		}
		public RetRef( T val, TVow vow) :this(in val, in vow)
		{
		}


		static public implicit operator T(RetRef<T,TVow> ee)
		{
			return ee.eeByRef;
		}

		
	}


}
