
namespace _DatabaseConfiguration
{
	using global::System;
	using global::System.Collections.Generic;
	using global::System.Linq;
	using global::System.Linq.Expressions;
	using global::System.Text;
	using global::System.Threading;
	using global::System.Runtime.Serialization;
	

	
	
	
	internal partial class DatabaseConverters 
	{
		
		
		
		internal static void Initialize(System.Data.DataTable columnsInfo)
		{
			

			System.Data.DataRow row = null;
			_DatabaseCommon.Factorymy_app_user.userConverter.InitializeProperties(columnsInfo);
			_DatabaseCommon.Factorymy_app_rating.ratingConverter.InitializeProperties(columnsInfo);
			_DatabaseCommon.Factorymy_app_rating_list.rating_listConverter.InitializeProperties(columnsInfo);
		}

	}

}
