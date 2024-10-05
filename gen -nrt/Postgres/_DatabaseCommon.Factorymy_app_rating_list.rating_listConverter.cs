
namespace _DatabaseCommon.Factorymy_app_rating_list
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


	
	
	internal class rating_listConverter : IPostgresTypeConverter
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
			return CreateTupleFrom(instance as global::my_app.rating_list);
		}

		public static IPostgresTuple CreateExtendedTupleFrom(global::my_app.rating_list item)
		{
			if(item == null) return null;
			var items = new IPostgresTuple[ExtendedColumnCount];			
			
			items[ExtendedProperty_URI_Index] = new Revenj.DatabasePersistence.Postgres.Converters.ValueTuple(item.URI);
			items[ExtendedProperty_id_Index] = _DatabaseCommon.Utility.GuidToTuple(item.id);
			items[ExtendedProperty_comment_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.comment);
			items[ExtendedProperty_user_name_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.user_name);
			items[ExtendedProperty_capturer_name_Index] = _DatabaseCommon.Utility.StringToTuple(item.capturer_name);
			items[ExtendedProperty_capturer_nullable_string_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.capturer_nullable_string);
			items[ExtendedProperty_reviewer_name_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.reviewer_name);
			items[ExtendedProperty_reviewer_nullable_string_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.reviewer_nullable_string);
			return RecordTuple.From(items);
		}

		public static IPostgresTuple CreateExtendedRecordTupleFrom(global::my_app.rating_list item, bool[] useColumn)
		{
			if(item == null) return null;
			var items = new IPostgresTuple[ExtendedColumnCount];			
			
			if (useColumn[ExtendedProperty_URI_Index]) items[ExtendedProperty_URI_Index] = new Revenj.DatabasePersistence.Postgres.Converters.ValueTuple(item.URI);
			if (useColumn[ExtendedProperty_id_Index]) items[ExtendedProperty_id_Index] = _DatabaseCommon.Utility.GuidToTuple(item.id);
			if (useColumn[ExtendedProperty_comment_Index]) items[ExtendedProperty_comment_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.comment);
			if (useColumn[ExtendedProperty_user_name_Index]) items[ExtendedProperty_user_name_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.user_name);
			if (useColumn[ExtendedProperty_capturer_name_Index]) items[ExtendedProperty_capturer_name_Index] = _DatabaseCommon.Utility.StringToTuple(item.capturer_name);
			if (useColumn[ExtendedProperty_capturer_nullable_string_Index]) items[ExtendedProperty_capturer_nullable_string_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.capturer_nullable_string);
			if (useColumn[ExtendedProperty_reviewer_name_Index]) items[ExtendedProperty_reviewer_name_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.reviewer_name);
			if (useColumn[ExtendedProperty_reviewer_nullable_string_Index]) items[ExtendedProperty_reviewer_nullable_string_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.reviewer_nullable_string);
			return RecordTuple.From(items);
		}

		public static IPostgresTuple CreateTupleFrom(global::my_app.rating_list item)
		{
			if(item == null) return null;
			var items = new IPostgresTuple[ColumnCount];			
			
			items[Property_URI_Index] = new Revenj.DatabasePersistence.Postgres.Converters.ValueTuple(item.URI);
			items[Property_id_Index] = _DatabaseCommon.Utility.GuidToTuple(item.id);
			items[Property_comment_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.comment);
			items[Property_user_name_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.user_name);
			items[Property_capturer_name_Index] = _DatabaseCommon.Utility.StringToTuple(item.capturer_name);
			items[Property_capturer_nullable_string_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.capturer_nullable_string);
			items[Property_reviewer_name_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.reviewer_name);
			items[Property_reviewer_nullable_string_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.reviewer_nullable_string);
			return RecordTuple.From(items);
		}

		public static IPostgresTuple CreateRecordTupleFrom(global::my_app.rating_list item, bool[] useColumn)
		{
			if(item == null) return null;
			var items = new IPostgresTuple[ColumnCount];			
			
			if (useColumn[Property_URI_Index]) items[Property_URI_Index] = new Revenj.DatabasePersistence.Postgres.Converters.ValueTuple(item.URI);
			if (useColumn[Property_id_Index]) items[Property_id_Index] = _DatabaseCommon.Utility.GuidToTuple(item.id);
			if (useColumn[Property_comment_Index]) items[Property_comment_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.comment);
			if (useColumn[Property_user_name_Index]) items[Property_user_name_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.user_name);
			if (useColumn[Property_capturer_name_Index]) items[Property_capturer_name_Index] = _DatabaseCommon.Utility.StringToTuple(item.capturer_name);
			if (useColumn[Property_capturer_nullable_string_Index]) items[Property_capturer_nullable_string_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.capturer_nullable_string);
			if (useColumn[Property_reviewer_name_Index]) items[Property_reviewer_name_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.reviewer_name);
			if (useColumn[Property_reviewer_nullable_string_Index]) items[Property_reviewer_nullable_string_Index] = _DatabaseCommon.Utility.NullableStringToTuple(item.reviewer_nullable_string);
			return RecordTuple.From(items);
		}

		private static int ColumnCount;
		private static int ExtendedColumnCount;

		internal static void InitializeProperties(System.Data.DataTable columnsInfo)
		{
			System.Data.DataRow row = null;
			
			ColumnCount = columnsInfo.Select("type_schema = 'my_app' AND type_name = 'rating_list'").Length;
			ExtendedColumnCount = columnsInfo.Select("type_schema = 'my_app' AND type_name = '-ngs_rating_list_type-'").Length;
			
			ReaderConfiguration = new Action<global::my_app.rating_list, Revenj.Utility.BufferedTextReader, int, IServiceProvider>[ColumnCount > 0 ? ColumnCount : 1];
			ReaderExtendedConfiguration = new Action<global::my_app.rating_list, Revenj.Utility.BufferedTextReader, int, IServiceProvider>[ExtendedColumnCount > 0 ? ExtendedColumnCount : 1];
			for(int i = 0;i < ColumnCount; i++)
				ReaderConfiguration[i] = (agg, tr, c, sl) => StringConverter.Skip(tr, c);
			if(ColumnCount != ReaderConfiguration.Length)
				ReaderConfiguration[0] = (agg, tr, c, sl) => tr.Read();
			for(int i = 0;i < ExtendedColumnCount; i++)
				ReaderExtendedConfiguration[i] = (agg, tr, c, sl) => StringConverter.Skip(tr, c);
			if(ExtendedColumnCount != ReaderExtendedConfiguration.Length)
				ReaderExtendedConfiguration[0] = (agg, tr, c, sl) => tr.Read();
				
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "rating_list", "URI" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column URI in type my_app.rating_list. Check if database is out of sync with code");
			Property_URI_Index = (short)row["column_index"] - 1;
				
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_rating_list_type-", "URI" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column URI in type my_app.rating_list. Check if database is out of sync with code");
			ExtendedProperty_URI_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_URI_Index] = (item, reader, context, locator) => item.URI = StringConverter.Parse(reader, context);
			
			ReaderExtendedConfiguration[ExtendedProperty_URI_Index] = (item, reader, context, locator) => item.URI = StringConverter.Parse(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "rating_list", "id" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column id in type my_app.rating_list. Check if database is out of sync with code");
			Property_id_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_id_Index] = (item, reader, context, locator) => item._id = _DatabaseCommon.Utility.ParseGuid(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_rating_list_type-", "id" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column id in type my_app.rating_list. Check if database is out of sync with code");
			ExtendedProperty_id_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_id_Index] = (item, reader, context, locator) => item._id = _DatabaseCommon.Utility.ParseGuid(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "rating_list", "comment" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column comment in type my_app.rating_list. Check if database is out of sync with code");
			Property_comment_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_comment_Index] = (item, reader, context, locator) => item._comment = _DatabaseCommon.Utility.ParseNullableString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_rating_list_type-", "comment" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column comment in type my_app.rating_list. Check if database is out of sync with code");
			ExtendedProperty_comment_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_comment_Index] = (item, reader, context, locator) => item._comment = _DatabaseCommon.Utility.ParseNullableString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "rating_list", "user_name" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column user_name in type my_app.rating_list. Check if database is out of sync with code");
			Property_user_name_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_user_name_Index] = (item, reader, context, locator) => item._user_name = _DatabaseCommon.Utility.ParseNullableString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_rating_list_type-", "user_name" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column user_name in type my_app.rating_list. Check if database is out of sync with code");
			ExtendedProperty_user_name_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_user_name_Index] = (item, reader, context, locator) => item._user_name = _DatabaseCommon.Utility.ParseNullableString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "rating_list", "capturer_name" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column capturer_name in type my_app.rating_list. Check if database is out of sync with code");
			Property_capturer_name_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_capturer_name_Index] = (item, reader, context, locator) => item._capturer_name = _DatabaseCommon.Utility.ParseString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_rating_list_type-", "capturer_name" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column capturer_name in type my_app.rating_list. Check if database is out of sync with code");
			ExtendedProperty_capturer_name_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_capturer_name_Index] = (item, reader, context, locator) => item._capturer_name = _DatabaseCommon.Utility.ParseString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "rating_list", "capturer_nullable_string" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column capturer_nullable_string in type my_app.rating_list. Check if database is out of sync with code");
			Property_capturer_nullable_string_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_capturer_nullable_string_Index] = (item, reader, context, locator) => item._capturer_nullable_string = _DatabaseCommon.Utility.ParseNullableString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_rating_list_type-", "capturer_nullable_string" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column capturer_nullable_string in type my_app.rating_list. Check if database is out of sync with code");
			ExtendedProperty_capturer_nullable_string_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_capturer_nullable_string_Index] = (item, reader, context, locator) => item._capturer_nullable_string = _DatabaseCommon.Utility.ParseNullableString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "rating_list", "reviewer_name" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column reviewer_name in type my_app.rating_list. Check if database is out of sync with code");
			Property_reviewer_name_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_reviewer_name_Index] = (item, reader, context, locator) => item._reviewer_name = _DatabaseCommon.Utility.ParseNullableString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_rating_list_type-", "reviewer_name" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column reviewer_name in type my_app.rating_list. Check if database is out of sync with code");
			ExtendedProperty_reviewer_name_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_reviewer_name_Index] = (item, reader, context, locator) => item._reviewer_name = _DatabaseCommon.Utility.ParseNullableString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "rating_list", "reviewer_nullable_string" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column reviewer_nullable_string in type my_app.rating_list. Check if database is out of sync with code");
			Property_reviewer_nullable_string_Index = (short)row["column_index"] - 1;
				
			
			ReaderConfiguration[Property_reviewer_nullable_string_Index] = (item, reader, context, locator) => item._reviewer_nullable_string = _DatabaseCommon.Utility.ParseNullableString(reader, context);
			
			row = columnsInfo.Rows.Find(new[] { "my_app", "-ngs_rating_list_type-", "reviewer_nullable_string" });
			if(row == null)
				throw new System.ApplicationException("Couldn't find column reviewer_nullable_string in type my_app.rating_list. Check if database is out of sync with code");
			ExtendedProperty_reviewer_nullable_string_Index = (short)row["column_index"] - 1;
				
			
			ReaderExtendedConfiguration[ExtendedProperty_reviewer_nullable_string_Index] = (item, reader, context, locator) => item._reviewer_nullable_string = _DatabaseCommon.Utility.ParseNullableString(reader, context);
			
		}

		private static Action<global::my_app.rating_list, Revenj.Utility.BufferedTextReader, int, IServiceProvider>[] ReaderConfiguration;
		private static Action<global::my_app.rating_list, Revenj.Utility.BufferedTextReader, int, IServiceProvider>[] ReaderExtendedConfiguration;

		public static global::my_app.rating_list CreateFromRecord(Revenj.Utility.BufferedTextReader reader, int context, IServiceProvider locator)
		{
			var cur = reader.Read();
			if (cur == ',' || cur == ')')
				return null;
			var result = CreateFromRecord(reader, context, context == 0 ? 1 : context << 1, locator);
			reader.Read();
			return result;
		}

		public static global::my_app.rating_list CreateFromRecord(Revenj.Utility.BufferedTextReader reader, int outerContext, int context, IServiceProvider locator)
		{
			reader.Read(outerContext);
			var item = new global::my_app.rating_list(locator);
			foreach (var config in ReaderConfiguration)
				config(item, reader, context, locator);
			reader.Read(outerContext);
			
			return item;
		}

		public static global::my_app.rating_list CreateFromExtendedRecord(Revenj.Utility.BufferedTextReader reader, int context, IServiceProvider locator)
		{
			var cur = reader.Read();
			if (cur == ',' || cur == ')')
				return null;
			var result = CreateFromExtendedRecord(reader, context, context == 0 ? 1 : context << 1, locator);
			reader.Read();
			return result;
		}

		public static global::my_app.rating_list CreateFromExtendedRecord(Revenj.Utility.BufferedTextReader reader, int outerContext, int context, IServiceProvider locator)
		{
			reader.Read(outerContext);
			var item = new global::my_app.rating_list(locator);
			foreach (var config in ReaderExtendedConfiguration)
				config(item, reader, context, locator);
			reader.Read(outerContext);
			
			return item;
		}

		
		private static int Property_URI_Index;
		private static int ExtendedProperty_URI_Index;
		private static int Property_id_Index;
		private static int ExtendedProperty_id_Index;
		private static int Property_comment_Index;
		private static int ExtendedProperty_comment_Index;
		private static int Property_user_name_Index;
		private static int ExtendedProperty_user_name_Index;
		private static int Property_capturer_name_Index;
		private static int ExtendedProperty_capturer_name_Index;
		private static int Property_capturer_nullable_string_Index;
		private static int ExtendedProperty_capturer_nullable_string_Index;
		private static int Property_reviewer_name_Index;
		private static int ExtendedProperty_reviewer_name_Index;
		private static int Property_reviewer_nullable_string_Index;
		private static int ExtendedProperty_reviewer_nullable_string_Index;
	}

}
