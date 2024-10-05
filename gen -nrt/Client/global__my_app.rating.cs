
namespace my_app
{
	using global::System;
	using global::System.Collections.Generic;
	using global::System.Linq;
	using global::System.Linq.Expressions;
	using global::System.Text;
	using global::System.Threading;
	using global::System.Runtime.Serialization;
	
	
	using Revenj.DomainPatterns;
	using Revenj;


	
	
	
	[DataContract(Namespace="")] public partial class rating : global::System.IEquatable<rating>, global::System.ICloneable, global::Revenj.DomainPatterns.IAggregateRoot
	{
		
		
		
		public override string ToString()
		{
			

			return base.ToString();
		}

		
		[DataMember] public string URI { get; internal set; }
		internal IServiceProvider __locator;
		
		public rating()
			
		{
			
			this.URI = base.GetHashCode().ToString();
			this._id = global::System.Guid.NewGuid();
			this._capturerID = global::System.Guid.NewGuid();
			
			this.URI = _id.ToString();
		}

		
		public global::my_app.rating Clone()
		{
			return new rating(this);
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
		bool IEquatable<rating>.Equals(rating other)
		{
			return other.URI == this.URI
				
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
		
		public static event Action<rating> Validating = a => { };
		public void Validate()
		{
			Validating(this);
		}
		
		internal void UpdateWithAnother(global::my_app.rating result)
		{
			this.URI = result.URI;
			
			this.id = result.id;
			this.comment = result.comment;
			this.user_id = result.user_id;
			this.capturer = result.capturer;
			this._capturerURI = result._capturerURI;
			this.capturerID = result.capturerID;
			this.reviewer = result.reviewer;
			this._reviewerURI = result._reviewerURI;
			this.reviewerID = result.reviewerID;
		}
		private global::my_app.rating Create(IServiceProvider locator = null)
		{
			var proxy = (locator ?? Static.Locator).Resolve<Revenj.ICrudProxy>();
			var result = proxy.Create(this).Result;
			this.URI = result.URI;
			this.id = result.id;
			this.__locator = locator ?? Static.Locator;
			return this;
		}
		private global::my_app.rating Update()
		{
			if (__locator == null) throw new ArgumentException("Can't update new aggregate");
			var proxy = __locator.Resolve<Revenj.ICrudProxy>();
			var result = proxy.Update(this).Result;
			this.URI = result.URI;
			this.id = result.id;
			return this;
		}
		private global::my_app.rating Delete()
		{
			if (__locator == null) throw new ArgumentException("Can't delete new aggregate");
			var proxy = __locator.Resolve<Revenj.ICrudProxy>();
			return proxy.Delete(this).Result;
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
		internal string? _comment;

		
		public string? comment
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

		
		
		[DataMember(EmitDefaultValue=false,Name="capturer")]
		internal global::my_app.user _capturer;

		
		public global::my_app.user capturer
		{
			
			
			get 
			{
				
				
				if (_capturerURI == null && _capturer != null)
					_capturer = null;
				
				if (__locator != null && _capturer != null && _capturer.URI != _capturerURI || _capturer == null && _capturerURI != null)
					_capturer = __locator.Resolve<Revenj.ICrudProxy>().Read<global::my_app.user>(_capturerURI).Result;
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

		
		
		[DataMember(EmitDefaultValue=false,Name="reviewer")]
		internal global::my_app.user? _reviewer;

		
		public global::my_app.user? reviewer
		{
			
			
			get 
			{
				
				
				if (_reviewerURI == null && _reviewer != null)
					_reviewer = null;
				
				if (__locator != null && _reviewer != null && _reviewer.URI != _reviewerURI || _reviewer == null && _reviewerURI != null)
					_reviewer = __locator.Resolve<Revenj.ICrudProxy>().Read<global::my_app.user>(_reviewerURI).Result;
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

		
		
		
		[System.Runtime.Serialization.OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
			

			
			var locator = context.Context as IServiceProvider;
			if (locator == null) return;
			__locator = locator;
		}

	}

}
