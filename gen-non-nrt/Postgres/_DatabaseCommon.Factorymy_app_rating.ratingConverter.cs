
namespace _DatabaseCommon.Factorymy_app_rating
{
	using global::System;
	using global::System.Collections.Generic;
	using global::System.Linq;
	using global::System.Linq.Expressions;
	using global::System.Text;
	using global::System.Threading;
	using global::System.Runtime.Serialization;
	
	
	using global::System.Globalization;
	using global::System.IO;
	using global::Revenj;
	using global::Revenj.DomainPatterns;
	using global::Revenj.Extensibility;
	using global::Revenj.DatabasePersistence;
	using global::Revenj.DatabasePersistence.Postgres;
	using global::Revenj.DatabasePersistence.Postgres.Converters;
	using global::Revenj.DomainPatterns;
	using global::Revenj.Utility;


	
	
	internal class ratingConverter : IPostgresTypeConverter
	{
		public object CreateInstance(object value, Revenj.Utility.BufferedTextReader reader, IServiceProvider locator)
		{
			if (value == null)
				return null;
			var str = value as string;
			if (str != null)
				return CreateFromRecord(reader.Reuse(str), 0, locator);
			using(var sr = value as System.IO.TextReader ?? new System.IO.StringReader(value.ToString()))
				return CreateFromRecord(reader.Reuse(sr), 0, locator);
		}

		public IPostgresTuple ToTuple(object instance)
		{
			return CreateTupleFrom(instance as global::my_app.rating);
		}

		public static IPostgresTuple CreateExtendedTupleFrom(global::my_app.rating item)
		{
			if(item == null) return null;
			var items = new IPostgresTuple[ExtendedColumnCount];			
			
			items[ExtendedProperty_id_Index] = _DatabaseCommon.Utility.GuidToTuple(item.id);
			items[ExtendedProperty_comment_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.comment);
			items[ExtendedProperty_user_id_Index] = _DatabaseCommon.Utility.NullableGuidToTuple(item.user_id);
			if (item.capturerURI != null)items[ExtendedProperty_capturerURI_Index] = new Revenj.DatabasePersistence.Postgres.Converters.ValueTuple(item.capturerURI);;
			items[ExtendedProperty_capturerID_Index] = _DatabaseCommon.Utility.GuidToTuple(item.capturerID);
			if (item.reviewerURI != null)items[ExtendedProperty_reviewerURI_Index] = new Revenj.DatabasePersistence.Postgres.Converters.ValueTuple(item.reviewerURI);;
			items[ExtendedProperty_reviewerID_Index] = _DatabaseCommon.Utility.NullableGuidToTuple(item.reviewerID);
			return RecordTuple.From(items);
		}

		public static IPostgresTuple CreateExtendedRecordTupleFrom(global::my_app.rating item, bool[] useColumn)
		{
			if(item == null) return null;
			var items = new IPostgresTuple[ExtendedColumnCount];			
			
			if (useColumn[ExtendedProperty_id_Index]) items[ExtendedProperty_id_Index] = _DatabaseCommon.Utility.GuidToTuple(item.id);
			if (useColumn[ExtendedProperty_comment_Index]) items[ExtendedProperty_comment_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.comment);
			if (useColumn[ExtendedProperty_user_id_Index]) items[ExtendedProperty_user_id_Index] = _DatabaseCommon.Utility.NullableGuidToTuple(item.user_id);
			if (item.capturerURI != null)if (useColumn[ExtendedProperty_capturerURI_Index]) items[ExtendedProperty_capturerURI_Index] = new Revenj.DatabasePersistence.Postgres.Converters.ValueTuple(item.capturerURI);;
			if (useColumn[ExtendedProperty_capturerID_Index]) items[ExtendedProperty_capturerID_Index] = _DatabaseCommon.Utility.GuidToTuple(item.capturerID);
			if (item.reviewerURI != null)if (useColumn[ExtendedProperty_reviewerURI_Index]) items[ExtendedProperty_reviewerURI_Index] = new Revenj.DatabasePersistence.Postgres.Converters.ValueTuple(item.reviewerURI);;
			if (useColumn[ExtendedProperty_reviewerID_Index]) items[ExtendedProperty_reviewerID_Index] = _DatabaseCommon.Utility.NullableGuidToTuple(item.reviewerID);
			return RecordTuple.From(items);
		}

		public static IPostgresTuple CreateTupleFrom(global::my_app.rating item)
		{
			if(item == null) return null;
			var items = new IPostgresTuple[ColumnCount];			
			
			items[Property_id_Index] = _DatabaseCommon.Utility.GuidToTuple(item.id);
			items[Property_comment_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.comment);
			items[Property_user_id_Index] = _DatabaseCommon.Utility.NullableGuidToTuple(item.user_id);
			if (item.capturerURI != null)items[Property_capturerURI_Index] = new Revenj.DatabasePersistence.Postgres.Converters.ValueTuple(item.capturerURI);;
			items[Property_capturerID_Index] = _DatabaseCommon.Utility.GuidToTuple(item.capturerID);
			if (item.reviewerURI != null)items[Property_reviewerURI_Index] = new Revenj.DatabasePersistence.Postgres.Converters.ValueTuple(item.reviewerURI);;
			items[Property_reviewerID_Index] = _DatabaseCommon.Utility.NullableGuidToTuple(item.reviewerID);
			return RecordTuple.From(items);
		}

		public static IPostgresTuple CreateRecordTupleFrom(global::my_app.rating item, bool[] useColumn)
		{
			if(item == null) return null;
			var items = new IPostgresTuple[ColumnCount];			
			
			if (useColumn[Property_id_Index]) items[Property_id_Index] = _DatabaseCommon.Utility.GuidToTuple(item.id);
			if (useColumn[Property_comment_Index]) items[Property_comment_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.comment);
			if (useColumn[Property_user_id_Index]) items[Property_user_id_Index] = _DatabaseCommon.Utility.NullableGuidToTuple(item.user_id);
			if (item.capturerURI != null)if (useColumn[Property_capturerURI_Index]) items[Property_capturerURI_Index] = new Revenj.DatabasePersistence.Postgres.Converters.ValueTuple(item.capturerURI);;
			if (useColumn[Property_capturerID_Index]) items[Property_capturerID_Index] = _DatabaseCommon.Utility.GuidToTuple(item.capturerID);
			if (item.reviewerURI != null)if (useColumn[Property_reviewerURI_Index]) items[Property_reviewerURI_Index] = new Revenj.DatabasePersistence.Postgres.Converters.ValueTuple(item.reviewerURI);;
			if (useColumn[Property_reviewerID_Index]) items[Property_reviewerID_Index] = _DatabaseCommon.Utility.NullableGuidToTuple(item.reviewerID);
			return RecordTuple.From(items);
		}

		private static int ColumnCount;
		private static int ExtendedColumnCount;

		internal static void InitializeProperties(System.Data.DataTable columnsInfo)
		{
			System.Data.DataRow row = null;
			
			ColumnCount = columnsInfo.Select("type_schema = 'my_app' AND type_name = 'rating_entity'").Length;
			ExtendedColumnCount = columnsInfo.Select("type_schema = 'my_app' AND type_name = '-ngs_rating_type-'").Length;
			
			ReaderConfiguration = new Action<global::my_app.rating, Revenj.Utility.BufferedTextReader, int, IServiceProvider>[ColumnCount > 0 ? ColumnCount : 1];
			ReaderExtendedConfiguration = new Action<global::my_app.rating, Revenj.Utility.BufferedTextReader, int, IServiceProvider>[ExtendedColumnCount > 0 ? ExtendedColumnCount : 1];
			for(int i = 0;i < ColumnCount; i++)
				ReaderConfiguration[i] = (agg, tr, c, sl) => StringConverter.Skip(tr, c);
			if(ColumnCount != ReaderConfiguration.Length)
				ReaderConfiguration[0] = (agg, tr, c, sl) => tr.Read();
			for(int i = 0;i < ExtendedColumnCount; i++)
				ReaderExtendedConfiguration[i] = (agg, tr, c, sl) => StringConverter.Skip(tr, c);
			if(ExtendedColumnCount != ReaderExtendedConfiguration.Length)
				ReaderExtendedConfiguration[0] = (agg, tr, c, sl) => tr.Read();
				
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "rating_entity", "id" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column id in type my_app.rating_entity. Check if database is out of sync with code");
			Property_id_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_id_Index] = (item, reader, context, locator) => item._id = _DatabaseCommon.Utility.ParseGuid(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_rating_type-", "id" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column id in type my_app.rating. Check if database is out of sync with code");
			ExtendedProperty_id_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_id_Index] = (item, reader, context, locator) => item._id = _DatabaseCommon.Utility.ParseGuid(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "rating_entity", "comment" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column comment in type my_app.rating_entity. Check if database is out of sync with code");
			Property_comment_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_comment_Index] = (item, reader, context, locator) => item._comment = _DatabaseCommon.Utility.ParseNullableString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_rating_type-", "comment" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column comment in type my_app.rating. Check if database is out of sync with code");
			ExtendedProperty_comment_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_comment_Index] = (item, reader, context, locator) => item._comment = _DatabaseCommon.Utility.ParseNullableString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "rating_entity", "user_id" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column user_id in type my_app.rating_entity. Check if database is out of sync with code");
			Property_user_id_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_user_id_Index] = (item, reader, context, locator) => item._user_id = _DatabaseCommon.Utility.ParseNullableGuid(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_rating_type-", "user_id" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column user_id in type my_app.rating. Check if database is out of sync with code");
			ExtendedProperty_user_id_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_user_id_Index] = (item, reader, context, locator) => item._user_id = _DatabaseCommon.Utility.ParseNullableGuid(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "rating_entity", "capturerURI" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column capturerURI in type my_app.rating_entity. Check if database is out of sync with code");
			Property_capturerURI_Index = (short)row["column_index"] - 1;
				
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_rating_type-", "capturerURI" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column capturerURI in type my_app.rating. Check if database is out of sync with code");
			ExtendedProperty_capturerURI_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_capturerURI_Index] = (item, reader, context, locator) => item._capturerURI = StringConverter.Parse(reader, context);
			
			ReaderExtendedConfiguration[ExtendedProperty_capturerURI_Index] = (item, reader, context, locator) => item._capturerURI = StringConverter.Parse(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "rating_entity", "capturerID" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column capturerID in type my_app.rating_entity. Check if database is out of sync with code");
			Property_capturerID_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_capturerID_Index] = (item, reader, context, locator) => item._capturerID = _DatabaseCommon.Utility.ParseGuid(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_rating_type-", "capturerID" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column capturerID in type my_app.rating. Check if database is out of sync with code");
			ExtendedProperty_capturerID_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_capturerID_Index] = (item, reader, context, locator) => item._capturerID = _DatabaseCommon.Utility.ParseGuid(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "rating_entity", "reviewerURI" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column reviewerURI in type my_app.rating_entity. Check if database is out of sync with code");
			Property_reviewerURI_Index = (short)row["column_index"] - 1;
				
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_rating_type-", "reviewerURI" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column reviewerURI in type my_app.rating. Check if database is out of sync with code");
			ExtendedProperty_reviewerURI_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_reviewerURI_Index] = (item, reader, context, locator) => item._reviewerURI = StringConverter.Parse(reader, context);
			
			ReaderExtendedConfiguration[ExtendedProperty_reviewerURI_Index] = (item, reader, context, locator) => item._reviewerURI = StringConverter.Parse(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "rating_entity", "reviewerID" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column reviewerID in type my_app.rating_entity. Check if database is out of sync with code");
			Property_reviewerID_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_reviewerID_Index] = (item, reader, context, locator) => item._reviewerID = _DatabaseCommon.Utility.ParseNullableGuid(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_rating_type-", "reviewerID" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column reviewerID in type my_app.rating. Check if database is out of sync with code");
			ExtendedProperty_reviewerID_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_reviewerID_Index] = (item, reader, context, locator) => item._reviewerID = _DatabaseCommon.Utility.ParseNullableGuid(reader, context);
			
			
			TableTuples = new bool[ColumnCount];
			PrimaryKeyUpdateTuples = new bool[ColumnCount];
			PrimaryKeyDeleteTuples = new bool[ColumnCount];
			TableTuples[Property_id_Index] = true;
			TableTuples[Property_comment_Index] = true;
			TableTuples[Property_user_id_Index] = true;
			TableTuples[Property_capturerID_Index] = true;
			TableTuples[Property_reviewerID_Index] = true;
			
			PrimaryKeyUpdateTuples[Property_id_Index] = true;
			PrimaryKeyDeleteTuples[Property_id_Index] = true;
		}

		private static Action<global::my_app.rating, Revenj.Utility.BufferedTextReader, int, IServiceProvider>[] ReaderConfiguration;
		private static Action<global::my_app.rating, Revenj.Utility.BufferedTextReader, int, IServiceProvider>[] ReaderExtendedConfiguration;

		public static global::my_app.rating CreateFromRecord(Revenj.Utility.BufferedTextReader reader, int context, IServiceProvider locator)
		{
			var cur = reader.Read();
			if (cur == ',' || cur == ')')
				return null;
			var result = CreateFromRecord(reader, context, context == 0 ? 1 : context << 1, locator);
			reader.Read();
			return result;
		}

		public static global::my_app.rating CreateFromRecord(Revenj.Utility.BufferedTextReader reader, int outerContext, int context, IServiceProvider locator)
		{
			reader.Read(outerContext);
			var item = new global::my_app.rating(locator);
			foreach (var config in ReaderConfiguration)
				config(item, reader, context, locator);
			reader.Read(outerContext);
			
			item.URI = _DatabaseCommon.Factorymy_app_rating.ratingConverter.BuildURI(reader.CharBuffer, item.id);
			item.__DataCachecapturer = new Lazy<IDataCache<global::my_app.user>>(() => locator.Resolve<IDataCache<global::my_app.user>>());
			item.__DataCachereviewer = new Lazy<IDataCache<global::my_app.user>>(() => locator.Resolve<IDataCache<global::my_app.user>>());
			item.__ResetChangeTracking();
			return item;
		}

		public static global::my_app.rating CreateFromExtendedRecord(Revenj.Utility.BufferedTextReader reader, int context, IServiceProvider locator)
		{
			var cur = reader.Read();
			if (cur == ',' || cur == ')')
				return null;
			var result = CreateFromExtendedRecord(reader, context, context == 0 ? 1 : context << 1, locator);
			reader.Read();
			return result;
		}

		public static global::my_app.rating CreateFromExtendedRecord(Revenj.Utility.BufferedTextReader reader, int outerContext, int context, IServiceProvider locator)
		{
			reader.Read(outerContext);
			var item = new global::my_app.rating(locator);
			foreach (var config in ReaderExtendedConfiguration)
				config(item, reader, context, locator);
			reader.Read(outerContext);
			
			item.URI = _DatabaseCommon.Factorymy_app_rating.ratingConverter.BuildURI(reader.CharBuffer, item.id);
			item.__DataCachecapturer = new Lazy<IDataCache<global::my_app.user>>(() => locator.Resolve<IDataCache<global::my_app.user>>());
			item.__DataCachereviewer = new Lazy<IDataCache<global::my_app.user>>(() => locator.Resolve<IDataCache<global::my_app.user>>());
			item.__ResetChangeTracking();
			return item;
		}

		
		
		internal static bool[] TableTuples;
		internal static bool[] PrimaryKeyUpdateTuples;
		internal static bool[] PrimaryKeyDeleteTuples;
		
		internal static string BuildURI(char[] _buf, global::System.Guid id)
		{
			int _len = 0;
			string _tmp;
			_len = _DatabaseCommon.Utility.GuidToURI(_buf, _len, id);
			return new string(_buf, 0, _len);
		}
		
		internal static void ParseURI(IServiceProvider _locator, Revenj.Utility.ChunkedMemoryStream _cms, string URI, out global::System.Guid id)
		{
			
			id = _DatabaseCommon.Utility.ToGuid(URI);
		}
		private static int Property_id_Index;
		private static int ExtendedProperty_id_Index;
		private static int Property_comment_Index;
		private static int ExtendedProperty_comment_Index;
		private static int Property_user_id_Index;
		private static int ExtendedProperty_user_id_Index;
		private static int Property_capturerURI_Index;
		private static int ExtendedProperty_capturerURI_Index;
		private static int Property_capturerID_Index;
		private static int ExtendedProperty_capturerID_Index;
		private static int Property_reviewerURI_Index;
		private static int ExtendedProperty_reviewerURI_Index;
		private static int Property_reviewerID_Index;
		private static int ExtendedProperty_reviewerID_Index;
	}

}
