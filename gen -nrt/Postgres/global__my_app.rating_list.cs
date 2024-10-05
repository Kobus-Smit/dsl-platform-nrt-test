
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


	
	
	
	[Serializable]
	[DataContract(Namespace="")] public partial class rating_list : global::Revenj.DomainPatterns.IEntity, global::Revenj.DomainPatterns.IIdentifiable, global::Revenj.DomainPatterns.ISnowflake<global::my_app.rating>
	{
		
		
		
		public override string ToString()
		{
			

			return base.ToString();
		}

		
		bool IEquatable<IEntity>.Equals(IEntity other)
		{
			var o = other as global::my_app.rating_list;
			return o != null && o.URI == this.URI;
		}
		[DataMember] public string URI { get; internal set; }
		
		public rating_list()
			
		{
			
			
		}

		
		
		public void Update(global::my_app.rating entity)
		{
			

			this.URI = entity.URI;
			this.id = entity.id;
			this.comment = entity.comment;
			this.capturer_name = entity.capturer != null  ? entity.capturer.name : default(string);
			this.capturer_nullable_string = entity.capturer != null  ? entity.capturer.nullable_string : default(string);
			this.reviewer_name = entity.reviewer != null  ? entity.reviewer.name : default(string);
			this.reviewer_nullable_string = entity.reviewer != null  ? entity.reviewer.nullable_string : default(string);
		}

		
		public static rating_list CreateFrom(global::my_app.rating entity)
		{
			var snowflake = new rating_list();
			snowflake.Update(entity);
			return snowflake;
		}
		
		
		[DataMember(Name="id")]
		internal global::System.Guid _id;

		
		public global::System.Guid id
		{
			
			
			get 
			{
				
				return this._id; 
			}
			
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

		
		
		[DataMember(Name="user_name")]
		internal string _user_name;

		
		public string user_name
		{
			
			
			get 
			{
				
				return this._user_name; 
			}
			
			set 
			{
				
				this._user_name = value; 
				
			}
		}

		
		
		[DataMember(Name="capturer_name")]
		internal string _capturer_name = string.Empty;

		
		public string capturer_name
		{
			
			
			get 
			{
				
				return this._capturer_name; 
			}
			
			set 
			{
				
				this._capturer_name = value; 
				
			}
		}

		
		
		[DataMember(Name="capturer_nullable_string")]
		internal string _capturer_nullable_string;

		
		public string capturer_nullable_string
		{
			
			
			get 
			{
				
				return this._capturer_nullable_string; 
			}
			
			set 
			{
				
				this._capturer_nullable_string = value; 
				
			}
		}

		
		
		[DataMember(Name="reviewer_name")]
		internal string _reviewer_name;

		
		public string reviewer_name
		{
			
			
			get 
			{
				
				return this._reviewer_name; 
			}
			
			set 
			{
				
				this._reviewer_name = value; 
				
			}
		}

		
		
		[DataMember(Name="reviewer_nullable_string")]
		internal string _reviewer_nullable_string;

		
		public string reviewer_nullable_string
		{
			
			
			get 
			{
				
				return this._reviewer_nullable_string; 
			}
			
			set 
			{
				
				this._reviewer_nullable_string = value; 
				
			}
		}

		
		
		
		[System.Runtime.Serialization.OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
			

			
			var locator = context.Context as global::System.IServiceProvider;
			if (locator == null) return;
		}

		
		internal rating_list(IServiceProvider locator)
			
		{
			
			
		}

	}

}
