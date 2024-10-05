
namespace my_app
{
	using global::System;
	using global::System.Collections.Generic;
	using global::System.Linq;
	using global::System.Linq.Expressions;
	using global::System.Text;
	using global::System.Threading;
	using global::System.Runtime.Serialization;
	

	
	
	
	[DataContract(Namespace="")] public partial class user : global::System.IEquatable<user>, global::System.ICloneable
	{
		
		
		
		public override string ToString()
		{
			

			return base.ToString();
		}

		[DataMember] public string URI { get; internal set; }
		
		public user()
			
		{
			
			this._id = global::System.Guid.NewGuid();
			
			this.URI = _id.ToString();
		}

		
		private bool __EqualEntity(user other)
		{
			return other != null 
				
				&& other.id == this.id
			;
		}

		public override int GetHashCode()
		{
			return this.URI != null ? this.URI.GetHashCode() : base.GetHashCode();
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

		public user Clone()
		{
			return new user(this);
		}
		//TODO let's leave it out for now
		//public override bool Equals(object other) { return Equals(other as user); }
		public bool Equals(user other)
		{
			return other != null
				&& other.URI == this.URI
				
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
		internal string _nullable_string;

		
		public string nullable_string
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
		internal System.Collections.Generic.List<string> _nullable_string_list;

		
		public System.Collections.Generic.List<string> nullable_string_list
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

	}

}
