
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


	
	
	
	[DataContract(Namespace="")] public partial class user : global::System.IEquatable<user>, global::System.ICloneable, global::Revenj.DomainPatterns.IAggregateRoot
	{
		
		
		
		public override string ToString()
		{
			

			return base.ToString();
		}

		
		[DataMember] public string URI { get; internal set; }
		internal IServiceProvider __locator;
		
		public user()
			
		{
			
			this.URI = base.GetHashCode().ToString();
			this._id = global::System.Guid.NewGuid();
			
			this.URI = _id.ToString();
		}

		
		public global::my_app.user Clone()
		{
			return new user(this);
		}
		private user(user other)
		{
			this.URI = other.URI;
			
			this._id = other._id;
			this._name = other._name;
			this._nullable_int = other._nullable_int;
			this._nullable_string = other._nullable_string;
			this._nullable_string_list = other._nullable_string_list == null ? null : other._nullable_string_list.ToList();
		}
		internal static user Clone(user instance)
		{
			return instance == null ? null : instance.Clone();
		}
		bool IEquatable<user>.Equals(user other)
		{
			return other.URI == this.URI
				
				&& other.id == this.id
				&& other.name == this.name
				&& other.nullable_int == this.nullable_int
				&& other.nullable_string == this.nullable_string
				&& (this.nullable_string_list == other.nullable_string_list || this.nullable_string_list != null && other.nullable_string_list != null && this.nullable_string_list.SequenceEqual(other.nullable_string_list))
			;
		}
		
		internal void __ReapplyReferences()
		{
			
		}
		object ICloneable.Clone() { return Clone(); }
		
		public static event Action<user> Validating = a => { };
		public void Validate()
		{
			Validating(this);
		}
		
		internal void UpdateWithAnother(global::my_app.user result)
		{
			this.URI = result.URI;
			
			this.id = result.id;
			this.name = result.name;
			this.nullable_int = result.nullable_int;
			this.nullable_string = result.nullable_string;
			this.nullable_string_list = result.nullable_string_list;
		}
		private global::my_app.user Create(IServiceProvider locator = null)
		{
			var proxy = (locator ?? Static.Locator).Resolve<Revenj.ICrudProxy>();
			var result = proxy.Create(this).Result;
			this.URI = result.URI;
			this.id = result.id;
			this.__locator = locator ?? Static.Locator;
			return this;
		}
		private global::my_app.user Update()
		{
			if (__locator == null) throw new ArgumentException("Can't update new aggregate");
			var proxy = __locator.Resolve<Revenj.ICrudProxy>();
			var result = proxy.Update(this).Result;
			this.URI = result.URI;
			this.id = result.id;
			return this;
		}
		private global::my_app.user Delete()
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

		
		
		[DataMember(Name="name")]
		internal string _name = string.Empty;

		
		public string name
		{
			
			
			get 
			{
				
				return this._name; 
			}
			
			set 
			{
				
				this._name = value; 
				
			}
		}

		
		
		[DataMember(Name="nullable_int")]
		internal int? _nullable_int;

		
		public int? nullable_int
		{
			
			
			get 
			{
				
				return this._nullable_int; 
			}
			
			set 
			{
				
				this._nullable_int = value; 
				
			}
		}

		
		
		[DataMember(Name="nullable_string")]
		internal string? _nullable_string;

		
		public string? nullable_string
		{
			
			
			get 
			{
				
				return this._nullable_string; 
			}
			
			set 
			{
				
				this._nullable_string = value; 
				
			}
		}

		
		
		[DataMember(Name="nullable_string_list")]
		internal System.Collections.Generic.List<string>? _nullable_string_list;

		
		public System.Collections.Generic.List<string>? nullable_string_list
		{
			
			
			get 
			{
				
				return this._nullable_string_list; 
			}
			
			set 
			{
				
				
				if(value != null)
				{
					var __elIndx = 0;
					foreach(var it in value)
					{
						if(it == null)
							throw new ArgumentException(string.Format("Null element found at index {0} in property \"nullable_string_list\" in object \"my_app.user\". Collection elements can't be null.", __elIndx));
						__elIndx++;
					}
				}
				this._nullable_string_list = value; 
				
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
