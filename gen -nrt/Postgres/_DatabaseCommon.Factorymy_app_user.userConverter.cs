
namespace _DatabaseCommon.Factorymy_app_user
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


	
	
	internal class userConverter : IPostgresTypeConverter
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
			return CreateTupleFrom(instance as global::my_app.user);
		}

		public static IPostgresTuple CreateExtendedTupleFrom(global::my_app.user item)
		{
			if(item == null) return null;
			var items = new IPostgresTuple[ExtendedColumnCount];			
			
			items[ExtendedProperty_id_Index] = _DatabaseCommon.Utility.GuidToTuple(item.id);
			items[ExtendedProperty_name_Index] = _DatabaseCommon.Utility.StringToTuple(item.name);
			items[ExtendedProperty_nullable_int_Index] = _DatabaseCommon.Utility.NullableIntegerToTuple(item.nullable_int);
			items[ExtendedProperty_nullable_string_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.nullable_string);
			items[ExtendedProperty_nullable_string_list_Index] = ArrayTuple.Create(item.nullable_string_list, _DatabaseCommon.Utility.StringToTuple);
			return RecordTuple.From(items);
		}

		public static IPostgresTuple CreateExtendedRecordTupleFrom(global::my_app.user item, bool[] useColumn)
		{
			if(item == null) return null;
			var items = new IPostgresTuple[ExtendedColumnCount];			
			
			if (useColumn[ExtendedProperty_id_Index]) items[ExtendedProperty_id_Index] = _DatabaseCommon.Utility.GuidToTuple(item.id);
			if (useColumn[ExtendedProperty_name_Index]) items[ExtendedProperty_name_Index] = _DatabaseCommon.Utility.StringToTuple(item.name);
			if (useColumn[ExtendedProperty_nullable_int_Index]) items[ExtendedProperty_nullable_int_Index] = _DatabaseCommon.Utility.NullableIntegerToTuple(item.nullable_int);
			if (useColumn[ExtendedProperty_nullable_string_Index]) items[ExtendedProperty_nullable_string_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.nullable_string);
			if (useColumn[ExtendedProperty_nullable_string_list_Index]) items[ExtendedProperty_nullable_string_list_Index] = ArrayTuple.Create(item.nullable_string_list, _DatabaseCommon.Utility.StringToTuple);
			return RecordTuple.From(items);
		}

		public static IPostgresTuple CreateTupleFrom(global::my_app.user item)
		{
			if(item == null) return null;
			var items = new IPostgresTuple[ColumnCount];			
			
			items[Property_id_Index] = _DatabaseCommon.Utility.GuidToTuple(item.id);
			items[Property_name_Index] = _DatabaseCommon.Utility.StringToTuple(item.name);
			items[Property_nullable_int_Index] = _DatabaseCommon.Utility.NullableIntegerToTuple(item.nullable_int);
			items[Property_nullable_string_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.nullable_string);
			items[Property_nullable_string_list_Index] = ArrayTuple.Create(item.nullable_string_list, _DatabaseCommon.Utility.StringToTuple);
			return RecordTuple.From(items);
		}

		public static IPostgresTuple CreateRecordTupleFrom(global::my_app.user item, bool[] useColumn)
		{
			if(item == null) return null;
			var items = new IPostgresTuple[ColumnCount];			
			
			if (useColumn[Property_id_Index]) items[Property_id_Index] = _DatabaseCommon.Utility.GuidToTuple(item.id);
			if (useColumn[Property_name_Index]) items[Property_name_Index] = _DatabaseCommon.Utility.StringToTuple(item.name);
			if (useColumn[Property_nullable_int_Index]) items[Property_nullable_int_Index] = _DatabaseCommon.Utility.NullableIntegerToTuple(item.nullable_int);
			if (useColumn[Property_nullable_string_Index]) items[Property_nullable_string_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.nullable_string);
			if (useColumn[Property_nullable_string_list_Index]) items[Property_nullable_string_list_Index] = ArrayTuple.Create(item.nullable_string_list, _DatabaseCommon.Utility.StringToTuple);
			return RecordTuple.From(items);
		}

		private static int ColumnCount;
		private static int ExtendedColumnCount;

		internal static void InitializeProperties(System.Data.DataTable columnsInfo)
		{
			System.Data.DataRow row = null;
			
			ColumnCount = columnsInfo.Select("type_schema = 'my_app' AND type_name = 'user_entity'").Length;
			ExtendedColumnCount = columnsInfo.Select("type_schema = 'my_app' AND type_name = '-ngs_user_type-'").Length;
			
			ReaderConfiguration = new Action<global::my_app.user, Revenj.Utility.BufferedTextReader, int, IServiceProvider>[ColumnCount > 0 ? ColumnCount : 1];
			ReaderExtendedConfiguration = new Action<global::my_app.user, Revenj.Utility.BufferedTextReader, int, IServiceProvider>[ExtendedColumnCount > 0 ? ExtendedColumnCount : 1];
			for(int i = 0;i < ColumnCount; i++)
				ReaderConfiguration[i] = (agg, tr, c, sl) => StringConverter.Skip(tr, c);
			if(ColumnCount != ReaderConfiguration.Length)
				ReaderConfiguration[0] = (agg, tr, c, sl) => tr.Read();
			for(int i = 0;i < ExtendedColumnCount; i++)
				ReaderExtendedConfiguration[i] = (agg, tr, c, sl) => StringConverter.Skip(tr, c);
			if(ExtendedColumnCount != ReaderExtendedConfiguration.Length)
				ReaderExtendedConfiguration[0] = (agg, tr, c, sl) => tr.Read();
				
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "user_entity", "id" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column id in type my_app.user_entity. Check if database is out of sync with code");
			Property_id_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_id_Index] = (item, reader, context, locator) => item._id = _DatabaseCommon.Utility.ParseGuid(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_user_type-", "id" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column id in type my_app.user. Check if database is out of sync with code");
			ExtendedProperty_id_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_id_Index] = (item, reader, context, locator) => item._id = _DatabaseCommon.Utility.ParseGuid(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "user_entity", "name" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column name in type my_app.user_entity. Check if database is out of sync with code");
			Property_name_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_name_Index] = (item, reader, context, locator) => item._name = _DatabaseCommon.Utility.ParseString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_user_type-", "name" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column name in type my_app.user. Check if database is out of sync with code");
			ExtendedProperty_name_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_name_Index] = (item, reader, context, locator) => item._name = _DatabaseCommon.Utility.ParseString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "user_entity", "nullable_int" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column nullable_int in type my_app.user_entity. Check if database is out of sync with code");
			Property_nullable_int_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_nullable_int_Index] = (item, reader, context, locator) => item._nullable_int = _DatabaseCommon.Utility.ParseNullableInt(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_user_type-", "nullable_int" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column nullable_int in type my_app.user. Check if database is out of sync with code");
			ExtendedProperty_nullable_int_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_nullable_int_Index] = (item, reader, context, locator) => item._nullable_int = _DatabaseCommon.Utility.ParseNullableInt(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "user_entity", "nullable_string" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column nullable_string in type my_app.user_entity. Check if database is out of sync with code");
			Property_nullable_string_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_nullable_string_Index] = (item, reader, context, locator) => item._nullable_string = _DatabaseCommon.Utility.ParseNullableString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_user_type-", "nullable_string" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column nullable_string in type my_app.user. Check if database is out of sync with code");
			ExtendedProperty_nullable_string_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_nullable_string_Index] = (item, reader, context, locator) => item._nullable_string = _DatabaseCommon.Utility.ParseNullableString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "user_entity", "nullable_string_list" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column nullable_string_list in type my_app.user_entity. Check if database is out of sync with code");
			Property_nullable_string_list_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_nullable_string_list_Index] = (item, reader, context, locator) => { var __list = _DatabaseCommon.Utility.ParseListString(reader, context); if(__list != null) item._nullable_string_list = __list; };
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_user_type-", "nullable_string_list" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column nullable_string_list in type my_app.user. Check if database is out of sync with code");
			ExtendedProperty_nullable_string_list_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_nullable_string_list_Index] = (item, reader, context, locator) => { var __list = _DatabaseCommon.Utility.ParseListString(reader, context); if(__list != null) item._nullable_string_list = __list; };
			
			
			TableTuples = new bool[ColumnCount];
			PrimaryKeyUpdateTuples = new bool[ColumnCount];
			PrimaryKeyDeleteTuples = new bool[ColumnCount];
			TableTuples[Property_id_Index] = true;
			TableTuples[Property_name_Index] = true;
			TableTuples[Property_nullable_int_Index] = true;
			TableTuples[Property_nullable_string_Index] = true;
			TableTuples[Property_nullable_string_list_Index] = true;
			
			PrimaryKeyUpdateTuples[Property_id_Index] = true;
			PrimaryKeyDeleteTuples[Property_id_Index] = true;
		}

		private static Action<global::my_app.user, Revenj.Utility.BufferedTextReader, int, IServiceProvider>[] ReaderConfiguration;
		private static Action<global::my_app.user, Revenj.Utility.BufferedTextReader, int, IServiceProvider>[] ReaderExtendedConfiguration;

		public static global::my_app.user CreateFromRecord(Revenj.Utility.BufferedTextReader reader, int context, IServiceProvider locator)
		{
			var cur = reader.Read();
			if (cur == ',' || cur == ')')
				return null;
			var result = CreateFromRecord(reader, context, context == 0 ? 1 : context << 1, locator);
			reader.Read();
			return result;
		}

		public static global::my_app.user CreateFromRecord(Revenj.Utility.BufferedTextReader reader, int outerContext, int context, IServiceProvider locator)
		{
			reader.Read(outerContext);
			var item = new global::my_app.user(locator);
			foreach (var config in ReaderConfiguration)
				config(item, reader, context, locator);
			reader.Read(outerContext);
			
			item.URI = _DatabaseCommon.Factorymy_app_user.userConverter.BuildURI(reader.CharBuffer, item.id);
			item.__ResetChangeTracking();
			return item;
		}

		public static global::my_app.user CreateFromExtendedRecord(Revenj.Utility.BufferedTextReader reader, int context, IServiceProvider locator)
		{
			var cur = reader.Read();
			if (cur == ',' || cur == ')')
				return null;
			var result = CreateFromExtendedRecord(reader, context, context == 0 ? 1 : context << 1, locator);
			reader.Read();
			return result;
		}

		public static global::my_app.user CreateFromExtendedRecord(Revenj.Utility.BufferedTextReader reader, int outerContext, int context, IServiceProvider locator)
		{
			reader.Read(outerContext);
			var item = new global::my_app.user(locator);
			foreach (var config in ReaderExtendedConfiguration)
				config(item, reader, context, locator);
			reader.Read(outerContext);
			
			item.URI = _DatabaseCommon.Factorymy_app_user.userConverter.BuildURI(reader.CharBuffer, item.id);
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
		private static int Property_name_Index;
		private static int ExtendedProperty_name_Index;
		private static int Property_nullable_int_Index;
		private static int ExtendedProperty_nullable_int_Index;
		private static int Property_nullable_string_Index;
		private static int ExtendedProperty_nullable_string_Index;
		private static int Property_nullable_string_list_Index;
		private static int ExtendedProperty_nullable_string_list_Index;
	}

}
