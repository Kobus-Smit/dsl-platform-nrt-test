
namespace my_app
{
	using global::System;
	using global::System.Collections.Generic;
	using global::System.Linq;
	using global::System.Linq.Expressions;
	using global::System.Text;
	using global::System.Threading;
	using global::System.Runtime.Serialization;
	
	
	using global::Revenj;
	using global::Revenj.DomainPatterns;
	using global::Revenj.Extensibility;

	
	using global::Revenj;
	using global::Revenj.DomainPatterns;
	using global::Revenj.Extensibility;


	
	
	
	[Serializable]
	[DataContract(Namespace="")] public partial class rating : global::System.IEquatable<rating>, global::System.ICloneable, global::Revenj.DomainPatterns.IEntity, global::Revenj.DomainPatterns.ICacheable, global::Revenj.DomainPatterns.IAggregateRoot, global::Revenj.DomainPatterns.IChangeTracking<rating>
	{
		
		
		
		public override string ToString()
		{
			

			return base.ToString();
		}

		
		internal static void __InternalPrepareInsert(rating instance)
		{
			if (instance != null) instance.__InternalPrepareInsert();
		}
		internal void __InternalPrepareInsert()
		{
			
			id = global::System.Guid.NewGuid();
		}

		internal static void __InternalPrepareUpdate(rating instance)
		{
			if (instance != null) instance.__InternalPrepareUpdate();
		}
		internal void __InternalPrepareUpdate()
		{
			
		}

		internal static void __InternalPrepareDelete(rating instance)
		{
			if (instance != null) instance.__InternalPrepareDelete();
		}
		internal void __InternalPrepareDelete()
		{
			
		}
		
		internal static long _InternalGetSizeApproximation(rating instance)
		{
			return instance == null ? 0 : instance._InternalGetSizeApproximation();
		}

		internal long _InternalGetSizeApproximation()
		{
			long size = 35; 
			return size;
		}
		[DataMember] public string URI { get; internal set; }
		
		public rating()
			
		{
			
			this._id = global::System.Guid.NewGuid();
			this._capturerID = global::System.Guid.NewGuid();
			
			this.URI = _id.ToString();
		}

		
		private bool __EqualEntity(rating other)
		{
			return other != null 
				
				&& other.id == this.id
			;
		}

		public override int GetHashCode()
		{
			return this.URI != null ? this.URI.GetHashCode() : base.GetHashCode();
		}
		
		private rating(rating other)
		{
			this.URI = other.URI;
			
			this._id = other._id;
			this._comment = other._comment;
			this._user_id = other._user_id;
			this._capturerURI = other._capturerURI; this._capturer = other._capturer;
			this._capturerID = other._capturerID;
			this._reviewerURI = other._reviewerURI; this._reviewer = other._reviewer;
			this._reviewerID = other._reviewerID;
			
		}

		internal static rating Clone(rating instance)
		{
			return instance == null ? null : instance.Clone();
		}

		public rating Clone()
		{
			return new rating(this);
		}
		//TODO let's leave it out for now
		//public override bool Equals(object other) { return Equals(other as rating); }
		public bool Equals(rating other)
		{
			return other != null
				&& other.URI == this.URI
				
				&& other.id == this.id
				&& other.comment == this.comment
				&& other.user_id == this.user_id
				&& this._capturerURI == other._capturerURI
				&& other.capturerID == this.capturerID
				&& this._reviewerURI == other._reviewerURI
				&& other.reviewerID == this.reviewerID
			;
		}
		
		internal void __ReapplyReferences()
		{
			if (_capturer != null && _capturer.URI != capturerURI) this.capturer = _capturer;if (_reviewer != null && _reviewer.URI != reviewerURI) this.reviewer = _reviewer;
		}
		object ICloneable.Clone() { return Clone(); }
		
		bool IEquatable<global::Revenj.DomainPatterns.IEntity>.Equals(global::Revenj.DomainPatterns.IEntity obj) 
		{ 
			return __EqualEntity(obj as rating); 
		}
		
		
		Dictionary<System.Type, IEnumerable<string>> ICacheable.GetRelationships()
		{
			

			
			var result = new List<KeyValuePair<System.Type, string>>();

			result.AddRange(
				from it in new [] { this }
				let it_capturer = it.capturerURI
				where it_capturer != null
				select new KeyValuePair<System.Type, string>(typeof(global::my_app.user), it_capturer));
			result.AddRange(
				from it in new [] { this }
				let it_reviewer = it.reviewerURI
				where it_reviewer != null
				select new KeyValuePair<System.Type, string>(typeof(global::my_app.user), it_reviewer));
			return result.GroupBy(it => it.Key).ToDictionary(it => it.Key, it => it.Select(e => e.Value));

		}

		
		
		[DataMember(Name="id")]
		internal global::System.Guid _id;

		
		public global::System.Guid id
		{
			
			
			get 
			{
				
				return this._id; 
			}
			internal
			set 
			{
				
				this._id = value; 
				
			}
		}

		
		
		[DataMember(Name="comment")]
		internal string _comment;

		
		public string comment
		{
			
			
			get 
			{
				
				return this._comment; 
			}
			
			set 
			{
				
				this._comment = value; 
				
			}
		}

		
		
		[DataMember(Name="user_id")]
		internal Guid? _user_id;

		
		public Guid? user_id
		{
			
			
			get 
			{
				
				return this._user_id; 
			}
			
			set 
			{
				
				this._user_id = value; 
				
			}
		}

		internal Lazy<IDataCache<global::my_app.user>> __DataCachecapturer;
		
		
		[DataMember(EmitDefaultValue=false,Name="capturer")]
		internal global::my_app.user _capturer;

		
		public global::my_app.user capturer
		{
			
			
			get 
			{
				
				
				if (_capturerURI == null && _capturer != null)
					_capturer = null;
				
				if (_capturer != null && _capturer.URI != _capturerURI || _capturer == null && _capturerURI != null)
					if(__DataCachecapturer != null)
						_capturer = __DataCachecapturer.Value.Find(_capturerURI);
				return this._capturer; 
			}
			
			set 
			{
				
				
				if(value == null) 
					throw new ArgumentNullException("Property capturer can't be null");
				this._capturer = value; 
				
				_capturerURI = value != null ? value.URI : null;
				
				if(value == null)
					throw new ArgumentException("Property capturerID doesn't allow null values");
				else if(capturerID != value.id)
					capturerID = value.id;
			}
		}

		
		internal string _capturerURI;
		[DataMember]
		public string capturerURI 
		{ 
			get 
			{ 
				if (_capturer != null) _capturerURI = _capturer.URI;
				return _capturerURI; 
			} 
			private set { _capturerURI = value; } //TODO: serialization ;(
		}
		
		
		[DataMember(Name="capturerID")]
		internal global::System.Guid _capturerID;

		
		public global::System.Guid capturerID
		{
			
			
			get 
			{
				
				if (_capturer != null) capturerID = _capturer.id;
				return this._capturerID; 
			}
			internal
			set 
			{
				
				this._capturerID = value; 
				
			}
		}

		internal Lazy<IDataCache<global::my_app.user>> __DataCachereviewer;
		
		
		[DataMember(EmitDefaultValue=false,Name="reviewer")]
		internal global::my_app.user _reviewer;

		
		public global::my_app.user reviewer
		{
			
			
			get 
			{
				
				
				if (_reviewerURI == null && _reviewer != null)
					_reviewer = null;
				
				if (_reviewer != null && _reviewer.URI != _reviewerURI || _reviewer == null && _reviewerURI != null)
					if(__DataCachereviewer != null)
						_reviewer = __DataCachereviewer.Value.Find(_reviewerURI);
				return this._reviewer; 
			}
			
			set 
			{
				
				this._reviewer = value; 
				
				_reviewerURI = value != null ? value.URI : null;
				
				if(value == null && reviewerID != null)
					reviewerID = null;
				else if(value != null && reviewerID != value.id)
					reviewerID = value.id;
			}
		}

		
		internal string _reviewerURI;
		[DataMember]
		public string reviewerURI 
		{ 
			get 
			{ 
				if (_reviewer != null) _reviewerURI = _reviewer.URI;
				return _reviewerURI; 
			} 
			private set { _reviewerURI = value; } //TODO: serialization ;(
		}
		
		
		[DataMember(Name="reviewerID")]
		internal Guid? _reviewerID;

		
		public Guid? reviewerID
		{
			
			
			get 
			{
				
				if (_reviewer != null) reviewerID = _reviewer.id;
				return this._reviewerID; 
			}
			internal
			set 
			{
				
				this._reviewerID = value; 
				
			}
		}

		
		private rating __OriginalValue;
		internal static bool __ChangeTrackingEnabled = true;
		private bool __TrackChanges = __ChangeTrackingEnabled;
		bool IChangeTracking<rating>.TrackChanges 
		{ 
			get { return __TrackChanges; } 
			set { __TrackChanges = value; } 
		}
		internal void __ResetChangeTracking()
		{
			if(__TrackChanges)
				this.__OriginalValue = this.Clone();
		}
		rating IChangeTracking<rating>.GetOriginalValue()
		{
			return __OriginalValue;
		}
		
		
		
		[System.Runtime.Serialization.OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
			

			
			var locator = context.Context as global::System.IServiceProvider;
			if (locator == null) return;
			if(capturerURI == null) throw new ArgumentException("In entity my_app.rating, property capturer can't be null. capturerURI provided as null");
			__DataCachecapturer = new Lazy<IDataCache<global::my_app.user>>(() => locator.Resolve<IDataCache<global::my_app.user>>());
			__DataCachereviewer = new Lazy<IDataCache<global::my_app.user>>(() => locator.Resolve<IDataCache<global::my_app.user>>());
		}

		
		internal rating(IServiceProvider locator)
			
		{
			
			__DataCachecapturer = new Lazy<IDataCache<global::my_app.user>>(() => locator.Resolve<IDataCache<global::my_app.user>>());
			__DataCachereviewer = new Lazy<IDataCache<global::my_app.user>>(() => locator.Resolve<IDataCache<global::my_app.user>>());
			
		}

	}

}
